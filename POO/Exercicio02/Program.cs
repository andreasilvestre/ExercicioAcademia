//#2
//Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
//O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

//Regras que deverão ser seguidas para a implementação do programa:

//Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
//Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
//É obrigatório criar uma classe para representar o Animal.
//A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
//A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o
//usuário armazene/leia os dados dos dois dados privados (propriedades).

using Exercicio02;
List<Animal> listaAnimais= new List<Animal>();
string nome;
string tipo;

for (int i = 0; i < 5; i++)
{
    Console.Clear();
    Console.WriteLine("Vamos analisar os animais de estimação?" + i);
    Console.Write("Digite o nome do animal: ");
    nome = Console.ReadLine().ToUpper();
    //Console.Write("Digite o tipo de animal: [Cachorro, Gato ou Peixe]: ");
    //tipo = Console.ReadLine().ToUpper();
    do
    {
        Console.Clear();
        Console.Write("Digite o tipo de animal: [Cachorro, Gato ou Peixe]: ");
        tipo = Console.ReadLine().ToUpper();
        if (!Animal.verificaTipo(tipo))
        {
            Console.WriteLine("Tipo de animal inválido --> Serão aceitos somente Cachorros, Gatos e Peixes.");
            Console.ReadKey();
        }
       
    } while (!Animal.verificaTipo(tipo));
    
    listaAnimais.Add(new Animal(nome, tipo));
    //Console.ReadKey();
}

Animal.Quantidade(listaAnimais);

Console.WriteLine("As quantidades são: ");
Console.WriteLine(Animal.retornaQuantidade(listaAnimais));