
//exemplo 9
int num1, num2;
Console.WriteLine("Digite dois números: ");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("Os números são iguais.");
}
else if (num1 != num2) // não precisa perguntar, só testando not igual !=
{
    Console.WriteLine("Os números são diferentes.");
}


////teste - pode fazer if assim para um único comando(linha)
//if (num % 2 == 0) Console.WriteLine("Teste - Divisível por 2");
//if (num % 4 == 0) Console.WriteLine("Teste - Divisível por 4");
//if (num % 8 == 0) Console.WriteLine("Teste - Divisível por 8");
