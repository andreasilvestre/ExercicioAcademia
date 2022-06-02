Console.WriteLine(" 13 - Tendo como dado de entrada a altura (h) de uma pessoa," +
"\n construa um programa no VS que calcule seu peso ideal, utilizando as seguintes fórmulas:" +
"\n Para homens: (72.7 * h) - 58" + // subtrai 58
"\n Para mulheres: (62.1 * h) - 44.7"); // subtrai 44,70

/// <summary>
/// recebe a altura de uma pessoa qualquer
/// </summary>
double altura;

/// <summary>
/// recebe o sexo da pessoa se é feminino ou masculino
/// </summary>
string sexo;

/// <summary>
/// guarda o peso ideal das mulheres e dos homens
/// </summary>
double peso_ideal;

Console.WriteLine("Digite a altura e o sexo ( feminino ou masculino ) de uma pessoa: ");
altura = double.Parse(Console.ReadLine());
sexo = Console.ReadLine();

if (sexo.Contains("feminino") == true)
{
    peso_ideal = (62.1 * altura) - 44.7;
    Console.WriteLine("O peso ideal é: " + peso_ideal.ToString("F") + " Kg");
}
else if (sexo.Contains("masculino") == true)
{
    peso_ideal = (72.7 * altura) - 58;
    Console.WriteLine("O peso ideal é: " + peso_ideal.ToString("F") + " Kg");
}
else
{
    Console.WriteLine("Sexo inválido.");
}