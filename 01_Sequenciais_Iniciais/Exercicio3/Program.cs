    /* Exercício 3: Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
    si os valores de duas variáveis A e B.
     */


    Console.WriteLine("Exercício 3: Escreva a seqüência de atribuições, em forma de programa\n" +
        " em C# e no Visual Studio, para trocar entre si os valores de duas variáveis A e B.");

    string variavel1;
    string variavel2;
    string temporaria;

    Console.Write("Digite um texto qualquer: ");
    variavel1 = Console.ReadLine();

    Console.Write("Digite outro texto: ");
    variavel2 = Console.ReadLine();

    Console.WriteLine("Os textos digitados foram: ");
    Console.WriteLine(variavel1 + " / " + variavel2);

    temporaria = variavel1;
    variavel1 = variavel2;
    variavel2 = temporaria;

    Console.WriteLine("Os textos foram trocados de posição como mostra abaixo: ");
    Console.WriteLine(variavel1 + " / " + variavel2);

