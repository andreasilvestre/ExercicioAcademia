Console.WriteLine("Exercício 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.");

/// <summary>
/// guarda o valor de um número qualquer digitado pelo usuário
/// </summary>
double numero;

Console.WriteLine("Digite um número qualquer: ");
numero = double.Parse(Console.ReadLine());

if (numero % 2 == 0) Console.WriteLine("Número par.");
else Console.WriteLine("Número ímpar.");


