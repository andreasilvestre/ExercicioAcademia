int exercicio;

Console.WriteLine("Escolha o exercício pelo número: [ de 13 a 20 ]");
Console.WriteLine("Exercício 13");
Console.WriteLine("Exercício 14");
Console.WriteLine("Exercício 15");
Console.WriteLine("Exercício 16");
Console.WriteLine("Exercício 17");
Console.WriteLine("Exercício 18");
Console.WriteLine("Exercício 19");
Console.WriteLine("Exercício 20");
exercicio = int.Parse(Console.ReadLine());

switch (exercicio)
{
    case 13:
        Console.WriteLine("EXERCICIO13" +
        "\n 13: Elaborar um programa que apresente o somatório dos valores pares existentes entre 1 e 500.");

        int somaPares = 0; // resultado 62750

        for (int i = 1; i <= 500; i++)
        {
            if (i % 2 == 0)  //resto zero é par
            {
                somaPares = somaPares + i;
            }
        }
        Console.WriteLine("O somatório dos valores pares existentes entre 1 e 500 é " + somaPares);
        break;
    case 14:    
        Console.WriteLine("EXERCICIO14" +
        "\n 14: Mostrar as potências de 2 variando de 0 a 10.");

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Potência de 2 elevado à " + i + " é: " + Math.Pow(2, i));
        }
        break;
    case 15:
        Console.WriteLine("EXERCICIO15 - MEDIA PONDERADA" +
        "\n 15: Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado" + 
        "\n ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente." + 
        "\n Considerar nota 7,0 como mínima para aprovação.");

        /// <summary>
        /// Lista contendo as 4 notas de um aluno qualquer
        /// </summary>
        List<double> listaNota = new List<double>();

        /// <summary>
        /// guarda a media ponderada calculada
        /// </summary>
        double mediaPonderada;

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Digite a nota (de 0 a 10):");
            listaNota.Add(double.Parse(Console.ReadLine()));

        }

        /*"A média ponderada é calculada por meio do somatório das multiplicações entre valores e pesos" +
            " divididos pelo somatório dos pesos."
        */
        //Veja mais em: https://brasilescola.uol.com.br/matematica/media-ponderada.htm 

        mediaPonderada = ((listaNota[0] * 2) + (listaNota[1] * 1) + (listaNota[2] * 2) + (listaNota[3] * 4)) / (2 + 1 + 2 + 4);
        //divide por 9

        Console.WriteLine("A média ponderada é: " + mediaPonderada.ToString("F"));

        if (mediaPonderada >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
        break;

    case 16:
        Console.WriteLine("EXERCICIO16" +
        "\n 16: Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da multiplicação sucessiva de N " +
        "\n por 3 enquanto o produto for menor que 250 (N*3; N * 3 * 3; N * 3 * 3 * 3; etc).");
        

        /// <summary>
        /// guarda o número digitado pelo usuário de 0 a 50
        /// </summary>
        int numero = 0; // de 0 a 50 por exemplo

        /// <summary>
        /// guarda o resultado da multiplicação sucessiva por 3
        /// </summary>
        int produto = 0; //numero * 3, numero * 3 * 3, 

        do
        {
            Console.WriteLine("Digite um número de 1 a 50: ");
            numero = int.Parse(Console.ReadLine());

        } while (numero > 50);

        produto = numero;

        do
        {
            produto = produto * 3;
        } while (produto < 250);

        Console.WriteLine("O resultado final é: " + produto);

        break;

    case 17:
        Console.WriteLine("EXERCICIO17" +
        "\n 17: Apresentar os quadrados dos números inteiros de 15 a 200.");
       
        for (int i = 15; i <= 200; i++)
        {
            Console.WriteLine((i * i));
        }
        break;

    case 18:
        Console.WriteLine("EXERCICIO18" +
        "\n 18: Elaborar um programa que apresente o valor de uma potência de uma base qualquer elevada a um expoente" +
        "\n qualquer, ou seja, NM.");
        
        /// <summary>
        /// guarda a base da potencia a ser calculada
        /// </summary>
        double numero1;

        /// <summary>
        /// guarda o expoente da potencia a ser calculada
        /// </summary>
        double numero2;

        /// <summary>
        /// guarda o resultado da potência
        /// </summary>
        double potencia; //potencia = base elevada ao expoente.


        Console.WriteLine("Digite a base e o expoente da sua potência: ");
        numero1 = double.Parse(Console.ReadLine());
        numero2 = double.Parse(Console.ReadLine());

        potencia = Math.Pow(numero1, numero2);

        Console.WriteLine("A potência é: " + potencia.ToString("F"));
        break;
    
    case 19:
        Console.WriteLine("EXERCICIO19" +
        "\n 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o salário e número " +
        "\n de filhos. A prefeitura deseja saber: " +
        "\n " +
        "\n a) média do salário da população; " +
        "\n b) média do número de filhos; " +
        "\n c) maior salário; " +
        "\n d) percentual de pessoas com salário até R$ 100,00." +
        "\n O final da leitura de dados se dará com a entrada de um salário negativo.");

        /// <summary>
        /// guarda numa lista o valor do salário de cada pessoa
        /// </summary>
        List<double> salario = new List<double>(); // se < 0 sair do sistema

        /// <summary>
        /// guarda numa lista a quantidade de filhos de cada pessoa
        /// </summary>
        List<int> numeroFilhos = new List<int>();

        /// <summary>
        /// guarda a media de salário informados
        /// </summary>
        double mediaSalario = 0;

        /// <summary>
        /// guarda a média de filhos por casal
        /// </summary>
        double mediaFilhos = 0;

        /// <summary>
        /// guarda o maior salário da lista pesquisada
        /// </summary>
        double maiorSalario;

        /// <summary>
        /// guarda a qauntidade de pessoas que receb até R$ 100,00
        /// </summary>
        double salarioAte100 = 0; // porcentagem %

        /// <summary>
        ///  variavel que auxilia para que o programa encerre quando o salário for negativo
        /// </summary>
        double auxiliarSalario = 1; // variavel auxiliar

        Console.Clear();

        for (int i = 0; auxiliarSalario >= 0; i++)
        {
            Console.WriteLine("Digite um salário: [Para terminar, digite salário NEGATIVO.] ");
            salario.Add(double.Parse(Console.ReadLine()));
            auxiliarSalario = salario[i];

            if (salario[i] < 0)
            {
                salario.Remove(salario[i]);
                break;
            }
            else
            {
                Console.WriteLine("Digite o número de filhos: ");
                numeroFilhos.Add(int.Parse(Console.ReadLine()));

                if (salario[i] <= 100)
                {
                    salarioAte100++; //contar quantas pessoas recebe até 100 reais
                }
            }
        }

        Console.WriteLine("Total de leituras/pesquisa: " + salario.Count);

        for (int i = 0; i < salario.Count; i++)
        {
            mediaSalario = mediaSalario + salario[i];
            mediaFilhos = mediaFilhos + numeroFilhos[i];

        }

        mediaSalario = mediaSalario / salario.Count;
        mediaFilhos = mediaFilhos / numeroFilhos.Count;
        salario.Sort();
        salarioAte100 = (salarioAte100 / salario.Count) * 100;
        maiorSalario = salario[salario.Count - 1];

        Console.WriteLine("Salário Médio: " + mediaSalario.ToString("C"));
        Console.WriteLine("Média de filhos: " + Math.Round(mediaFilhos));
        Console.WriteLine("Maior salário: " + maiorSalario.ToString("C"));
        Console.WriteLine("Salário até R$ 100,00: " + salarioAte100.ToString("F") + "%");
        break;
    case 20:
        Console.WriteLine("EXERCICIO20" +
        "\n 20. Foi realizada uma pesquisa de algumas características físicas da população de uma " +
        "\n certa região, a qual coletou os seguintes dados referentes a cada habitante para " +
        "\n serem analisados: " +
        "\n - sexo (masculino e feminino)" +
        "\n - cor dos olhos (azuis, verdes ou castanhos)" +
        "\n - cor dos cabelos ( louros, castanhos, pretos)" +
        "\n - idade " +
        "\n " +
        "\n Faça um algoritmo que determine e escreva: " +
        "\n " +
        "\n - a maior idade dos habitantes" +
        "\n - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive" +
        "\n e que tenham olhos verdes e cabelos louros." +
        "\n O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.\n");


        /// <summary>
        ///  
        /// </summary>
        List<int> idade = new List<int>();
        /// <summary>
        ///  
        /// </summary>
        List<string> sexo = new List<string>(); //masculino/feminino
        /// <summary>
        ///  
        /// </summary>
        List<string> corOlhos = new List<string>(); //azuis, verdes ou castanhos
        /// <summary>
        ///  
        /// </summary>
        List<string> corCabelos = new List<string>(); //louros, castanhos, pretos

        /// <summary>
        ///  
        /// </summary>
        int maiorIdade; //o habitante mais velho
        
        /// <summary>
        ///  
        /// </summary>
        int condicao2 = 0;//retorna tudo escrito abaixo
                          //a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
                          //e que tenham olhos verdes e cabelos louros.


        for (int i = 0; i != -1; i++)
        {

            Console.WriteLine("Digite os dados da pesquisa: ");

            Console.Write("Idade [-1 para Sair]: ");
            idade.Add(int.Parse(Console.ReadLine()));

            if (idade[i] == -1)
            {
                break;
            }

            Console.Write("Sexo  [feminino/masculino]: ");
            sexo.Add(Console.ReadLine());

            Console.Write("Cor dos olhos  [azuis, verdes ou castanhos]: ");
            corOlhos.Add(Console.ReadLine());

            Console.Write("Cor dos cabelos   [louros, castanhos, pretos]: ");
            corCabelos.Add(Console.ReadLine());

            //a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
            //e que tenham olhos verdes e cabelos louros.
            if ((sexo[i] == "feminino") && (idade[i] >= 18) && (idade[i] <= 35) && (corOlhos[i] == "verdes") && (corCabelos[i] == "louros"))
            {
                condicao2++;
            }
        }

        idade.Sort();

        //a maior idade dos habitantes
        //- a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
        //e que tenham olhos verdes e cabelos louros.
        Console.WriteLine("Resultado da pesquisa: ");
        Console.WriteLine("Maior idade: " + idade[idade.Count - 1]);
        Console.WriteLine("Mulheres de 18 a 35 anos, loiras de olhos verdes: " + condicao2);
        break;
    default:
        break;
}
