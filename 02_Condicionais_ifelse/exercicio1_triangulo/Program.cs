Console.WriteLine("Exercício 1 - Faça um algoritmo para calcular e mostrar a área de um " +
    "\n triângulo a partir dos valores da base e da altura lidos pelo teclado: " +
    "\n Área do triangulo = (base * altura) / 2; " +
    "\n Teste se a base ou a altura digitada não foi igual a zero. ");

/// <summary>
/// guarda o valor da base de um triangulo
/// </summary>
double base_tri;

/// <summary>
/// guarda a altura de um triangulo
/// </summary>
double altura;

/// <summary>
/// guarda o calculo da área de um triangulo
/// </summary>
double area;

Console.WriteLine("Digite a base e a altura: ");
base_tri = double.Parse(Console.ReadLine());
altura = double.Parse(Console.ReadLine());

if (base_tri == 0 || altura == 0)
{
    Console.WriteLine("Digite valores diferente de zero.");
}
else
{
    area = (base_tri * altura) / 2;
    Console.WriteLine("A área do triângulo é: " + area);
}

