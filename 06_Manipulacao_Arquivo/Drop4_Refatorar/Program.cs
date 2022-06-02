// 4) Fazer um programa em VS, como o programa de número 2, entretando os emails devem ser coletados de um arquivo
// e populados em uma lista. Uma vez populados os emails na lista, o programa deve separar o nome de usuário (antes do @)
// do domínio do email (depois do @). Ao final, o programa deve exibir os domínios utilizados no cadastro 
// (não pode exibir os repetidos).

// Observação: os domínio são, por exemplo, gmail.com; yahoo.com.br; ufn.edu.br; hotmail.com; entre outros.

// Sugere-se usar um menu como:

// MENU 
// 1 - Abrir arquivo com emails e popular lista
// 2 - Mostrar lista de emails
// 3 - Mostrar dominíos de emails
// 4 - Sair
// Opção:____

//Drop4 - refatorar
// A partir do Drop4, refatora-lo para que o usuário possa cadastrar email na lista e incluir no arquivo/add/append.
// Para isso, sugiro criar a opção de menu 4- Cadastrar email e passar a opção Sair para o número 5

List<string> listaEmails = new List<string>();
List<string> listaDominios = new List<string>();
string opcao;
string email;

do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Abrir arquivo com emails e popular lista");
    Console.WriteLine("2 - Exibir lista de emails");
    Console.WriteLine("3 - Mostrar os domínios dos emails");
    Console.WriteLine("4 - Cadastrar email");
    Console.WriteLine("5 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //populando lista com emails
            Console.WriteLine("Abrindo arquivo de emails e populando a lista");
            //string email;

            //abrir e ler os dados do arquivo, populando na lista
            try //tratamento de exceções
            {
                String nomeArquivo;
                Console.Write("Digite o nome do arquivo com os emails: ");
                nomeArquivo = Console.ReadLine();
                StreamReader leitor = new StreamReader(nomeArquivo); //abre o arquivo para leitura
                //StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //abre o arquivo para leitura

                do
                {
                    email = leitor.ReadLine();

                    if (!listaEmails.Contains(email))
                    {
                        listaEmails.Add(email);

                        string[] emailSplit;
                        string dominio;
                        emailSplit = email.Split("@");
                        dominio = emailSplit[1];
                        if (!listaDominios.Contains(dominio))
                        {
                            listaDominios.Add(dominio);
                        }
                        listaDominios.Sort();
                    }

                } while (!leitor.EndOfStream);

                leitor.Close(); //fecha o objeto que representa o arquivo
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
            }
            break;
        case "2":
            //exibir lista dos emails
            Console.WriteLine("Exibindo a lista de emails");
            if (listaEmails.Count == 0)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                for (int i = 0; i < listaEmails.Count; i++)
                {
                    Console.WriteLine(listaEmails[i]);
                }
                // foreach (int i in listaEmails)
                // {
                //     Console.WriteLine(i);
                // }
            }
            break;
        case "3":
            Console.WriteLine("Exibindo os domínios dos emails");
            if (listaEmails.Count == 0)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                //listaDominios.Sort(); - poderia ser aqui
                foreach (string i in listaDominios)
                {
                    Console.WriteLine(i);
                }
            }
            break;
        case "4":
            //cadastrar novo email na lista e no arquivo = append novo email
            Console.WriteLine("Cadastrando novo email");

            if (listaEmails.Count.Equals(0)) //abrir arquivo e popular lista
            {

                //abrir e ler os dados do arquivo, populando na lista
                try //tratamento de exceções
                {
                    StreamReader leitor = new StreamReader("emails.txt"); //abre o arquivo para leitura
                                                                          //StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //abre o arquivo para leitura
                    do
                    {
                        email = leitor.ReadLine();
                        //populando a lista...
                        listaEmails.Add(email);

                    } while (!leitor.EndOfStream);

                    leitor.Close(); //fecha o objeto que representa o arquivo
                }
                catch (IOException e)
                {
                    Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
                }
            }

            try// inserindo novo email
            {

                StreamWriter escritor = new StreamWriter("emails.txt", true);
                Console.WriteLine("Digite um novo email:");
                email = Console.ReadLine().ToLower();
                if (!listaEmails.Contains(email))
                {
                    listaEmails.Add(email);
                    escritor.WriteLine(email);
                    escritor.Flush(); //salva/confirma linha no arquivo
                    Console.WriteLine("Email gravado");
                }
                else
                {
                    Console.WriteLine("Email já cadastrado.");
                }
                escritor.Close();
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro ao salvar email ==> " + erro.Message);
                //throw;
            }
            break;
        case "5":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "5");
