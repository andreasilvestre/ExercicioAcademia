    /*
    Exercício 13:  Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo.
    Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
    preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do
    salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
    vendidas pelo vendedor, calcule e mostre: o salário do empregado
     */

    Console.WriteLine("Exercício 13: Uma loja vende bicicletas com um acréscimo de 50% sobre\n" +
        " o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão\n" +
        " de 15% sobre o preço de custo de cada bicicleta vendida.Desenvolva um algoritmo que leia\n" +
        " o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas\n" +
        " vendidas pelo vendedor, calcule e mostre: o salário do empregado");

    double preco_custo, salario_minimo, comissao;
    int tot_bicicleta;
    //double preco_venda;

    Console.Write("Digite o valor do salário mínimo: ");
    salario_minimo = double.Parse(Console.ReadLine());

    Console.Write("Digite o preço de custo de cada bicicleta: ");
    preco_custo = double.Parse(Console.ReadLine());

    Console.Write("Digite o total de bicicletas vendidas: ");
    tot_bicicleta = int.Parse(Console.ReadLine());

    //preco_venda = preco_custo + (preco_custo / 2);
    comissao = (preco_custo * 0.15) * tot_bicicleta;

    Console.WriteLine("O salário do empregado é: " + (2 * salario_minimo + comissao));
