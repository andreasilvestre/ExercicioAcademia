Console.WriteLine("EXERCICIO04" + 
" \n 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA)." +
" \n Você foi contratado para fazer um programa em VS que conte os votos dos candidatos." +
" \n Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA." +
" \n Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário" +
" \n escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número" +
" \n de votos em branco.\n");
 
/// <summary>
/// guarda a quantidade de votos do candidato Joao
/// </summary>
int votosJoao = 0;

/// <summary>
/// guarda a quantidade de votos do candidato Zeca
/// </summary>
int votosZeca = 0;

/// <summary>
/// guarda a quantidade de votos branco
/// </summary>
int votosBranco = 0;

/// <summary>
/// guarda a escolha do eleitor, se foi Joao, Zeca ou branco e a palavra fim para encerrar votação
/// </summary>
string candidato = "INICIO"; //JOAO, ZECA OU BRANCO FIM

do
{
    Console.WriteLine("Digite seu voto: (JOAO, ZECA OU BRANCO) - para terminar votação digite FIM");
    candidato = Console.ReadLine();
    candidato = candidato.ToUpper();

    if (candidato == "JOAO")
    {
        votosJoao++;
    }
    else if (candidato == "ZECA")
    {
        votosZeca++;
    }
    else if (candidato == "BRANCO")
    {
        votosBranco++;
    }

} while (candidato != "FIM");

Console.WriteLine("A votação ficou da seguinte forma: ");
Console.WriteLine("JOAO: " + votosJoao);
Console.WriteLine("ZECA: " + votosZeca);
Console.WriteLine("BRANCOS: " + votosBranco);