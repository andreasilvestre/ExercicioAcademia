Console.WriteLine("Exercício 7 - Faça um programa em C# e no VS para receber uma frase qualquer" +
    "\n e uma palavra de pesquisa. O programa deve avaliar se a palavra aparece na frase," +
    "\n informando o usuário via mensagem, como por exemplo, A palavra" +
    "\n encontra-se na frase ou A palavra não se encontra na frase.");

/// <summary>
/// guarda uma frase digitada pelo usuário
/// </summary>
string frase;

/// <summary>
/// guarda a palavra que o usuário quer pesquisar na frase
/// </summary>
string palavra_pesquisa;

//bool retorno_pesquisa;

Console.WriteLine("Digite uma frase qualquer: ");
frase = Console.ReadLine();
frase = frase.ToUpper();

Console.WriteLine("Digite uma palavra a ser pesquisada");
palavra_pesquisa = Console.ReadLine();
palavra_pesquisa = palavra_pesquisa.ToUpper();


if (frase.Contains(palavra_pesquisa) == false)
{
    Console.WriteLine("A palavra não se encontra na frase.");
}
else
{
    Console.WriteLine("A palabra encontra-se na frase.");
}