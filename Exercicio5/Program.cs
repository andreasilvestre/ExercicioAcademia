    /*
     Exercício 5: Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
    (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
    consumido para percorrê-la (medido em l).
     */


    Console.WriteLine("\nExercício 5: Escreva um programa em C# e no Visual Studio para calcular\n" +
        " o consumo médio de um automóvel (medido em Km / l), sendo que são conhecidos a distância\n" +
        " total percorrida e o volume de combustível consumido para percorrê - la (medido em l).\n");

    float distancia_percorrida;
    float combustivel_consumido;
    float consumo_medio;

    Console.Write("Digite a distância total percorrida: ");
    distancia_percorrida = float.Parse(Console.ReadLine());

    Console.Write("Digite o total de combustível consumido: ");
    combustivel_consumido = float.Parse(Console.ReadLine());

    consumo_medio = distancia_percorrida / combustivel_consumido;

    Console.WriteLine("O consumo médio de combustível foi: " + consumo_medio + " Km/L");



