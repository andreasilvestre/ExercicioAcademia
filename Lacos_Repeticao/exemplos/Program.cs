//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine("i vale: " + i);
//}


////mostrar de 0 a 10
//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine("i vale: " + i);
//}

//mostrar de 20 a 5
//for (int i = 20; i >= 5; i--)
//{
//    Console.WriteLine("i vale: " + i);
//}

//int num_inicio, num_fim;

//Console.WriteLine("Digite o intervalo de dois números inteiros: ");    
//num_inicio = int.Parse(Console.ReadLine()); 
//num_fim = int.Parse(Console.ReadLine());

//if (num_inicio < num_fim)
//{
//    for (int i = num_inicio; i <= num_fim; i++)
//    {
//        Console.WriteLine("O número i é´: " + i);
//    }
//}
//else if ( num_inicio > num_fim)
//{
//    //32 a 25 = 32,31,30,29...
//    for (int i = num_inicio; i >= num_fim; i--)
//    {
//        Console.WriteLine("O número i é: " + i);
//    }
//}
//else {
//    Console.WriteLine("Não existe intervalo. Favor digitar numeros diferentes.");
//}

//int x;
//// pular de x em x; ex. x=4=> 0,4,8,12,16....

//Console.WriteLine("Digite um valor x qualquer: ");
//x = int.Parse(Console.ReadLine());

//for (int i = 0; i <= 100; i = i + x)
//{
//    Console.WriteLine("i vale: " + i);
//}

//int x;
//// mostrar os numeros divisiveis por x no intervalo de 0 a 100

//Console.WriteLine("Digite um valor x qualquer: ");
//x = int.Parse(Console.ReadLine());

//for (int i = 1; i <= 100; i++)
//{
//    if (i%x==0)
//    {
//        Console.WriteLine("i vale: " + i);
//    }  
//}

//ler um numero e apresentar a tabuada do mesmo.

//int x, taboada;

//Console.WriteLine("Digite um número qualquer: ");
//x = int.Parse(Console.ReadLine());

//for (int i = 1; i<= 10; i++)
//{
//    taboada = x * i;
//    Console.WriteLine($"Taboada: {x} x {i} = {taboada}");
//}

/* Exercicio01 = aula de inicio 12/05/2022 - ok
 *1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.
Exemplo:
Digite um número inteiro positivo: -8
Valor incorreto!
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6.
 */



///// <summary>
///// guarda o numero digitado pelo usuário
///// </summary>
//int numero; //inteiro > 0
//            //numeros pares de 1 a numero

////int[] vetor; pensar nisso

//Console.WriteLine("Digite um número inteiro e positivo: ");
//numero = int.Parse(Console.ReadLine());

//while (numero <= 0)
//{
//    Console.WriteLine("Número inválido, digite um número inteiro e positivo: ");
//    numero = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Os números pares entre 1 e " + numero + " é: ");
//for (int i = 2; i <= numero; i = i + 2)

//{
//    Console.WriteLine(i);
//}

/* Exercicio02 - ok
 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
Exemplo:
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6.
 
Deseja informar outro número (s/n)? S
 
Digite um número inteiro positivo: 12
Numero digitado: 20
Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 
Deseja informar outro número (s/n)? N  
 */

///// <summary>
///// guarda o numero digitado pelo usuário
///// </summary>
//int numero; //inteiro > 0
//            //numeros pares de 1 a numero

////guarda se sim ou não s/n para executar o exercicio 01 novamente
//char outroNumero; // s/n

//outroNumero = 'S';

//do
//{

//    Console.WriteLine("Digite um número inteiro e positivo: ");
//    numero = int.Parse(Console.ReadLine());

//    while (numero <= 0)
//    {
//        Console.WriteLine("Número inválido, digite um número inteiro e positivo: ");
//        numero = int.Parse(Console.ReadLine());
//    }

//    Console.WriteLine("Os números pares entre 1 e " + numero + " é: ");
//    for (int i = 2; i <= numero; i = i + 2)

//    {
//        Console.WriteLine(i);
//    }

//    Console.WriteLine("Deseja informar outro número (s/n)?");
//    outroNumero = char.Parse(Console.ReadLine());


//} while (outroNumero == 'S' || outroNumero == 's');


/* EXRECICIO 03 - NUMERO PRIMO - PENDENTE DUVIDAS
 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
Se o usuário digitar 0 o programa em VS deve parar. 
Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.   
 */


///// <summary>
///// guarda o numero digitado pelo usuário
///// </summary>
//double numero; //verificar se é par, impar  e primo
////numero divisivel por 1 e por ele mesmo

///// <summary>
///// guarda true se for numero primo
///// </summary>
//bool primo = true;

//numero = 1; //pra garantir

//while (numero != 0)
//{
//    Console.WriteLine("Digite um numero qualquer: ");
//    numero = double.Parse(Console.ReadLine());

//    if (numero != 0)
//    {
//        //verifica par ou impar
//        if (numero % 2 == 0)
//        {
//            Console.WriteLine("Número Par");
//        }
//        else
//        {
//            Console.WriteLine("Número Ìmpar");
//        }

//        //verifica se é primo ??? duvida pendencia
//        //testar 7
//        if ((numero > 1 )
//            && (numero%2 != 0) && (numero%5 != 0) && (numero % 3 != 0) && (numero % 7 != 0))



//        if (primo)
//        {
//            Console.WriteLine("Número Primo");
//            Console.WriteLine("os números 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41," +
//                "\n 43, 47,53, 59, 61, 67, 71, 73, 79, 83, 89 e 97 " +
//                "\n são os únicos números primos menores que 100.");
//        }
//    }
//}
//Console.WriteLine("Acabou a brincadeira!!!");

///* EXERCICIO04
// 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
//Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
//Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
//Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
//escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
//de votos em branco. 
// */

//int votosJoao = 0;
//int votosZeca = 0;
//int votosBranco = 0;

//string candidato = "INICIO"; //JOAO, ZECA OU BRANCO FIM

//do
//{
//    Console.WriteLine("Digite seu voto: (JOAO, ZECA OU BRANCO) - para terminar votação digite FIM");
//    candidato = Console.ReadLine();
//    candidato = candidato.ToUpper();

//    if (candidato == "JOAO")
//    {
//        votosJoao++;
//    }
//    else if (candidato == "ZECA")
//    {
//        votosZeca++;
//    }
//    else if (candidato == "BRANCO")
//    {
//        votosBranco++;
//    }

//} while (candidato != "FIM");

//Console.WriteLine("A votação ficou da seguinte forma: ");
//Console.WriteLine("JOAO: " + votosJoao);
//Console.WriteLine("ZECA: " + votosZeca);
//Console.WriteLine("BRANCOS: " + votosBranco);


/* EXERCICIO05
 5. Modifique o programa em VS anterior para aceitar votos nulos 
(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
Ao final, informe o nome do candidato vencedor, o número de votos nulos e o número de pessoas que votaram.
 */

//int votosJoao = 0;
//int votosZeca = 0;
//int votosBranco = 0;
//int votosNulos = 0;

//string candidato = "INICIO"; //JOAO, ZECA OU BRANCO FIM

//do
//{
//    Console.WriteLine("Digite seu voto: (JOAO, ZECA OU BRANCO) - para terminar votação digite FIM");
//    candidato = Console.ReadLine();
//    candidato = candidato.ToUpper();

//    if (candidato == "JOAO")
//    {
//        votosJoao++;
//    }
//    else if (candidato == "ZECA")
//    {
//        votosZeca++;
//    }
//    else if (candidato == "BRANCO")
//    {
//        votosBranco++;
//    }
//    else if (candidato != "FIM")
//    {
//        votosNulos++;
//    }

//} while (candidato != "FIM");

//Console.WriteLine("A votação ficou da seguinte forma: ");
//Console.WriteLine("Total de eleitores que compareceram: " + (votosJoao + votosZeca + votosBranco + votosNulos));
//Console.WriteLine("JOAO: " + votosJoao);
//Console.WriteLine("ZECA: " + votosZeca);
//Console.WriteLine("BRANCOS: " + votosBranco);
//Console.WriteLine("NULOS: " + votosNulos);
//if (votosJoao > votosZeca)
//{
//    Console.WriteLine("O vencedor é João, com " + votosJoao + " votos");
//}
//else if (votosJoao < votosBranco)
//{
//    Console.WriteLine("O vencedor é Zeca, com " + votosZeca + " votos");
//}
//else
//{
//    Console.WriteLine("Empatou");
//}


/* EXERCICIO06
 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
Ao final, mostre a idade digitada.
 */