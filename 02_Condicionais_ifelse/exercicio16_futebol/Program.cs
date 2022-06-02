Console.WriteLine("\n " +
"\n Exercício 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil." +
"\n Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre" +
"\n na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase." +
"\n Caso contrário, mostre uma mensagem indicando que os dois times irão se" +
"\n enfrentar novamente em um novo jogo." +
"\n ex: time da casa 4 x 3 time de fora, mostra \"Os dois times se enfrentarão em um novo jogo\"" +
"\n ex2: time da casa 1 x 3 time de fora, mostra \"O time de fora já se classificou\"" +
"\n plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.");

/// <summary>
/// guarda os gols do time A
/// </summary>
int time_a;

/// <summary>
/// guarda os gols do time B
/// </summary>
int time_b;

/// <summary>
/// guarda a diferença de gols do time B em cima do time A
/// </summary>
int diferenca;

/// <summary>
/// guarda o saldo de gols to time A
/// </summary>
int saldo_a;

/// <summary>
/// guarda o saldo de gols do time B
/// </summary>
int saldo_b;

// time casa é A e time fora é B
Console.WriteLine("Digite o placar do jogo: ");
time_a = int.Parse(Console.ReadLine());
time_b = int.Parse(Console.ReadLine());

// 5x3 => 5-3=2
//para verificar se existe a diferença de 2 gols
diferenca = time_b - time_a;

//verifica saldo de gols
saldo_b = time_b - time_a;
saldo_a = time_a - time_b;

if (diferenca >= 2)
{
    Console.WriteLine("O time B classificado para a próxima fase");
}
else
{
    Console.WriteLine("Os dois times se enfrentarão em um novo jogo");

    //plus
    Console.WriteLine("Digite o placar da segunda fase: ");
    time_a = int.Parse(Console.ReadLine());
    time_b = int.Parse(Console.ReadLine());
    if (time_a > time_b)
    {
        Console.WriteLine("O time A passou de fase ==> FOI PARA A 3ª FASE");
    }
    else if (time_a < time_b)
    {
        Console.WriteLine("O time B passou de fase ==> FOI PARA A 3ª FASE");
    }
    else //deu empate na segunda fase
    {
        //antes dos penaltis, verifica saldo de gols
        if (saldo_a > saldo_b)
        {
            Console.WriteLine("O time A passou de fase pela regra de saldo de gols" +
             "\n FOI PARA A 3ª FASE");
        }
        else if (saldo_b > saldo_a)
        {
            Console.WriteLine("O time B passou de fase pela regra de saldo de gols" +
             "\n FOI PARA A 3ª FASE");
        }
        else
        {
            Console.WriteLine("EMPATE! O jogo irá para os pênaltis:"); // não há empate em penaltis

            //VERIFICANDO EMPATE
            Console.WriteLine("Digite o resultado dos pênaltis: ");
            time_a = int.Parse(Console.ReadLine());
            time_b = int.Parse(Console.ReadLine());
            if (time_a > time_b)
            {
                Console.WriteLine("O time A passou de fase ==> FOI PARA A 3ª FASE");
            }
            else if (time_a < time_b)
            {
                Console.WriteLine("O time B passou de fase ==> FOI PARA A 3ª FASE");
            }
            else
            {
                Console.WriteLine("ERRO - NÃO EXISTE EMPATE EM PÊNALTIS");

            }
        }
    }
}