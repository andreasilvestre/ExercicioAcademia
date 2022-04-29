    /*
     * Exercício 6: Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A 
     * e para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário de cada parafuso
     * e a porcentagem de IPI (única) a ser acrescentada. 
     */


    Console.WriteLine("\nExercício 6: Escreva um programa em C# e no Visual Studio que leia\n" +
        " os dados para o parafuso A e para o parafuso B, isto é, o código, a quantidade de\n" +
        " peças e o valor unitário de cada parafuso e a porcentagem de IPI(única) a ser acrescentada.\n");
    
    // *** Parafuso A ****
    //variáveis que irão receber dados informados pelo usuário
    int cd_parafusoA;
    int qt_pecasA;
    float vl_unitarioA;
    float porc_ipiA;
    
    //variáveis que irão armazenar dados calculados e exibir na tela - retornar cálculos
    float vl_compraA; //valor da compra do parafuso A sem IPI
    float vl_compraA_ipi; //valor da compra do parafuso A com IPI

    Console.WriteLine(" *** Receber dados do Parafuso A *** ");
    Console.Write("Digite o código: ");
    cd_parafusoA = int.Parse(Console.ReadLine());
    Console.Write("Digite o total de peças recebidas: ");
    qt_pecasA = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor unitário: ");
    vl_unitarioA = float.Parse(Console.ReadLine());
    Console.Write("Digite a porcentagem IPI a acrescentar: ");
    porc_ipiA = float.Parse(Console.ReadLine());

    vl_compraA = qt_pecasA * vl_unitarioA;
    vl_compraA_ipi = vl_compraA + ((porc_ipiA / 100) * vl_compraA);

    Console.WriteLine("\nO valor da compra do parafuso A, de código " + cd_parafusoA + " é:");
    Console.WriteLine("Sem IPI: " + vl_compraA);
    Console.WriteLine("Com IPI: " + vl_compraA_ipi);


    // *** Parafuso B ***

    //variáveis que irão receber dados informados pelo usuário
    int cd_parafusoB;
    int qt_pecasB;
    float vl_unitarioB;
    float porc_ipiB;

    //variáveis que irão armazenar dados calculados e exibir na tela - retornar cálculos
    float vl_compraB; //valor da compra do parafuso A sem IPI
    float vl_compraB_ipi; //valor da compra do parafuso A com IPI

    Console.WriteLine("\n *** Receber dados do Parafuso B *** ");
    Console.Write("Digite o código: ");
    cd_parafusoB = int.Parse(Console.ReadLine());
    Console.Write("Digite o total de peças recebidas: ");
    qt_pecasB = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor unitário: ");
    vl_unitarioB = float.Parse(Console.ReadLine());
    Console.Write("Digite a porcentagem IPI a acrescentar: ");
    porc_ipiB = float.Parse(Console.ReadLine());

    vl_compraB = qt_pecasB * vl_unitarioB;
    vl_compraB_ipi = vl_compraB + ((porc_ipiB / 100) * vl_compraB);

    Console.WriteLine("\nO valor da compra do parafuso B, de código " + cd_parafusoB + " é:");
    Console.WriteLine("Sem IPI: " + vl_compraB);
    Console.WriteLine("Com IPI: " + vl_compraB_ipi);

