/*
 * Exercício 1: Escreva um programa em C# e no Visual Studio para calcular 
 * a média aritmética entre dois números quaisquer.
 */

Console.WriteLine("Exercício 1: Escreva um programa em C# e no Visual Studio para\n" +
    " calcular a média aritmética entre dois números quaisquer.");

float numero1;
float numero2;
float media_aritmetica;

Console.Write("Digite um número qualquer: ");
numero1 = float.Parse(Console.ReadLine());

Console.Write("Digite outro número qualquer: ");
numero2 = float.Parse(Console.ReadLine());

media_aritmetica = (numero1 + numero2) / 2;

Console.WriteLine("A média aritmética entre dois números é: " + media_aritmetica);


