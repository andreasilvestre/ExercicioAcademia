// Fazer um programa em VS que recebe nome e email de uma pessoa e grava num arquivo.


using Drop6_Refazer;

string nomeArquivo = "emails.dat"; //guarda nome e email
string opcao = ""; //opção menu

List<Pessoa> listaPessoas = new List<Pessoa>();


//first: Verifica se existe arquivo e popula lista
try
{
    StreamReader leitor = new StreamReader(nomeArquivo);
    string linha;
    string[] dados; //auxiliar para splitar linha por ;==> vetor
    do
    {

        linha = leitor.ReadLine();
        dados = linha.Split(";");
        //popular classe e lista
        Pessoa p = new Pessoa(dados[0], dados[1]);
        listaPessoas.Add(p);

    } while (!leitor.EndOfStream);
    leitor.Close();
}
catch (Exception erro)
{
    //nao faz nada, pq o arquivo será criado na linha 40 StreamWriter cria arquivo que não existe

    //Console.WriteLine("Erro ao abrir o arquivo " + erro.Message);
    //Console.Write("Pressione algo para continuar!");
    //Console.ReadKey();
    //throw;
}

StreamWriter escritor = new StreamWriter(nomeArquivo, true); //abre arquivo com append
//StreamWriter escritor = new StreamWriter(nomeArquivo); // sem true, overrride/substitui o arquivo antigo

do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Cadastrar uma pessoa");
    Console.WriteLine("2 - Exibir pessoas");
    Console.WriteLine("3 - Sair");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //cadastrar pesssoa
            try
            {
                string nome;
                string email;

                Console.Write("Digite o nome: ");
                nome = Console.ReadLine().ToUpper();
                Console.Write("Digite o email: ");
                email = Console.ReadLine().ToLower();

                Pessoa p = new Pessoa(nome, email);

                //verifica se a pessoa já está na lista e no arquivo
                bool jaCadastrado = false;
                foreach (Pessoa i in listaPessoas)
                {
                    if (i.email.Equals(email))
                    {
                        Console.WriteLine("Email já está no sistema");
                        jaCadastrado = true;
                        break;
                    }
                }//fim pesquisa já cadastrado

                if (!jaCadastrado)
                {
                    listaPessoas.Add(p);
                    escritor.WriteLine(p.nome + ";" + p.email);
                    escritor.Flush();
                }

            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro ao gravar o arquivo " + erro.Message);
                //throw;
            }
            
            break;
        case "2":
            //exibir pessoas
            Console.WriteLine("Exibindo a lista de pessoas...");
            foreach (Pessoa i in listaPessoas)
            {
                Console.WriteLine(i.nome + " ==> " + i.email);
            }

            break;
        case "3":
            //sair
            Console.WriteLine("Obrigado por usar o sistema.");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "3");
escritor.Close();   

