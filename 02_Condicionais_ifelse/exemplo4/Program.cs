// exemplo 4
int num;

Console.WriteLine("Digite um número qualquer: ");
num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Divisível por 2");
}
if (num % 4 == 0)
{
    Console.WriteLine("Divisível por 4");
}
if (num % 8 == 0)
{
    Console.WriteLine("Divisível por 8");
}