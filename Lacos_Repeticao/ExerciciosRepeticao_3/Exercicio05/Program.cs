Console.WriteLine("EXERCICIO05" +
"\n 5. Modifique o programa em VS anterior para aceitar votos nulos" +
"\n (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO)." +
"\n Ao final, informe o nome do candidato vencedor, o número de votos nulos e o número de pessoas que votaram.\n");
 
/// <summary>
/// guarda o total de votos de Joao
/// </summary>
int votosJoao = 0;

/// <summary>
/// guarda o total de votos de Zeca
/// </summary>
int votosZeca = 0;

/// <summary>
/// guarda o total de votos em branco
/// </summary>
int votosBranco = 0;

/// <summary>
/// guarda o total de votos nulo
/// </summary>
int votosNulos = 0;

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
    else if (candidato != "FIM")
    {
        votosNulos++;
    }

} while (candidato != "FIM");

Console.WriteLine("A votação ficou da seguinte forma: ");
Console.WriteLine("Total de eleitores que compareceram: " + (votosJoao + votosZeca + votosBranco + votosNulos));
Console.WriteLine("JOAO: " + votosJoao);
Console.WriteLine("ZECA: " + votosZeca);
Console.WriteLine("BRANCOS: " + votosBranco);
Console.WriteLine("NULOS: " + votosNulos);

if (votosJoao > votosZeca)
{
    Console.WriteLine("O vencedor é João, com " + votosJoao + " votos");
}
else if (votosJoao < votosZeca)
{
    Console.WriteLine("O vencedor é Zeca, com " + votosZeca + " votos");
}
else
{
    Console.WriteLine("Empatou");
}
