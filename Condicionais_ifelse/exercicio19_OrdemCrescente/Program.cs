Console.WriteLine("Exercício 19 - Ajuste o exercício 3 de maneira que mostre os valores" +
    "\n informados em ordem crescente.\n");

Console.WriteLine("Exercício 3 - Escrever um algoritmo para ler quatro valores inteiros," +
    "\n calcular a sua média, e escrever na tela os que são superiores à média.\n");

/// <summary>
/// guarda quatro números inteiros digitado pelo usuário
/// </summary>
int num1, num2, num3, num4;

/// <summary>
/// guarda o valor da media calculada
/// </summary>
double media;

//int[] vetor = new int[4]; ou
/// <summary>
/// guarda os valores digitados em uma vetor, como uma lista
/// </summary>
int[] vetor;
vetor = new int[4];

Console.WriteLine("Digite 4 números inteiros: ");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
num3 = int.Parse(Console.ReadLine());
num4 = int.Parse(Console.ReadLine());

media = (num1 + num2 + num3 + num4) / 4;
Console.WriteLine("A média é: " + media);
Console.WriteLine("Os valores superiores à media são: ");
if (num1 > media)
{
    Console.WriteLine(num1);
}
if (num2 > media)
{
    Console.WriteLine(num2);
}
if (num3 > media)
{
    Console.WriteLine(num3);
}
if (num4 > media)
{
    Console.WriteLine(num4);
}

vetor[0] = num1;
vetor[1] = num2;
vetor[2] = num3;
vetor[3] = num4;

Array.Sort(vetor);

Console.WriteLine("Os números informados em ordem crescente são: ");
Console.WriteLine(vetor[0]);
Console.WriteLine(vetor[1]);
Console.WriteLine(vetor[2]);
Console.WriteLine(vetor[3]);
