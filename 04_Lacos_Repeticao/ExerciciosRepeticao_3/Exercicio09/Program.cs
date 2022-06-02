Console.WriteLine("EXERCICIO09" +
"\n 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram" +
"\n o zoológico num determinado dia, imprimindo:" +
"\n Quantas pessoas tem entre 1 e 3 filhos." +
"\n Quantas pessoas tem entre 4 e 7 filhos." +
"\n Quantas pessoas tem mais de 8 filhos." +
"\n Quantas pessoas não tem filhos.\n");


//30 pessoas

/// <summary>
///  guarda a quantidade de filhos de uma pessoa informada pelo usuário
/// </summary>
int quantidade_filhos;

/// <summary>
///  guarda a quantidade de pessoas que tem de 1 a 3 filhos
/// </summary>
int filhos1a3 = 0;

/// <summary>
/// guarda a quantidade de pessoas que tem de 4 a 7 filhos
/// </summary>
int filhos4a7 = 0;

/// <summary>
/// guarda a quantidade de pessoas que tem 8 ou mais filhos
/// </summary>
int filhosMaisde8 = 0;

/// <summary>
/// guarda a quantidade de pessoas que não possui nenhum filho
/// </summary>
int semFilhos = 0;

for (int i = 1; i <= 30; i++)
{
    Console.WriteLine("Digite a quantidade de filhos da pessoa " + i);
    quantidade_filhos = int.Parse(Console.ReadLine());

    if ((quantidade_filhos >= 1 ) && (quantidade_filhos <= 3))
    {
        filhos1a3++;
    }
    else if ((quantidade_filhos >= 4) && (quantidade_filhos <= 7))
    {
        filhos4a7++;
    }
    else if (quantidade_filhos >= 8)
    {
        filhosMaisde8++;
    }
    else if (quantidade_filhos == 0)
    {
        semFilhos++;
    }
}

Console.WriteLine("O panorama sobre quantidade de filhos dos visitantes ficaram da seguinte forma: ");
Console.WriteLine("De 1 a 3 filhos: " + filhos1a3);
Console.WriteLine("De 4 a 7 filhos: " + filhos4a7);
Console.WriteLine("Mais de 8 filhos: " + filhosMaisde8);
Console.WriteLine("Sem filhos: " + semFilhos);

