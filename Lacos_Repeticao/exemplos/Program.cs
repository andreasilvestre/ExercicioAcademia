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


///* EXRECICIO 03 - NUMERO PRIMO - ver próxima solução do professor
// 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
//Se o usuário digitar 0 o programa em VS deve parar. 
//Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.   
// */


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
//    Console.WriteLine("CONJUNTO DE PRIMO 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41," +
//               "\n 43, 47,53, 59, 61, 67, 71, 73, 79, 83, 89 e 97 " +
//               "\n são os únicos números primos menores que 100.");
//    Console.WriteLine("Digite um numero qualquer: [ 0 para sair ]");
//    numero = double.Parse(Console.ReadLine());

//    if (numero == 0)
//    {
//        break;
//    }

//    //verifica par ou impar
//    if (numero % 2 == 0)
//    {
//        Console.WriteLine("Número Par");
//    }
//    else
//    {
//        Console.WriteLine("Número Ìmpar");
//    }

//    if (numero > 1)
//    {
//        if (numero == 2 || numero == 3 || numero == 5 || numero == 7)
//        {
//            Console.WriteLine("Número Primo");
//        }
//        else
//        {
//            if ((numero % 2 == 0) || (numero % 5 == 0) || (numero % 3 == 0) || (numero % 7 == 0))

//                Console.WriteLine("Não é primo");

//            else
//            {
//                Console.WriteLine("Número Primo");
//                //Console.WriteLine("os números 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41," +
//                //    "\n 43, 47,53, 59, 61, 67, 71, 73, 79, 83, 89 e 97 " +
//                //    "\n são os únicos números primos menores que 100.");
//            }
//        }
//    }

//}
//Console.WriteLine("Acabou a brincadeira!!!");


///* EXRECICIO 03 - NUMERO PRIMO - solução do prof Ricardo - muito boa parabéns!
// 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
//Se o usuário digitar 0 o programa em VS deve parar. 
//Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.   
// */

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
//}




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

///// <summary>
///// guarda a idade digitada pelo usuário
///// </summary>
//int idade = 0;

//Console.WriteLine("Digite uma idade: ");
//idade = int.Parse(Console.ReadLine());

//while (idade <= 0)
//{
//    Console.WriteLine("Idade incorreta.");
//    Console.WriteLine("Digite uma idade válida, maior que zero.");
//    idade = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("A idade digitada é: " + idade);



/*  EXERCICIO07
 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
A cada solicitação, teste se o usuário informou um valor válido. 
Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
informe que ele está incorreto e saia do programa em VS. 
Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
informe que está errada e saia. Se estiver correta, solicite o salário. 
Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
Se estiver correto, mostre todos os valores lidos.
 */


///// <summary>
///// guarda o nome da pessoa que foi digitado
///// </summary>
//string nome;  //se for branco ou numero, informar q esta incorreto e abortar programa

///// <summary>
///// verifica se há algum numero digitado no nome
///// </summary>
//bool contem_numero = false;

///// <summary>
///// guarda a idade informada pelo usuário
///// </summary>
//int idade;

///// <summary>
///// guardao valor do salário informado pelo usuário
///// </summary>
//double salario;

//Console.WriteLine("Programa de leitura do nome, idade e saláio de uma pessoa");
//Console.WriteLine("Digite o nome da pessoa: ");
//nome = Console.ReadLine();
//nome = nome.ToUpper();

//if ( nome == "" || nome.Contains("0") || nome.Contains("1") || nome.Contains("2") || nome.Contains("3") || nome.Contains("4") || nome.Contains("5") || nome.Contains("6") || nome.Contains("7") || nome.Contains("8") || nome.Contains("9"))
//{
//    contem_numero = true;
//    Console.WriteLine("Nome inválido.");
//}
//else
//{
//    Console.WriteLine("Digite a idade: ");
//    idade = int.Parse(Console.ReadLine());
//    if (idade <= 0)
//    {
//        Console.WriteLine("Idade inválida.");
//    }
//    else
//    {
//        Console.WriteLine("Digite a salário: ");
//        salario = double.Parse(Console.ReadLine());
//        if (salario <= 0)
//        {
//            Console.WriteLine("Salário inválido");
//        }
//        else
//        {
//            Console.WriteLine("Os dados lidos são: ");
//            Console.WriteLine("Nome: " + nome);
//            Console.WriteLine("Idade: " + idade + " anos");
//            Console.WriteLine("Salário: " + salario.ToString("C"));
//        }
//    }
//}



/* EXERCICIO08 - ACHAR NUMERO INTEIRO
8. Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro, solicite-o até 
que seja. após, informe se ele é par ou impar. 
Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
*/

//num_inteiro = (int)numero;  //pega somente a parte inteira

///// <summary>
///// guarda o número digitado 
///// </summary>
//string numero;

///// <summary>
/////  Guarda o numero inteiro digitado. Se não for inteiro, guarda 0. 
///// </summary>
//int num_inteiro;

///// <summary>
///// Guarda True ou False. Se número digitado é imteiro, guarda True, senão False.
///// </summary>
//bool eh_inteiro = false;

///// <summary>
///// guarda os caracteres s/n - repetir sim, repetir não.
///// </summary>
//char repetir;

//do
//{
//    do
//    {
//        Console.WriteLine("Digite um número inteiro: ");
//        numero = Console.ReadLine();
//        eh_inteiro = int.TryParse(numero, out num_inteiro);

//    } while (eh_inteiro == false);

//    if (num_inteiro%2 == 0)
//    {
//        Console.WriteLine("O número informado é Par.");
//    }
//    else
//    {
//        Console.WriteLine("O número informado é Ímpar.");
//    }

//    Console.WriteLine("Deseja repetir a análise do número? (s/n)");
//    repetir = char.Parse(Console.ReadLine());
//    repetir = char.ToUpper(repetir);

//} while (repetir == 'S');

////verificação de dados:
//Console.WriteLine("Mostra número convertido em inteiro: " + num_inteiro + " É inteiro? "+ eh_inteiro)


/* EXERCICIO09 - INTERVALO DE FILHOS VER FUNÇÃO PRONTA
9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
o zoológico num determinado dia, imprimindo:
Quantas pessoas tem entre 1 e 3 filhos.
Quantas pessoas tem entre 4 e 7 filhos.
Quantas pessoas tem mais de 8 filhos.
Quantas pessoas não tem filhos.
*/

////30 pessoas

///// <summary>
/////  guarda a quantidade de filhos de uma pessoa informada pelo usuário
///// </summary>
//int quantidade_filhos;

///// <summary>
/////  guarda a quantidade de pessoas que tem de 1 a 3 filhos
///// </summary>
//int filhos1a3 = 0;

///// <summary>
///// guarda a quantidade de pessoas que tem de 4 a 7 filhos
///// </summary>
//int filhos4a7 = 0;

///// <summary>
///// guarda a quantidade de pessoas que tem 8 ou mais filhos
///// </summary>
//int filhosMaisde8 = 0;

///// <summary>
///// guarda a quantidade de pessoas que não possui nenhum filho
///// </summary>
//int semFilhos = 0;

//for (int i = 1; i <= 30; i++)
//{
//    Console.WriteLine("Digite a quantidade de filhos da pessoa " + i);
//    quantidade_filhos = int.Parse(Console.ReadLine());   

//    if ((quantidade_filhos == 1) || (quantidade_filhos == 2) || (quantidade_filhos == 3))
//    {
//        filhos1a3++;
//    }
//    else if ((quantidade_filhos == 4) || (quantidade_filhos == 5) || (quantidade_filhos == 6) || (quantidade_filhos == 7))
//    {
//        filhos4a7++;
//    }
//    else if (quantidade_filhos >= 8)
//    {
//        filhosMaisde8++;
//    }
//    else if (quantidade_filhos == 0)
//    {
//        semFilhos++;
//    }
//}

//Console.WriteLine("O panorama sobre quantidade de filhos dos visitantes ficaram da seguinte forma: ");
//Console.WriteLine("De 1 a 3 filhos: " + filhos1a3 );
//Console.WriteLine("De 4 a 7 filhos: " + filhos4a7);
//Console.WriteLine("Mais de 8 filhos: " + filhosMaisde8);
//Console.WriteLine("Sem filhos: " + semFilhos);






///*  EXERCICIO10
//10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
//Número de pessoas do sexo masculino.
//Número de pessoas do sexo feminino.
//Número de pessoas com idade inferior a 30 anos.
//Número de pessoas com idade superior a 60 anos.
//Média de idade das mulheres.
//*/

////total 50 pessoas
///// <summary>
///// guarda o nome da pessoa
///// </summary>
//string nome;

///// <summary>
///// guarda o sexo da pessoa, masculino ou feminino
///// </summary>
//string sexo;//feminino ou masculino

///// <summary>
///// guarda a idade da pessoa
///// </summary>
//int idade;

///// <summary>
///// guarda o total de pessoas do sexo masculino
///// </summary>
//int totalMasculino = 0;

///// <summary>
///// guarda o total de pessoas do sexo feminino
///// </summary>
//int totalFeminino = 0;

///// <summary>
///// guarda o total de pessoas com idade inferior a 30 anos
///// </summary>
//int inferior30Anos = 0;

///// <summary>
///// guarda o total de pessoas com idade superior a 60 anos
///// </summary>
//int superior60Anos = 0;

///// <summary>
///// guarda a somatória das idades das mulheres para calcular a média
///// </summary>
//int somaIdadeMulheres = 0; //para achar média

///// <summary>
///// guarda a média das idades das mulheres => media = soma das idades mulheres / total de idades mulheres
///// </summary>
//double mediaIdadeMulheres = 0; // divide por totalFeminino

////pendencia= trocar for para 50 pessoas - teste com 5
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Digite o nome da pessoa: ");
//    nome = Console.ReadLine();
//    nome = nome.ToUpper();

//    Console.WriteLine("Digite o sexo - (feminino/masculino)");
//    sexo = Console.ReadLine();
//    sexo = sexo.ToUpper();

//    Console.WriteLine("Digite a idade: ");
//    idade = int.Parse(Console.ReadLine());

//    if (sexo == "MASCULINO")
//    {
//        totalMasculino++;
//    }
//    else if (sexo == "FEMININO")
//    {
//        totalFeminino++;
//        somaIdadeMulheres = somaIdadeMulheres + idade;
//    }

//    if (idade < 30)
//    {
//        inferior30Anos++;
//    }
//    else if (idade > 60)
//    {
//        superior60Anos++;
//    }
//}
//mediaIdadeMulheres = somaIdadeMulheres / totalFeminino;

//Console.WriteLine("Pessoas do sexo masculino: " + totalMasculino);
//Console.WriteLine("Pessoas do sexo feminino: " + totalFeminino);
//Console.WriteLine("Pessoas com idade inferior a 30 anos: " + inferior30Anos);
//Console.WriteLine("Pessoas com idade superior a 60 anos: " + superior60Anos);
//Console.WriteLine("Média de idade das mulheres.: " + (int)mediaIdadeMulheres);




///*
//// EXERCICIO11 - usar list[] LISTA
//PENDENCIA - VER LISTA COMPOSTA POR MAIS DE UM TIPO. EX NOME E NOTA DOS ALUNOS
//11: Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
//a média aritmética da turma e a quantidade de alunos da turma. Usar como flag a nota 12.
//*/


///// <summary>
///// guarda o nome de cada aluno informado
///// </summary>
//List<string> listaAluno = new List<string>(); // naõ está servindo pra nada por enquanto

///// <summary>
///// guarda a relação de notas dos respectivos alunos informados
///// </summary>
//List<double> listaNota = new List<double>(); //toda vez que usar new colocar parenteses () no final

///// <summary>
///// guarda o total de alunos da turma analisada
///// </summary>
//int totalAlunos;

///// <summary>
///// guarda a somatoria das notas e depois a média final da turma
///// </summary>
//double mediaNota = 0;

//Console.WriteLine("Digite a quantidade de Alunos: ");
//totalAlunos = int.Parse(Console.ReadLine());

//for (int i = 0; i < totalAlunos; i++)
//{
//    Console.WriteLine("Digite o nome do aluno: ");
//    listaAluno.Add(Console.ReadLine());

//    Console.WriteLine("Digite a nota do aluno " + listaAluno[i] + " (nota de 0 a 12)");
//    listaNota.Add(double.Parse(Console.ReadLine()));

//    mediaNota = mediaNota + listaNota[i];
//}

//mediaNota = mediaNota / listaNota.Count;
//listaNota.Sort();// ordena a lista em ordem crescente, de 0 a totalAlunos

//Console.WriteLine("Nota mais alta: " + listaNota[listaNota.Count - 1]);
//Console.WriteLine("Nota mais baixa: " + listaNota[0]);
//Console.WriteLine("Total de alunos: " + listaNota.Count);
//Console.WriteLine("A média aritmética da turma é: " + mediaNota);



///* EXERCICIO12
//12: Apresentar o total da soma dos cem primeiros números inteiros.
//*/

//int somaInteiro =0 ; //5050

//// de 1 a 100
//for (int i = 1; i <= 100; i++)
//{
//    somaInteiro = somaInteiro + i;   
//}

//Console.WriteLine("A soma total dos cem primeiros números inteiros é: " + somaInteiro);



///* EXERCICIO13
//13: Elaborar um programa que apresente o somatório dos valores pares existentes entre 1 e 500.
//*/
//int somaPares = 0; // resultado 62750

//for (int i = 1; i <= 500; i++)
//{
//    if (i%2 == 0)  //resto zero é par
//    {
//        somaPares = somaPares + i;
//    }
//}
//Console.WriteLine("O somatório dos valores pares existentes entre 1 e 500 é " + somaPares);



///*EXERCICIO14
//14: Mostrar as potências de 2 variando de 0 a 10.
//*/

//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine("Potência de 2 elevado à " + i + " é: " + Math.Pow(2,i));
//}


///* EXERCICIO15 - MEDIA PONDERADA
//15: Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
//ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
//Considerar nota 7,0 como mínima para aprovação.
//*/


///// <summary>
///// Lista contendo as 4 notas de um aluno qualquer
///// </summary>
//List<double> listaNota = new List<double>();

///// <summary>
///// guarda a media ponderada calculada
///// </summary>
//double mediaPonderada;

//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine("Digite a nota (de 0 a 10):");
//    listaNota.Add(double.Parse(Console.ReadLine()));

//}

///*"A média ponderada é calculada por meio do somatório das multiplicações entre valores e pesos" +
//    " divididos pelo somatório dos pesos."
//*/
////Veja mais em: https://brasilescola.uol.com.br/matematica/media-ponderada.htm 

//mediaPonderada = (listaNota[0] * 2 + listaNota[1] * 1 + listaNota[2] * 2 + listaNota[3] * 4) / (2 + 1 + 2 + 4);
////divide por 9

//Console.WriteLine("A média ponderada é: " + mediaPonderada.ToString("F"));
//if (mediaPonderada >= 7)
//{
//    Console.WriteLine("Aprovado");
//}
//else
//{
//    Console.WriteLine("Reprovado");
//}


//// EXERCICIO16
///*16: Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da multiplicação sucessiva de N 
//por 3 enquanto o produto for menor que 250 (N*3; N * 3 * 3; N * 3 * 3 * 3; etc).
//*/

///// <summary>
///// guarda o número digitado pelo usuário de 0 a 50
///// </summary>
//int numero = 0; // de 0 a 50 por exemplo

///// <summary>
///// guarda o resultado da multiplicação sucessiva por 3
///// </summary>
//int produto = 0; //numero * 3, numero * 3 * 3, 

//do
//{
//    Console.WriteLine("Digite um número de 1 a 50: ");
//    numero = int.Parse(Console.ReadLine());

//} while (numero > 50);

//produto = numero;

//do
//{
//    produto = produto * 3;
//} while (produto < 250);

//Console.WriteLine("O resultado final é: " + produto);





///*EXERCICIO17 - ERRADA - DUVIDAS PENDENCIA
//17: Apresentar os quadrados dos números inteiros de 15 a 200.
//*/

//for (int i = 15; i <= 200; i++)
//{
//    Console.WriteLine((i*i));
//}



///* EXERCICIO18
//18: Elaborar um programa que apresente o valor de uma potência de uma base qualquer elevada a um expoente 
//qualquer, ou seja, NM.
//*/

///// <summary>
///// guarda a base da potencia a ser calculada
///// </summary>
//double numero1;

///// <summary>
///// guarda o expoente da potencia a ser calculada
///// </summary>
//double numero2;

///// <summary>
///// guarda o resultado da potência
///// </summary>
//double potencia; //potencia = base elevada ao expoente.


//Console.WriteLine("Digite a base e o expoente da sua potência: ");
//numero1 = double.Parse(Console.ReadLine());
//numero2 = double.Parse(Console.ReadLine());

//potencia = Math.Pow(numero1, numero2);

//Console.WriteLine("A potência é: " + potencia.ToString("F"));


///* EXERCICIO19
//19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o salário e número 
//de filhos. A prefeitura deseja saber: 

//a) média do salário da população;
//b) média do número de filhos;
//c) maior salário;
//d) percentual de pessoas com salário até R$ 100,00.
//O final da leitura de dados se dará com a entrada de um salário negativo.
//*/

///// <summary>
///// guarda numa lista o valor do salário de cada pessoa
///// </summary>
//List<double> salario = new List<double>(); // se < 0 sair do sistema

///// <summary>
///// guarda numa lista a quantidade de filhos de cada pessoa
///// </summary>
//List<int> numeroFilhos = new List<int>();

///// <summary>
///// guarda a media de salário informados
///// </summary>
//double mediaSalario = 0;

///// <summary>
///// guarda a média de filhos por casal
///// </summary>
//double mediaFilhos = 0;

///// <summary>
///// guarda o maior salário da lista pesquisada
///// </summary>
//double maiorSalario;

///// <summary>
///// guarda a qauntidade de pessoas que receb até R$ 100,00
///// </summary>
//double salarioAte100 = 0; // porcentagem %

///// <summary>
/////  variavel que auxilia para que o programa encerre quando o salário for negativo
///// </summary>
//double auxiliarSalario = 1; // variavel auxiliar

//Console.Clear();

//for (int i = 0; auxiliarSalario >= 0; i++)
//{
//    Console.WriteLine("Digite um salário: [Para terminar, digite salário NEGATIVO.] ");
//    salario.Add(double.Parse(Console.ReadLine()));
//    auxiliarSalario = salario[i];

//    if (salario[i] < 0)
//    {
//        salario.Remove(salario[i]); 
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Digite o número de filhos: ");
//        numeroFilhos.Add(int.Parse(Console.ReadLine()));

//        if (salario[i] <= 100)
//        {
//            salarioAte100++; //contar quantas pessoas recebe até 100 reais
//        }
//    }
//}

//Console.WriteLine("Total de leituras/pesquisa: " + salario.Count);

//for (int i = 0; i < salario.Count; i++)
//{
//    mediaSalario = mediaSalario + salario[i];
//    mediaFilhos = mediaFilhos + numeroFilhos[i];

//}

//mediaSalario = mediaSalario / salario.Count;
//mediaFilhos = mediaFilhos / numeroFilhos.Count;
//salario.Sort();
//salarioAte100 = (salarioAte100 / salario.Count) * 100;
//maiorSalario = salario[salario.Count - 1];

//Console.WriteLine("Salário Médio: " + mediaSalario.ToString("C"));
//Console.WriteLine("Média de filhos: " + Math.Round(mediaFilhos));
//Console.WriteLine("Maior salário: " + maiorSalario.ToString("C"));
//Console.WriteLine("Salário até R$ 100,00: " + salarioAte100.ToString("F") + "%");


///*  EXERCICIO20
//20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
//certa região, a qual coletou os seguintes dados referentes a cada habitante para 
//serem analisados:
//- sexo (masculino e feminino)
//- cor dos olhos (azuis, verdes ou castanhos)
//- cor dos cabelos ( louros, castanhos, pretos)
//- idade 

//Faça um algoritmo que determine e escreva: 

//- a maior idade dos habitantes
//- a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
//e que tenham olhos verdes e cabelos louros.
//O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
// */

////int idade;
//List<int> idade = new List<int>();
//List<string> sexo = new List<string>(); //masculino/feminino
//List<string> corOlhos= new List<string>(); //azuis, verdes ou castanhos
//List<string> corCabelos = new List<string>(); //louros, castanhos, pretos

//int maiorIdade; //o habitante mais velho
//int condicao2 = 0;//retorna tudo escrito abaixo
////a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
////e que tenham olhos verdes e cabelos louros.

//int totalPesquisa = 2000;  // atribuir um valor qualquer para total máximo de pesquisa

////pendencia - estudar duvida - tudo junto
////List<(int id, string sex, string corOlhos)> sex = new List<(int id, string sex, string corOlhos)>();

//for (int i = 0; i < totalPesquisa; i++)
//{

//    Console.WriteLine("Digite os dados da pesquisa: ");

//    Console.Write("Idade [-1 para Sair]: ");
//    idade.Add(int.Parse(Console.ReadLine()));

//    if (idade[i] == -1)
//    {
//        break;
//    }

//    Console.Write("Sexo  [feminino/masculino]: ");
//    sexo.Add(Console.ReadLine());

//    Console.Write("Cor dos olhos  [azuis, verdes ou castanhos]: ");
//    corOlhos.Add(Console.ReadLine());

//    Console.Write("Cor dos cabelos   [louros, castanhos, pretos]: ");
//    corCabelos.Add(Console.ReadLine());

//    //a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
//    //e que tenham olhos verdes e cabelos louros.
//    if ((sexo[i] == "feminino") && (idade[i] >= 18) && (idade[i] <= 35) && (corOlhos[i] == "verdes") && (corCabelos[i] == "louros"))
//    {
//        condicao2++; 
//    }
//}

//idade.Sort();

////a maior idade dos habitantes
////- a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
////e que tenham olhos verdes e cabelos louros.
//Console.WriteLine("Maior idade: " + idade[idade.Count-1]);
//Console.WriteLine("Mulheres de 18 a 35 anos, loiras de olhos verdes: " + condicao2);

//EXERCICIOS DE 13/05/2022
//https://github.com/alexandrezamberlan/academiaDotNet/blob/main/exerciciosDesafios/4_exerciciosRepeticaoDESAFIO.txt
//EXERCICIOS DA LISTA 4 DE REPETIÇÃO



///*EXERCICIO4-01
//1.	Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte
//soma: S = 1 + 1/2 + 1/3 + 1/4 + 1/5 .... 1/n
//*/

//int n;
//double soma;

//Console.WriteLine("Digite um número inteiro e positivo: ");
//n = int.Parse(Console.ReadLine());

//soma = 1;
//for (double i = 2; i <= n; i++)
//{
//    soma = soma + (1 / i); //1/2,1/3,1/4

//    Console.WriteLine("Soma i: " + i + ":  " + soma.ToString("F"));
//}
//Console.WriteLine("Resultado da soma é: " + soma.ToString("F"));


///*
//EXERCICIO4-02
//2.	Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20. Considere que
//Polegada = Centímetro * 2,54.
//polegada = de 1 a 20
//centimetro = polegada / 2,54
//*/

//List<double> listaCentimetro = new List<double>();
//double valor_centimetro;

//for (double i = 1; i <= 20; i++)
//{
//    valor_centimetro = i / 2.54;
//    listaCentimetro.Add(valor_centimetro);  
//}

//Console.WriteLine("Tabela de conversão de polegadas para centímetros: ");

//for (int i = 0; i < 20; i++)
//{
//    Console.WriteLine((i+1) + " ==> " + listaCentimetro[i].ToString("F"));
//}


///* EXERCICIO4-03
// 3.	Dado um limite inferior e superior, calcule a soma de todos os números pares contidos
//nesse intervalo. 
//*/

//double inferior;
//double superior;
//double somaPares = 0;

//Console.WriteLine("Digite um intevalo de números a calcular: ");
//inferior = double.Parse(Console.ReadLine());
//superior = double.Parse(Console.ReadLine());

//for (double i = inferior; i <= superior; i++)
//{
//    if (i%2 == 0)
//    {
//        somaPares = somaPares + i;
//    }
//}
//Console.WriteLine("A soma dos pares é: " + somaPares);



///*  EXERCICIO4-04  - TESTAR - PENDENCIA - FALTA TERMINAR
//4 . Faça um algoritmo que leia uma lista de números inteiros positivos terminada pelo número 0 (zero). 
//Ao final, o algoritmo deve mostrar a média aritmética de todos os números lidos (excluindo o zero).
//*/

////List<int> listaNumeros = new List<int>();//precisa ser string pq irei descartar o ultimo caracter=0
//string auxiliar;
//int auxiliar2;
//double media = 0;

//for (int i = 0; i <= 10; i++)
//{
//    Console.Write("Digite um número inteiro e positivo: ");
//    auxiliar = Console.ReadLine();

//    auxiliar = auxiliar.Substring(0, auxiliar.Length - 1);
//    auxiliar2 = int.Parse(auxiliar);
//    Console.WriteLine(auxiliar2);

//    //listaNumeros.Add(auxiliar2);
//    media = media + Convert.ToDouble(auxiliar2);
//}

//media = media / 10;
//Console.WriteLine("Média: " + media);

//REFAZER NUMERO PRIMO - o 03

///*  EXERCICIO4-05
//5.	Escreva um programa em C# que gera números entre 1000 e 1999 e mostra aqueles que divididos
//por 11 dão resto 5.
//*/

//for (int i = 1000; i <= 1999; i++)
//{
//    if ((i%11 == 5))
//    {
//        Console.WriteLine(i);
//    }
//}


///*
//EXERCICIO4-06
//6.	Faça um programa que leia um número n e imprima se ele é primo ou não. 
//(um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)
//*/

////numero primo - de novo para ficar craque
//int contador = 0;
//double numero;


//Console.WriteLine("Digite um número qualquer: ");
//numero = double.Parse(Console.ReadLine());

//for (double i = numero; i <= numero; i--)
//{
//    if (numero%i == 0)
//    {
//        contador++;
//    }
//    if (i == 1)
//    {
//        break;
//    }
//}

//if (contador == 2)
//{
//    Console.WriteLine("Número primo");
//}
//else
//{
//    Console.WriteLine("Não é primo");
//}



///*
//EXERCICIO4-07
//7.	Os dois primeiros números da sequência de Fibonacci são 0 e 1. Os próximos números dessa 
//sequência podem ser calculados como sendo a soma dos dois números anteriores. Os primeiros
//números de Fibonacci são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … Escreva um algoritmo 
//que leia um número pelo teclado N, e então mostre os N primeiros números da sequência de Fibonacci.
// */

////escrever a sequencia até o número informado

//int numero;
//List<int> sequenciaFibonacci = new List<int>();

///// <summary>
///// guarda a soma dos dois números  anteriores da lista
///// </summary>
//int proximoNumero;

//Console.WriteLine("Digite um número qualquer: ");
//numero = int.Parse(Console.ReadLine());

//sequenciaFibonacci.Add(0);// posição 0
//sequenciaFibonacci.Add(1);// posição 1
//for (int i = 2; i <= numero; i++)
//{
//    //Fn = Fn - 1 + Fn - 2
//    proximoNumero = sequenciaFibonacci[i - 1] + sequenciaFibonacci[i - 2];
//    sequenciaFibonacci.Add(proximoNumero);
//}

//for (int i = 0; i < sequenciaFibonacci.Count; i++)
//{
//    Console.WriteLine(sequenciaFibonacci[i]);
//}