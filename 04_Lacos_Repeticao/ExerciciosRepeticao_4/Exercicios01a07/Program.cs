
//EXERCICIOS DE 13/05/2022
//EXERCICIOS DA LISTA 4 DE REPETIÇÃO - DE 1 A 7

int exercicio;

Console.WriteLine("Escolha o exercício de 1 a 7");
Console.WriteLine("Exercício 1");
Console.WriteLine("Exercício 2");
Console.WriteLine("Exercício 3");
Console.WriteLine("Exercício 4");
Console.WriteLine("Exercício 5");
Console.WriteLine("Exercício 6");
Console.WriteLine("Exercício 7");
exercicio = int.Parse(Console.ReadLine());

switch (exercicio)
{
    case 1:
        Console.WriteLine("EXERCICIO01" +
        "\n 1. Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte" +
        "\n soma: S = 1 + 1/2 + 1/3 + 1/4 + 1/5 .... 1/n \n");

        int n;
        double soma;

        Console.WriteLine("Digite um número inteiro e positivo: ");
        n = int.Parse(Console.ReadLine());

        soma = 1;
        for (double i = 2; i <= n; i++)
        {
            soma = soma + (1 / i); //1/2,1/3,1/4

            Console.WriteLine("Soma i: " + i + ":  " + soma.ToString("F"));
        }
        Console.WriteLine("Resultado da soma é: " + soma.ToString("F"));
        break;
    case 2:
        Console.WriteLine("EXERCICIO2" +
        "\n 2.	Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20. Considere que" +
        "\n Polegada = Centímetro * 2,54." +
        "\n polegada = de 1 a 20" +
        "\n centimetro = polegada / 2,54 \n");

        List<double> listaCentimetro = new List<double>();
        double valor_centimetro;

        for (double i = 1; i <= 20; i++)
        {
            valor_centimetro = i / 2.54;
            listaCentimetro.Add(valor_centimetro);
        }

        Console.WriteLine("Tabela de conversão de polegadas para centímetros: ");

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine((i + 1) + " ==> " + listaCentimetro[i].ToString("F"));
        }
        break;
    case 3:
        Console.WriteLine("EXERCICIO03" +
        "\n 3.	Dado um limite inferior e superior, calcule a soma de todos os números pares contidos" +
        "\n nesse intervalo. \n");

        double inferior;
        double superior;
        double somaPares = 0;

        Console.WriteLine("Digite um intevalo de números a calcular: ");
        inferior = double.Parse(Console.ReadLine());
        superior = double.Parse(Console.ReadLine());

        for (double i = inferior; i <= superior; i++)
        {
            if (i % 2 == 0)
            {
                somaPares = somaPares + i;
            }
        }
        Console.WriteLine("A soma dos pares é: " + somaPares);
        break;
    case 4:
        //pendencia, revisar testar
        Console.WriteLine("EXERCICIO04" + 
        "\n 4. Faça um algoritmo que leia uma lista de números inteiros positivos terminada pelo número 0 (zero)." +
        "\n Ao final o algoritmo deve mostrar a média aritmética de todos os números lidos (excluindo o zero).");

        string num_int;

        int num_semZero;
        double media = 0;
        int tamanho_lista;

        Console.WriteLine("Qual é o tammanho  da sua lista: ");
        tamanho_lista = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < tamanho_lista; i++)
        {
            Console.Write("Digite um número inteiro e positivo: ");
            num_int = Console.ReadLine();

            num_int = num_int.Substring(0, num_int.Length - 1);
            num_semZero = int.Parse(num_int);
            //Console.WriteLine(num_semZero);

            media = media + Convert.ToDouble(num_semZero);
        }

        media = media / tamanho_lista;
        Console.WriteLine("Média: " + media.ToString("F"));
        break;
    case 5:
        Console.WriteLine("EXERCICIO05" +
        "\n 5.	Escreva um programa em C# que gera números entre 1000 e 1999 e mostra aqueles que divididos" +
        "\n por 11 dão resto 5.");

        for (int i = 1000; i <= 1999; i++)
        {
            if ((i % 11 == 5))
            {
                Console.WriteLine(i);
            }
        }
        break;
    case 6:
        Console.WriteLine("EXERCICIO06" +
        "\n 6.	Faça um programa que leia um número n e imprima se ele é primo ou não." +
        "\n (um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)");

        //numero primo - de novo para ficar craque
        int contador = 0;
        double numero;

        Console.WriteLine("Digite um número qualquer: ");
        numero = double.Parse(Console.ReadLine());

        for (double i = numero; i <= numero; i--)
        {
            if (numero % i == 0)
            {
                contador++;
            }
            if (i == 1)
            {
                break;
            }
        }

        if (contador == 2)
        {
            Console.WriteLine("Número primo");
        }
        else
        {
            Console.WriteLine("Não é primo");
        }
        break;
    case 7:
        Console.WriteLine("EXERCICIO07" +
        "\n 7.	Os dois primeiros números da sequência de Fibonacci são 0 e 1. Os próximos números dessa " +
        "\n sequência podem ser calculados como sendo a soma dos dois números anteriores. Os primeiros" +
        "\n números de Fibonacci são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … Escreva um algoritmo " +
        "\n que leia um número pelo teclado N, e então mostre os N primeiros números da sequência de Fibonacci.");

        //escrever a sequencia até o número informado

        int numero1;
        List<int> sequenciaFibonacci = new List<int>();

        /// <summary>
        /// guarda a soma dos dois números  anteriores da lista
        /// </summary>
        int proximoNumero;

        Console.WriteLine("Digite um número qualquer: ");
        numero1 = int.Parse(Console.ReadLine());

        sequenciaFibonacci.Add(0);// posição 0
        sequenciaFibonacci.Add(1);// posição 1
        for (int i = 2; i <= numero1; i++)
        {
            //Fn = Fn - 1 + Fn - 2
            proximoNumero = sequenciaFibonacci[i - 1] + sequenciaFibonacci[i - 2];
            sequenciaFibonacci.Add(proximoNumero);
        }

        for (int i = 0; i < sequenciaFibonacci.Count; i++)
        {
            Console.WriteLine(sequenciaFibonacci[i]);
        }
        break;
    default:
        break;
}

