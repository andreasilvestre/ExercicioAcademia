//exemplo 1

int num;

Console.WriteLine("Digite um número qualquer: ");
num = int.Parse(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("Positivo");
}
else if (num < 0)
{
    Console.WriteLine("Negativo");
}
else
{
    Console.WriteLine("Zero");
}

//if (num > 0) Console.WriteLine("Positivo - Você pode escrever if assim se for apenas uma linha");
