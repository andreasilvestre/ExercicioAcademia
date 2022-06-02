Console.WriteLine("EXERCICIO06" +
"\n 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados," +
"\n ou seja, repita a leitura até que ela esteja correta (maior do que zero)." +
"\n Ao final, mostre a idade digitada.");


/// <summary>
/// guarda a idade digitada pelo usuário
/// </summary>
int idade = 0;

Console.WriteLine("Digite uma idade: ");
idade = int.Parse(Console.ReadLine());

while (idade <= 0)
{
    Console.WriteLine("Idade incorreta.");
    Console.WriteLine("Digite uma idade válida, maior que zero.");
    idade = int.Parse(Console.ReadLine());
}

Console.WriteLine("A idade digitada é: " + idade + " anos");
