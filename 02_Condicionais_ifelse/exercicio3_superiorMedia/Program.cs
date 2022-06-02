Console.WriteLine("Exercício 3 - Escrever um algoritmo para ler quatro valores inteiros," +
    "\n calcular a sua média, e escrever na tela os que são superiores à média.");

/// <summary>
/// guarda quatro números inteiros digitado pelo usuário
/// </summary>
double num1, num2, num3, num4;

/// <summary>
/// guarda o valor da media calculada
/// </summary>
double media;

Console.WriteLine("Digite 4 números inteiros: ");
num1 = double.Parse(Console.ReadLine());
num2 = double.Parse(Console.ReadLine());
num3 = double.Parse(Console.ReadLine());
num4 = double.Parse(Console.ReadLine());

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

