Console.WriteLine("EXERCICIO10" +
"\n 10. Ler nome, sexo e idade de 50 pessoas e após imprimir: " +
"\n Número de pessoas do sexo masculino." +
"\n Número de pessoas do sexo feminino." +
"\n Número de pessoas com idade inferior a 30 anos." +
"\n Número de pessoas com idade superior a 60 anos." +
"\n Média de idade das mulheres.\n");

//total 50 pessoas
/// <summary>
/// guarda o nome da pessoa
/// </summary>
string nome;

/// <summary>
/// guarda o sexo da pessoa, masculino ou feminino
/// </summary>
string sexo;//feminino ou masculino

/// <summary>
/// guarda a idade da pessoa
/// </summary>
int idade;

/// <summary>
/// guarda o total de pessoas do sexo masculino
/// </summary>
int totalMasculino = 0;

/// <summary>
/// guarda o total de pessoas do sexo feminino
/// </summary>
int totalFeminino = 0;

/// <summary>
/// guarda o total de pessoas com idade inferior a 30 anos
/// </summary>
int inferior30Anos = 0;

/// <summary>
/// guarda o total de pessoas com idade superior a 60 anos
/// </summary>
int superior60Anos = 0;

/// <summary>
/// guarda a somatória das idades das mulheres para calcular a média
/// </summary>
int somaIdadeMulheres = 0; //para achar média

/// <summary>
/// guarda a média das idades das mulheres => media = soma das idades mulheres / total de idades mulheres
/// </summary>
double mediaIdadeMulheres = 0; // divide por totalFeminino

//pendencia= trocar for para 50 pessoas - teste com 5
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o nome da pessoa: ");
    nome = Console.ReadLine();
    nome = nome.ToUpper();

    Console.WriteLine("Digite o sexo - (feminino/masculino)");
    sexo = Console.ReadLine();
    sexo = sexo.ToUpper();

    Console.WriteLine("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());

    if (sexo == "MASCULINO")
    {
        totalMasculino++;
    }
    else if (sexo == "FEMININO")
    {
        totalFeminino++;
        somaIdadeMulheres = somaIdadeMulheres + idade;
    }

    if (idade < 30)
    {
        inferior30Anos++;
    }
    else if (idade > 60)
    {
        superior60Anos++;
    }
}
mediaIdadeMulheres = somaIdadeMulheres / totalFeminino;

Console.WriteLine("Pessoas do sexo masculino: " + totalMasculino);
Console.WriteLine("Pessoas do sexo feminino: " + totalFeminino);
Console.WriteLine("Pessoas com idade inferior a 30 anos: " + inferior30Anos);
Console.WriteLine("Pessoas com idade superior a 60 anos: " + superior60Anos);
Console.WriteLine("Média de idade das mulheres.: " + (int)mediaIdadeMulheres);