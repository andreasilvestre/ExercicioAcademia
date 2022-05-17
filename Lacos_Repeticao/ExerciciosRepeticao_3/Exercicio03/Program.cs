Console.WriteLine("EXERCICIO 03 - NUMERO PRIMO - Minha solução, próxima solução é do professor Ricardo" +
"\n 3. Fazer um laço (repetição) que fique solicitando números ao usuário. " +
"\n Se o usuário digitar 0 o programa em VS deve parar. " +
"\n Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.");


/// < summary >
/// guarda o numero digitado pelo usuário
/// </summary>
double numero; //verificar se é par, impar  e primo
//numero primo = numero divisivel por 1 e por ele mesmo = divisivel duas vezes

/// <summary>
/// guarda true se for numero primo
/// </summary>
bool primo = true;

numero = 1; //pra garantir

while (numero != 0)
{
    Console.WriteLine("CONJUNTO DE PRIMO 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41," +
               "\n 43, 47,53, 59, 61, 67, 71, 73, 79, 83, 89 e 97 " +
               "\n são os únicos números primos menores que 100.");
    Console.WriteLine("Digite um numero qualquer: [ 0 para sair ]");
    numero = double.Parse(Console.ReadLine());

    if (numero == 0)
    {
        break;
    }

    //verifica par ou impar
    if (numero % 2 == 0)
    {
        Console.WriteLine("Número Par");
    }
    else
    {
        Console.WriteLine("Número Ìmpar");
    }

    if (numero > 1)
    {
        if (numero == 2 || numero == 3 || numero == 5 || numero == 7)
        {
            Console.WriteLine("Número Primo");
        }
        else
        {
            if ((numero % 2 == 0) || (numero % 5 == 0) || (numero % 3 == 0) || (numero % 7 == 0))

                Console.WriteLine("Não é primo");

            else
            {
                Console.WriteLine("Número Primo");
                Console.WriteLine("os números 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41," +
                    "\n 43, 47,53, 59, 61, 67, 71, 73, 79, 83, 89 e 97 " +
                    "\n são os únicos números primos menores que 100.");
            }
        }
    }

}
Console.WriteLine("Acabou a brincadeira!!!");




////SOLUÇÃO PROF RICARDO
//Console.WriteLine("EXERCICIO03 - NUMERO PRIMO - solução do prof Ricardo" +
//"\n 3. Fazer um laço (repetição) que fique solicitando números ao usuário. " +
//"\n Se o usuário digitar 0 o programa em VS deve parar. " +
//"\n Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.\n");


///// <summary>
///// guarda a quantidade que o número digitado é divisível, por exemplo número primo é divisível apenas duas vezes,
///// pelo número 1 e por ele mesmo. Esta é a regra de número primo. Divisível é quando tem resto 0.
///// </summary>
//int contador = 0;

///// <summary>
///// guarda o número digitado pelo usuário
///// </summary>
//double numero;

//for (int i = 1; i != 0; i++)
//{
//    Console.WriteLine("Digite um número qualquer: [Para sair 0]");
//    numero = double.Parse(Console.ReadLine());
//    if (numero == 0)
//    {
//        break;
//    }
//    if (numero % 2 == 0)
//    {
//        Console.WriteLine("Número Par");
//    }
//    else
//    {
//        Console.WriteLine("Número Ímpar");
//    }
//    //divide numero até chegar no número 1 para saber se há somente duas divisoes: por 1 e por ele mesmo
//    //o número 1 não é primo, pq divide somente por ele mesmo
//    contador = 0;
//    for (double i2 = numero; i2 <= numero; i2--)
//    {
//        //Console.WriteLine("Verificando se é divisivel: " + i2);
//        if (numero % i2 == 0)
//        {
//            contador++;
//            //Console.WriteLine("contador: " + contador);
//        }
//        if (i2 == 1)
//        {
//            break;
//        }
//    }
//    if (contador == 2)  //divisivel por 1 e por ele mesmo
//    {
//        Console.WriteLine("Número Primo");
//    }
//    //Console.WriteLine("CONJUNTO DE NÚMEROS PRIMOS ATÉ 100: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41," +
//    //         "\n 43, 47,53, 59, 61, 67, 71, 73, 79, 83, 89 e 97 " +
//    //         "\n são os únicos números primos menores que 100.");
//}