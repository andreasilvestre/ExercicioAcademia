//#6
//Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
//tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
//um método para exibir um objeto (x, y).
//Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
//os objetos da lista.
using Exercicio06;
string maisObjeto = "S";
string opcao = "";
int x;
int y;

List<Objeto> listaObjetos = new List<Objeto>();
//Objeto objeto = new Objeto(0,0);

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
           
            while (maisObjeto == "S")
            {
                
                Console.Clear();
                Console.Write("Digite o valor x: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor y: ");
                y = int.Parse(Console.ReadLine());
                Objeto objeto = new Objeto(x, y);

                listaObjetos.Add(objeto);

                objeto.exibirUmObjeto();

                Console.WriteLine("Deseja acrescentar mais objetos? [S/N]");
                maisObjeto = Console.ReadLine().ToUpper();
            }
            //Console.WriteLine("\nExibindo a lista de objetos...");
            //Objeto objeto2 = new Objeto();
            //objeto2.exibirVariosObjetos(listaObjetos);

            Console.Write("Pressione algo para continuar!");
            Console.ReadKey();
            break;
        case "2":
            //Exibir um objeto quando criado apenas
            Console.WriteLine("Em construção...");
            break;
        case "3":
            //Exibir a lista cadastrada
            Console.WriteLine("\nExibindo a lista de objetos...");
            //Objeto objeto2 = new Objeto();
            //objeto2.exibirVariosObjetos(listaObjetos);

            Objeto.exibirVariosObjetos(listaObjetos);
            
            //ou assim:
            //foreach (Objeto i in listaObjetos)
            //{
            //    Console.WriteLine("Objeto: " + i.X + "x" + i.Y);
            //}

            Console.Write("Pressione algo para continuar!");
            Console.ReadKey();
            break;
        case "4":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Você digitou uma opção que não existe");
            break;
    } //fim switch

    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();

} while (opcao != "4"); //opção menu

