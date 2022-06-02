Console.WriteLine("Exercício 6 - Faça um programa em C# e no Visual Studio para receber o nome" +
    "\n (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa." +
    "\n O programa deve calcular o Indice de Massa Corpórea(IMC), exibi - lo ao usuário" +
    "\n e informar sua situação conforme a tabela." +
    "\n O cálculo do imc = peso / (altura * altura)" +
    "\n IMC " +
    "\n menor que 18                -> baixo peso" +
    "\n maior que 18 e menor que 25 -> peso normal" +
    "\n maior que 25 e menor que 30 -> sobrepeso" +
    "\n maior que 30 e menor que 35 -> obesidade" +
    "\n maior que 35                -> obesidade grau sério");

/// <summary>
/// receb o nome de uma pessoa
/// </summary>
string nome;

/// <summary>
/// guarda o nome de uma pessoa em maiusculo
/// </summary>
string nome_maiusculo;

/// <summary>
/// guarda  a altura de uma pessoa
/// </summary>
double altura;

/// <summary>
/// guarda o peso de uma pessoa
/// </summary>
double peso;

/// <summary>
/// guarda o índice de massa corporal IMC de uma pessoa
/// </summary>
double imc;

Console.WriteLine("Digite o nome de uma pessoa, a altura e o peso: ");
nome = Console.ReadLine();

nome_maiusculo = nome.ToUpper();

//fazer validações
if (nome != nome_maiusculo)
{
    Console.WriteLine("\n Digite o nome da pessoa em maiúsculo.");
}
else
{
    Console.WriteLine("Digite a altura e o peso");
    altura = double.Parse(Console.ReadLine());
    peso = double.Parse(Console.ReadLine());

    imc = peso / (altura * altura);

    if (imc < 18)
    {
        Console.WriteLine("Baixo peso, IMC = " + imc);
    }
    else if (imc > 18 && imc < 25)
    {
        Console.WriteLine("Peso normal,  IMC = " + imc);
    }
    else if (imc > 25 && imc < 30)
    {
        Console.WriteLine("Sobrepeso, IMC = " + imc);
    }
    else if (imc > 30 && imc < 35)
    {
        Console.WriteLine("Obesidade,  IMC = " + imc);
    }
    else if (imc > 35)
    {
        Console.WriteLine("Obesidade de grau sério, IMC = " + imc);
    }

}
