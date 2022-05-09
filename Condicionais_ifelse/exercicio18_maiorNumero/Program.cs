Console.WriteLine("Exercício 18 - Escreva um algoritmo que leia 3 valores pelo teclado" +
    "\n e então informe qual o maior deles.");

/// <summary>
/// guarda o primeiro número digitado
/// </summary>
double n1;

/// <summary>
/// guarda o segundo número digitado
/// </summary>
double n2;

/// <summary>
/// guarda o terceiro número digitado
/// </summary>
double n3;

/// <summary>
/// guarda o maior número digitado
/// </summary>
double maior;

Console.WriteLine("Digite tres números qualquer: ");
n1 = double.Parse(Console.ReadLine());
n2 = double.Parse(Console.ReadLine());
n3 = double.Parse(Console.ReadLine());

maior = 0;

//n1 maior
if (n1 > n2 && n1 > n3)
{
    maior = n1;
}

//n2 maior
if (n2 > n1 && n2 > n3)
{
    maior = n2;
}

//n3 maior
if (n3 > n1 && n3 > n2)
{
    maior = n3;
}

if (n1 == n2 && n2 == n3 && n3 == n1)
{
    maior = n1;// guarda qualquer valor pq é tudo igual
    Console.WriteLine("Os números digitados são iguais");
}
else
{
    Console.WriteLine("O número maior é " + maior);
}