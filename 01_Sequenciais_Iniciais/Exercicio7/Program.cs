    /*
     Exercício 7: Escreva um programa em C# e no Visual Studio que leia o número de um vendedor,
     o seu salário fixo, o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
     Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.
    */


    Console.WriteLine("Exercício 7: Escreva um programa em C# e no Visual Studio que leia o número\n" +
        " de um vendedor, o seu salário fixo, o total de vendas por ele efetuadas e o percentual\n" +
        " que ganha sobre o total de vendas. Calcule o salário total do vendedor.\n" +
        "Escreva o número do vendedor e o salário total do vendedor.");

    int num_vendedor;
    float salario_fixo;
    float tot_vendas;
    float porc_comissao;

    float vl_comissao;
    float salario_total;

    Console.Write("Digite o número do Vendedor: ");
    num_vendedor = int.Parse(Console.ReadLine());

    Console.Write("Digite seu salário fixo: ");
    salario_fixo = float.Parse(Console.ReadLine());

    Console.Write("Digite o total de vendas efetuadas: ");
    tot_vendas = float.Parse(Console.ReadLine());

    Console.Write("Digite seu percentual de comissão: ");
    porc_comissao = float.Parse(Console.ReadLine());

    vl_comissao = tot_vendas * (porc_comissao / 100);
    salario_total = salario_fixo + vl_comissao;

    Console.WriteLine("\nO vendedor de número " + num_vendedor + " receberá os seguintes valores:");
    Console.WriteLine("Comissão: " + vl_comissao);
    Console.WriteLine("Salário total: " + salario_total);