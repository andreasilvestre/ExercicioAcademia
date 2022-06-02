Console.WriteLine("\n  Exercício 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto." +
"\n O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. " +
"\n plus: você pode gerar o número de forma randomica (função random c#).");

/// <summary>
/// gera um número aleatório de 1 a 50
/// </summary>
Random randNum = new Random();

/// <summary>
/// guarda o número de aposta do jogador
/// </summary>
int num_aposta;

/// <summary>
/// guarda o número secreto gerado
/// </summary>
int num_secreto;

num_secreto = randNum.Next(1, 50);

//se for necessário ver o número secreto
//Console.WriteLine("Nùmero secreto: " + num_secreto);

Console.WriteLine("Jogo de adivinhação - aposte em um número de 1 a 50.");

//primeira tentativa
Console.WriteLine("Diga, qual é seu número de aposta:");
num_aposta = int.Parse(Console.ReadLine());

if (num_secreto == num_aposta)
{
    Console.WriteLine("Acertou BINGOOOO!!!!");
}
else if (num_secreto < num_aposta)
{
    Console.WriteLine("DICA: O número secreto é MENOR que seu número apostado.");
}
else
{
    Console.WriteLine("DICA: O número secreto é MAIOR que seu número apostado.");
}


//segunda tentativa
if (num_aposta != num_secreto)
{
    Console.WriteLine("Tente mais uma vez: ");
    num_aposta = int.Parse(Console.ReadLine());

    if (num_secreto == num_aposta)
    {
        Console.WriteLine("Acertou BINGOOOO!!!!");
    }
    else if (num_secreto < num_aposta)
    {
        Console.WriteLine("DICA: O número secreto é MENOR que seu número apostado.");
    }
    else
    {
        Console.WriteLine("DICA: O número secreto é MAIOR que seu número apostado.");
    }
}

//terceira e ultima tentativa
if (num_aposta != num_secreto)
{
    Console.WriteLine("Tente pela última vez: ");
    num_aposta = int.Parse(Console.ReadLine());

    if (num_secreto == num_aposta)
    {
        Console.WriteLine("Acertou BINGOOOO!!!!");
    }
    else
    {
        Console.WriteLine("Perdeu");
    }
}

Console.WriteLine("FIM JOGO!");



