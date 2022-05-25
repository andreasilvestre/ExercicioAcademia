//#6
//Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
//tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
//um método para exibir um objeto (x, y).
//Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
//os objetos da lista.
using Exercicio06;
string maisObjeto = "S";
string opcao = "";


List<Objeto> listaObjetos = new List<Objeto>();

do
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Cadastrar objeto");
    Console.WriteLine("2 - Exibir um objeto");
    Console.WriteLine("3 - Exibir a lista toda de objetos");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("Opção___");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //cadastrar objeto
            int x;
            int y;
            while (maisObjeto == "S")
            {

                Console.Clear();
                Console.Write("Digite o valor x: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor y: ");
                y = int.Parse(Console.ReadLine());

                listaObjetos.Add(new Objeto(x, y));

                Console.WriteLine("Deseja acrescentar mais objetos? [S/N]");
                maisObjeto = Console.ReadLine().ToUpper();
            }
            break;
        case "2":
            //Exibir um objeto
            //acessa o número na lista de objetos
            int numero_objeto;
            Console.WriteLine("Qual objeto deseja exibir?");
            numero_objeto = int.Parse(Console.ReadLine());
            foreach (Objeto numero_Objeto in listaObjetos)
            {
                Console.WriteLine(numero_Objeto.X);
                Console.WriteLine(numero_Objeto.Y);
                Console.ReadKey();
                break;
            }
            break;
        case "3":
            //Exibir a lista cadastrada
            break;
        case "4":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Você digitou uma opção que não existe");
            break;
    } //fim switch

    //Console.Write("Pressione algo para continuar!");
    //Console.ReadKey();

} while (opcao != "4"); //opção menu

