Console.WriteLine("Exercício 5 - Escrever um algoritmo para ler duas notas de um aluno e " +
    "\n escrever na tela a palavra “Aprovado” se a média das duas notas for" +
    "\n maior ou igual a 7,0. Caso a média seja inferior a 7,0, o programa " +
    "\n deve ler a nota do exame e calcular a média final. Se esta média for " +
    "\n maior ou igual a 5,0, o programa deve escrever “Aprovado”, " +
    "\n caso contrário deve escrever “Reprovado”.");

//notas válidas de 0 a 10

/// <summary>
/// guarda a nota 1 de um aluno
/// </summary>
double nota1;

/// <summary>
/// guarda a nota 2 de um aluno
/// </summary>
double nota2;

/// <summary>
/// guarda a media das duas notas informadas
/// </summary>
double media;

/// <summary>
/// guarda a nota do exame de recuperação
/// </summary>
double nota_exame;

/// <summary>
/// guarda a média final, calculada através da média de notas e nota do exame de recuperação
/// </summary>
double media_final;

/// <summary>
/// guarda a quantidade de testes a ser realizado pelo usuário
/// </summary>
int n; // informar quantidade de teste

Console.WriteLine("Digite a quantidade de testes: ");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Digite as duas notas: ");
    nota1 = double.Parse(Console.ReadLine());
    nota1 = double.Parse(Console.ReadLine());

    media = (nota1 + nota1) / 2;

    if (media >= 7)
    {
        Console.WriteLine("Aprovado");
    }
    else
    {
        Console.WriteLine("Digite a nota do exame final: ");
        nota_exame = double.Parse(Console.ReadLine());

        media_final = (media + nota_exame) / 2;

        if (media_final >= 5)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}

