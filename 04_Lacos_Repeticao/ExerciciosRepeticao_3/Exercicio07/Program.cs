//Console.WriteLine("EXERCICIO07 - MINHA SOLUÇÃO, ABAIXO SOLUÇÃO DO LEONARDO" +
//"\n 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. " +
//"\n A cada solicitação, teste se o usuário informou um valor válido. " +
//"\n Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), " +
//"\n informe que ele está incorreto e saia do programa em VS. " +
//"\n Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), " +
//"\n informe que está errada e saia. Se estiver correta, solicite o salário. " +
//"\n Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. " +
//"\n Se estiver correto, mostre todos os valores lidos.\n");



///// <summary>
///// guarda o nome da pessoa que foi digitado
///// </summary>
//string nome;  //se for branco ou numero, informar q esta incorreto e abortar programa

///// <summary>
///// verifica se há algum numero digitado no nome
///// </summary>
//bool contem_numero = false;

///// <summary>
///// guarda a idade informada pelo usuário
///// </summary>
//int idade;

///// <summary>
///// guardao valor do salário informado pelo usuário
///// </summary>
//double salario;

//Console.WriteLine("Programa de leitura do nome, idade e saláio de uma pessoa");
//Console.WriteLine("Digite o nome da pessoa: ");
//nome = Console.ReadLine();
//nome = nome.ToUpper();

//if (nome == "" || nome.Contains("0") || nome.Contains("1") || nome.Contains("2") || nome.Contains("3") || nome.Contains("4") || nome.Contains("5") || nome.Contains("6") || nome.Contains("7") || nome.Contains("8") || nome.Contains("9"))
//{
//    contem_numero = true;
//    Console.WriteLine("Nome inválido.");
//}
//else
//{
//    Console.WriteLine("Digite a idade: ");
//    idade = int.Parse(Console.ReadLine());
//    if (idade <= 0)
//    {
//        Console.WriteLine("Idade inválida.");
//    }
//    else
//    {
//        Console.WriteLine("Digite a salário: ");
//        salario = double.Parse(Console.ReadLine());
//        if (salario <= 0)
//        {
//            Console.WriteLine("Salário inválido");
//        }
//        else
//        {
//            Console.WriteLine("Os dados lidos são: ");
//            Console.WriteLine("Nome: " + nome);
//            Console.WriteLine("Idade: " + idade + " anos");
//            Console.WriteLine("Salário: " + salario.ToString("C"));
//        }
//    }
//}



Console.WriteLine("EXERCICIO07 - SOLUÇÃO DO LEONARDO" +
"\n 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. " +
"\n A cada solicitação, teste se o usuário informou um valor válido. " +
"\n Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), " +
"\n informe que ele está incorreto e saia do programa em VS. " +
"\n Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), " +
"\n informe que está errada e saia. Se estiver correta, solicite o salário. " +
"\n Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. " +
"\n Se estiver correto, mostre todos os valores lidos.\n");



/// <summary>
/// guarda o nome da pessoa que foi digitado
/// </summary>
string nome;  //se for branco ou numero, informar q esta incorreto e abortar programa

/// <summary>
/// verifica se há algum numero digitado no nome
/// </summary>
bool contem_numero = false;

/// <summary>
/// guarda a idade informada pelo usuário
/// </summary>
int idade;

/// <summary>
/// guardao valor do salário informado pelo usuário
/// </summary>
double salario;

int contador = 0;

Console.WriteLine("Programa de leitura do nome, idade e saláio de uma pessoa");
Console.WriteLine("Digite o nome da pessoa: ");
nome = Console.ReadLine();
nome = nome.ToUpper();

//if (nome == "" || nome.Contains("0") || nome.Contains("1") || nome.Contains("2") || nome.Contains("3") || nome.Contains("4") || nome.Contains("5") || nome.Contains("6") || nome.Contains("7") || nome.Contains("8") || nome.Contains("9"))

foreach (char letra in nome)
{
    if ((letra >= '0') && (letra <= '9'))
    {
        contador++;
    }
    Console.WriteLine(letra);
}

if ( contador > 0 )
{
    Console.WriteLine("Nome inválido.");
}
else
{
    Console.WriteLine("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());
    if (idade <= 0)
    {
        Console.WriteLine("Idade inválida.");
    }
    else
    {
        Console.WriteLine("Digite a salário: ");
        salario = double.Parse(Console.ReadLine());
        if (salario <= 0)
        {
            Console.WriteLine("Salário inválido");
        }
        else
        {
            Console.WriteLine("Os dados lidos são: ");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade + " anos");
            Console.WriteLine("Salário: " + salario.ToString("C"));
        }
    }
}
