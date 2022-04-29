    /* 
     * Exercício 4: Faça um programa em C# e no Visual Studio que receba a data na forma DD/MM/AAAA e 
     * imprima na forma AAAA/MM/DD e AA/MM/DD. Note que o dia, o mês e o ano devem ser lidos
     * em variáveis diferentes.
     */


    Console.WriteLine("Exercício 4: Faça um programa em C# e no Visual Studio que receba\n" +
        " a data na forma DD/MM/AAAA e imprima na forma AAAA/MM/DD e AA/MM/DD.Note que o dia, o mês\n" +
        " e o ano devem ser lidos em variáveis diferentes.");
    
    // Solução pelo tipo Inteiro.

    //int dia;
    //int mes;
    //int ano;

    //Console.Write("Digite o dia: ");
    //dia = int.Parse(Console.ReadLine());

    //Console.Write("Digite o mês: ");
    //mes = int.Parse(Console.ReadLine());

    //Console.Write("Digite o ano: ");
    //ano = int.Parse(Console.ReadLine());

    //Console.WriteLine("A data no fornmato AAAA/MM/DD é: " + ano + "/" + mes + "/" + dia);
    //Console.WriteLine("A data no fornmato AA/MM/DD é: " + (ano % 100) + "/" + mes + "/" + dia);


    //Solução pelo tipo String.
    string dia;
    string mes;
    string ano;

    Console.Write("Digite o dia: ");
    dia = Console.ReadLine();

    Console.Write("Digite o mês: ");
    mes = Console.ReadLine();

    Console.Write("Digite o ano: ");
    ano = Console.ReadLine();

    Console.WriteLine("A data no fornmato AAAA/MM/DD é: " + ano + "/" + mes + "/" + dia);
    Console.WriteLine("A data no fornmato AA/MM/DD é: " + ano[2] + ano[3] + "/" + mes + "/" + dia);