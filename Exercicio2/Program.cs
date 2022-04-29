    /*
     * Exercício 2: Escreva um programa em C# e no Visual Studio para calcular a média
     * aritmética entre quatro números quaisquer.
    */

    Console.WriteLine("\nExercício 2: Escreva um programa em C# e no Visual Studio\n" +
        " para calcular a média aritmética entre quatro números quaisquer.\n");

    float numero1;
    float numero2;
    float numero3;
    float numero4;
    float media_aritmetica;

    Console.Write("Digite o primeiro número: ");
    numero1 = float.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    numero2 = float.Parse(Console.ReadLine());

    Console.Write("Digite o terceiro número: ");
    numero3 = float.Parse(Console.ReadLine());

    Console.Write("Digite o quarto número: ");
    numero4 = float.Parse(Console.ReadLine());

    media_aritmetica = (numero1 + numero2 + numero3 + numero4) / 4;

    Console.WriteLine("A média aritmética dos quatros números é: " + media_aritmetica);


