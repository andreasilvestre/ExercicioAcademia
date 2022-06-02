Console.WriteLine("\n" +
"\n Exercício 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura)." +
"\n O programa deve mostrar os dados do atleta mais novo e mais alto.");

/// <summary>
/// receb o nome do atleta 1
/// </summary>
string nome1;

/// <summary>
/// receb o nome do atleta 2
/// </summary>
string nome2;

/// <summary>
/// guarda a idade do atleta 1
/// </summary>
int idade1;

/// <summary>
/// guarda a idade do atleta2
/// </summary>
int idade2;

/// <summary>
/// guarda a altura do atleta 1
/// </summary>
double altura1;

/// <summary>
/// guarda a idade do atleta 2
/// </summary>
double altura2;

Console.WriteLine("Digite os dados do atleta 1 - nome, idade e altura: ");
nome1 = Console.ReadLine();
idade1 = int.Parse(Console.ReadLine());
altura1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite os dados do atleta 2 - nome, idade e altura: ");
nome2 = Console.ReadLine();
idade2 = int.Parse(Console.ReadLine());
altura2 = double.Parse(Console.ReadLine());

if (idade1 < idade2 && altura1 > altura2)  //mais novo e mais alto o mesmo atleta
{
    Console.WriteLine("O atleta " + nome1 + " de idade de " + idade1 + " anos e altura " + altura1 + " metros");
    Console.WriteLine("É o mais novo e mais alto");
}
else if (idade2 < idade1 && altura2 > altura1)  // mais novo e mais alto o mesmo atleta
{
    Console.WriteLine("O atleta " + nome2 + " de idade de " + idade2 + " anos e altura " + altura2 + " metros");
    Console.WriteLine("É o mais novo e mais alto");
}
else
{
    Console.WriteLine("Não existe um mesmo atleta mais novo e mais alto");
}
