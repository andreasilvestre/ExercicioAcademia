    /*
    Exercício 9: Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
    do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 
    Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
    se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
    Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
    da entrada e das duas prestações, de acordo com as regras acima. 
    Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
    conseqüente pagamento dos boletos das duas prestações.
     */

    Console.WriteLine("Exercício 9: Uma loja vende seus produtos no sistema de entrada mais\n" +
        " duas prestações, sendo a entrada maior do que ou igual às duas prestações, que devem\n" +
        " ser iguais, inteiras e as maiores possíveis. Por exemplo, se o valor da mercadoria\n" +
        " for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; se o valor da\n" +
        " mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais\n" +
        " a R$ 100,00. Escreva um programa em C# e no Visual Studio que receba o valor da\n" +
        " mercadoria e forneça o valor da entrada e das duas prestações, de acordo com as regras acima.\n" +
        " Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o\n" +
        " conseqüente pagamento dos boletos das duas prestações.");

    float valor_produto;
    float parcela;
    float resto_parcela;

    float entrada; // deve ser >= parcela 1 e >= parcela 2

    Console.Write("Digite o valor do produto: ");
    valor_produto = float.Parse(Console.ReadLine());

    Console.WriteLine("O pagamento ficará da seguinte forma: ");
    resto_parcela = valor_produto % 3;

    if (resto_parcela == 0)
    {
        parcela = valor_produto / 3;
        entrada = parcela;
    }
    else
    {
        valor_produto = valor_produto - resto_parcela;
        parcela = valor_produto / 3; //parcela de valor inteiro
        entrada = parcela + resto_parcela;
    }

    Console.WriteLine("Entrada: " + entrada);
    Console.WriteLine("Duas prestações de " + parcela + " cada");


