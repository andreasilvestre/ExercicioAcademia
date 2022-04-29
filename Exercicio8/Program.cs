    /*
    Exercício 8: Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
    A fórmula da conversão é F=(9*C+160)/5.
     */


    Console.WriteLine("Exercício 8: Ler uma temperatura em graus Celsius e apresentá-la convertida\n" +
        " em graus Fahrenheit. A fórmula da conversão é F = (9 * C + 160) / 5.\n");

    int tempC;
    int tempF;

    Console.Write("Digite a temperatura em graus Celsius: ");
    tempC = int.Parse(Console.ReadLine());

    tempF = (9 * tempC + 160) / 5;
    Console.WriteLine("A temperarura convertida em graus Fahrenheit é: " + tempF + "º");


