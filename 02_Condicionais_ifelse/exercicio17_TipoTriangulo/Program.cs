Console.WriteLine("\n " +
"\n Exercício 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e" +
"\n então diga se esses lados podem ou não formar um triangulo. Para que os lados" +
"\n formem um triângulo, todos os lados devem ser menores ou iguais a soma dos" +
"\n outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos" +
"\n os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).");


/// <summary>
/// guarda os tamanhos de cada lado do triângulo
/// </summary>
double a, b, c;

/// <summary>
/// guarda a soma de a e c
/// </summary>
double soma_ac; // para b

/// <summary>
/// guarda a soma de b e c
/// </summary>
double soma_bc; //para a

/// <summary>
/// guarda a soma de a e b
/// </summary>
double soma_ab; //para c

Console.WriteLine("Digite os lados de um triangulo (lado a, b e c): ");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());

soma_ab = a + b;
soma_ac = a + c;
soma_bc = b + c;

if ((a <= soma_bc) && (b <= soma_ac) && (c <= soma_ab))
{
    Console.WriteLine("Estes lados formam um triangulo do tipo: ");
    if ((a == b) && (a == c)) // se a=b e c, logo b=c - não precisa colocar
    {
        Console.WriteLine("Equilátero - os tres lados iguais"); // tres lados iguais
    }
    else if ((a == b) || (a == c) || (b == c))
    {
        Console.WriteLine("Isoceles - há dois lados iguais"); // dois lados iguais
    }
    else
    {
        Console.WriteLine("Escaleno - os tres lados são diferentes"); // tres lados diferentes    
    }
}
else
{
    Console.WriteLine("Os lados não formam um triangulo");
}
