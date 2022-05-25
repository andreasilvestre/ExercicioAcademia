//#5 Exercicio05
//Crie uma classe para representar um item de cenário, com os atributos privados de:
//    *descrição(string), 
//    *data de criação(date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
//    *altura(float).

//Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
//todos dados de um item de cenário. 
//Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
//a classe criada.

using Exercicio05;

Cenario item = new Cenario();

Console.WriteLine("Digite os dados de um cenário: ");

Console.Write("Descrição: ");
item.Descricao = Console.ReadLine();


Console.Write("Data de Criação: ");
item.Data_criacao = DateTime.Parse(Console.ReadLine());
//item.Data_criacao = DateTime.Now;

Console.Write("Altura: ");
item.Altura = float.Parse(Console.ReadLine());

item.exibirDados();

//item.calcularTempo();
Console.WriteLine("Tempo de criação: " + item.calcularTempo());
