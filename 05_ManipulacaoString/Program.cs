//Exercícios desafio de string
//Fazer um programa que receba  o nome completo de uma pessoa e
//exiba em maiúsculo o primeiro nome e o último sobrenome dessa pessoa.

//Fazer um programa que receba o nome completo de uma pessoa e o
//exiba abreviado

Console.WriteLine("Fazer um programa que receba  o nome completo de uma pessoa e " +
        "\n exiba em maiúsculo o primeiro nome e o último sobrenome dessa pessoa.");

/// <summary>
/// guarda o nome completo digitado pelo usuário
/// </summary>
string nome_completo;

/// <summary>
/// guarda em um vetor as posições de cada palavra, separada por espaço em branco.
/// exemplo: Andréa Maria da Silva Costa
/// palavras[0,1,2,3,4] 
/// palavras[4]=Costa
/// </summary>
string[] palavras;

/// <summary>
/// guarda o primeiro nome da pessoa
/// </summary>
string primeiro_nome;

/// <summary>
/// guarda o último sobrenome da pessoa
/// </summary>
string ultimo_sobrenome;

Console.WriteLine("Digite o nome completo de uma pessoa: ");
nome_completo = Console.ReadLine();
nome_completo = nome_completo.ToUpper();

//splitar o nome completo por espaço em branco
palavras = nome_completo.Split(' ');

primeiro_nome = palavras[0];
ultimo_sobrenome = palavras[palavras.Length - 1];

Console.WriteLine("Nome digitado: " + nome_completo);
Console.WriteLine("Primeiro nome: " + primeiro_nome);
Console.WriteLine("Último sobrenome: " + ultimo_sobrenome);

