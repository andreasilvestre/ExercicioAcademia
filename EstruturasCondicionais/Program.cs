//exemplo 1
//int num;

//Console.WriteLine("Digite um número qualquer: ");
//num = int.Parse(Console.ReadLine());

//if (num > 0)
//{
//    Console.WriteLine("Positivo");
//}
//else if (num < 0)
//{
//    Console.WriteLine("Negativo");
//}
//else 
//{
//    Console.WriteLine("Zero");
//}

//if (num > 0) Console.WriteLine("Positivo - Você pode escrever if assim se for apenas uma linha");



// exemplo 4
//int num;

//Console.WriteLine("Digite um número qualquer: ");
//num = int.Parse(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("Divisível por 2");
//}
//if (num % 4 == 0 )
//{
//    Console.WriteLine("Divisível por 4");
//}
//if (num % 8 == 0)
//{
//    Console.WriteLine("Divisível por 8");
//}


////teste - pode fazer if assim para um único comando(linha)
//if (num % 2 == 0) Console.WriteLine("Teste - Divisível por 2");
//if (num % 4 == 0) Console.WriteLine("Teste - Divisível por 4");
//if (num % 8 == 0) Console.WriteLine("Teste - Divisível por 8");


//exemplo 9
//int num1, num2;
//Console.WriteLine("Digite dois números: ");
//num1= int.Parse(Console.ReadLine());
//num2 = int.Parse(Console.ReadLine());

//if (num1 == num2)
//{
//    Console.WriteLine("Os números são iguais.");
//}
//else if (num1 != num2) // não precisa perguntar, só testando not igual !=
//{
//    Console.WriteLine("Os números são diferentes.");
//}


//exemplo 12 - fazendo calculadora
//double num1, num2, resultado;
//int op;

//Console.WriteLine("Digite dois números: ");
//num1 = double.Parse(Console.ReadLine());
//num2 = double.Parse(Console.ReadLine());

//Console.WriteLine("Digite a operação que deseja fazer: " +
//    "\n1 - Soma" +
//    "\n2 - Subtração" +
//    "\n3 - Multiplicação" +
//    "\n4 - Divisão" +
//    "\n5 - Potência");
//op = int.Parse(Console.ReadLine());

//if (op == 1)
//{
//    resultado = num1 + num2;
//    Console.WriteLine("Soma: " + resultado);
//}
//else if (op == 2)
//{
//    resultado = num1 - num2;
//    Console.WriteLine("Subtração: " + resultado);
//}
//else if (op == 3)
//{
//    resultado = num1 * num2;
//    Console.WriteLine("Multiplicação: " + resultado);
//}
//else if (op == 4)
//{
//    resultado = num1 / num2;
//    Console.WriteLine("Divisão: " + resultado);
//}
//else if (op == 5)
//{
//    resultado = Math.Pow(num1,num2);
//    Console.WriteLine("Potência: " + resultado);
//}

//Console.WriteLine("1 - Faça um algoritmo para calcular e mostrar a área de um " +
//    "\n triângulo a partir dos valores da base e da altura lidos pelo teclado: " +
//    "\n Área do triangulo = (base * altura) / 2; " +
//    "\n Teste se a base ou a altura digitada não foi igual a zero. ");


//double base_tri;
//double altura, area;

//Console.WriteLine("Digite a base e a altura: ");
//base_tri = double.Parse(Console.ReadLine());
//altura = double.Parse(Console.ReadLine());

//if (base_tri == 0 || altura == 1)
//{
//    Console.WriteLine("Digite valores diferente de zero.");
//}
//else
//{
//    area = (base_tri * altura) / 2;
//    Console.WriteLine("A área do triângulo é: " + area);
//}

//Console.WriteLine("2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.");

//double numero;

//Console.WriteLine("Digite um número qualquer: ");
//numero = double.Parse(Console.ReadLine());

//if (numero % 2 == 0) Console.WriteLine("Número par.");
//else Console.WriteLine("Número ímpar.");

//Console.WriteLine("3 - Escrever um algoritmo para ler quatro valores inteiros," +
//    "\n calcular a sua média, e escrever na tela os que são superiores à média.");

//double num1, num2, num3, num4;
//double media;

//Console.WriteLine("Digite 4 números inteiros: ");
//num1 =double.Parse(Console.ReadLine());
//num2 = double.Parse(Console.ReadLine());
//num3 = double.Parse(Console.ReadLine());
//num4 = double.Parse(Console.ReadLine());

//media = (num1 + num2 + num3 + num4)/4;
//Console.WriteLine("A média é: " + media);
//Console.WriteLine("Os valores superiores à media são: ");

//if (num1 > media)
//{
//    Console.WriteLine(num1);
//}
//if (num2 > media)
//{
//    Console.WriteLine(num2);
//}
//if (num3 > media)
//{
//    Console.WriteLine(num3);
//}
//if (num4 > media)
//{
//    Console.WriteLine(num4);
//}


//Console.WriteLine("4 - Escrever um algoritmo para ler a quantidade de horas aula " +
//    "\n dadas por dois professores e o valor por hora recebido por cada um deles." +
//    "\n Mostrar na tela qual dos professores tem o maior salário total.");

////leitura
//int qt_horaA, qt_horaB;
//double vl_horaA, vl_horaB;

////resultado
//string professores;
//string[] valor;

//double salarioA, salarioB;


//int n;
//Console.WriteLine("Digite o total de testes a realizara: ");
//n = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("\nDigite a quantidade de horas dos dois professores" +
//    "\n e o valor hora de cada um, separado por espaço:");
//    professores = Console.ReadLine();   

//    valor = professores.Split(' ');
//    qt_horaA = int.Parse(valor[0]);
//    qt_horaB = int.Parse(valor[1]);
//    vl_horaA = double.Parse(valor[2]);
//    vl_horaB = double.Parse(valor[3]);

//    Console.WriteLine(qt_horaA + " | " + qt_horaB + " | " + vl_horaA + " | " + vl_horaB); //leitura apenas

//    salarioA = qt_horaA * vl_horaA;
//    salarioB = qt_horaB * vl_horaB;

//    Console.WriteLine("Os salários dos professores A e B são: ");
//    Console.WriteLine(salarioA.ToString("C") + " | " + salarioB.ToString("C"));

//    //o Math.Floor(variavel) e (int)varivel retorna apenas a parte inteira sem arredondar
//    //Ambos retorna mesmo resulado
//    //Console.WriteLine("Math.Floor: " + Math.Floor(vl_horaA) + " | " + Math.Floor(vl_horaB));
//    //Console.WriteLine("int: " + (int)vl_horaA + " | " + (int)vl_horaB); //testando o (int)variavael
//    //Console.WriteLine(salarioA.ToString("F") + " | " + salarioB.ToString("F")); //testar duas casas decimais
//    //retorna true se achar a palavra 100, false se não achou
//    //Console.WriteLine("Texto digitado: " + professores + professores.Contains("100"));

//    if (salarioA > salarioB)
//    {
//    }
//    else if (salarioA == salarioB)
//    {
//        Console.WriteLine("Ambos professores tem o mesmo salário.");
//    }
//    else
//    {
//        Console.WriteLine("O professor B tem o maior salario.");
//    }
//}
// depois fazer summary



//Console.WriteLine("5 - Escrever um algoritmo para ler duas notas de um aluno e " +
//    "\n escrever na tela a palavra “Aprovado” se a média das duas notas for" +
//    "\n maior ou igual a 7,0. Caso a média seja inferior a 7,0, o programa " +
//    "\n deve ler a nota do exame e calcular a média final. Se esta média for " +
//    "\n maior ou igual a 5,0, o programa deve escrever “Aprovado”, " +
//    "\n caso contrário deve escrever “Reprovado”.");

////notas de 0 a 10
//double nota1;
//double nota2;
//double media;

//double nota_exame;
//double media_final;

//int n; // informar quantidade de teste
//Console.WriteLine("Digite a quantidade de testes: ");
//n = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Digite as duas notas: ");
//    nota1 = double.Parse(Console.ReadLine());
//    nota1 = double.Parse(Console.ReadLine());

//    media = (nota1 + nota1) / 2;

//    if (media >= 7)
//    {
//        Console.WriteLine("Aprovado");
//    }
//    else
//    {
//        Console.WriteLine("Digite a nota do exame final: ");
//        nota_exame = double.Parse(Console.ReadLine());

//        media_final = (media + nota_exame) / 2;

//        if (media_final >= 5)
//        {
//            Console.WriteLine("Aprovado");
//        }
//        else
//        {
//            Console.WriteLine("Reprovado");
//        }
//    }
//}

//Console.WriteLine("6 - Faça um programa em C# e no Visual Studio para receber o nome" +
//    "\n (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa." +
//    "\n O programa deve calcular o Indice de Massa Corpórea(IMC), exibi - lo ao usuário" +
//    "\n e informar sua situação conforme a tabela." +
//    "\n O cálculo do imc = peso / (altura * altura)" +
//    "\n IMC " +
//    "\n menor que 18                -> baixo peso" +
//    "\n maior que 18 e menor que 25 -> peso normal" +
//    "\n maior que 25 e menor que 30 -> sobrepeso" +
//    "\n maior que 30 e menor que 35 -> obesidade" +
//    "\n maior que 35                -> obesidade grau sério");

//string nome;
//string nome_maiusculo;
//double altura;
//double peso;
//double imc;

//Console.WriteLine("Digite o nome de uma pessoa, a altura e o peso: ");
//nome = Console.ReadLine();

//nome_maiusculo = nome.ToUpper();

////fazer validações
//if (nome != nome_maiusculo)
//{
//    Console.WriteLine("\n Digite o nome da pessoa em maiúsculo.");
//}
//else
//{
//    Console.WriteLine("Digite a altura e o peso");
//    altura = double.Parse(Console.ReadLine());
//    peso = double.Parse(Console.ReadLine());

//    imc = peso / (altura * altura);

//    if (imc < 18)
//    {
//        Console.WriteLine("Baixo peso, IMC = " + imc);
//    }
//    else if (imc > 18 && imc < 25)
//    {
//        Console.WriteLine("Peso normal,  IMC = " + imc);
//    }
//    else if (imc > 25 && imc < 30)
//    {
//        Console.WriteLine("Sobrepeso, IMC = " + imc);
//    }
//    else if (imc > 30 && imc < 35)
//    {
//        Console.WriteLine("Obesidade,  IMC = " + imc);
//    }
//    else if (imc > 35)
//    {
//        Console.WriteLine("Obesidade de grau sério, IMC = " + imc);
//    }

//}


/*
 * 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase. 
 */

//string frase;
//string palavra_pesquisa;
//bool retorno_pesquisa;
////string[] palavras;

//Console.WriteLine("Digite uma frase qualquer: ");
//frase = Console.ReadLine();
//Console.WriteLine("Digite uma palavra a ser pesquisada");
//palavra_pesquisa = Console.ReadLine();

//if (frase.Contains(palavra_pesquisa) == false)
//{
//    Console.WriteLine("A palavra não se encontra na frase.");
//}
//else
//{
//    Console.WriteLine("A palabra encontra-se na frase.");
//}


/*
8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas
de um funcionário.
Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas. 
 */

//int codigo;
//string nome;
//double salario_base;
//double tot_vendas;
//double salario_final;

//Console.WriteLine("Digite o codigo, o nome, o salario base e o total de vendas: ");
//codigo = int.Parse(Console.ReadLine());
//nome = Console.ReadLine();
//salario_base = double.Parse(Console.ReadLine());
//tot_vendas = double.Parse(Console.ReadLine());

//if (tot_vendas > 500 && tot_vendas < 1000)
//{
//    salario_final = salario_base * 1.05;
//    Console.WriteLine("Salário final é: " + salario_final.ToString("C"));
//}
//else if (tot_vendas > 1000 && tot_vendas < 5000)
//{
//    salario_final = salario_base * 1.07;
//    Console.WriteLine("Salário final é: " + salario_final.ToString("C"));
//}
//else if (tot_vendas > 5000)
//{
//    salario_final = salario_base * 1.10;
//    Console.WriteLine("Salário final é: " + salario_final.ToString("C"));
//}

/*
9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, 
representando a medição diária de um paciente diabético. 
Para cada valor recebido analisar e informar ao paciente o seguinte:
Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
150, avisá-lo que será necessário adicionar 2 unidades de insulina.

se  media < 80 => favor diminuir 2 unidades de insulina
se media > 150 => favor adicionar 2 unidades de insulina
*/

//double vl_glicemia1;
//double vl_glicemia2;
//double vl_glicemia3;
//double media;

//Console.WriteLine("Digite três valores de glicemia em jejum: ");
//vl_glicemia1 = double.Parse(Console.ReadLine());
//vl_glicemia2 = double.Parse(Console.ReadLine());
//vl_glicemia3 = double.Parse(Console.ReadLine());

//media = (vl_glicemia1 + vl_glicemia2 + vl_glicemia3) / 3;

//if (vl_glicemia1 < 65 || vl_glicemia2 < 65 || vl_glicemia3 < 65)
//{
//    Console.WriteLine("Risco de hipoglicemia");
//}
//else if (vl_glicemia1 > 250 || vl_glicemia2 > 250 || vl_glicemia3 > 250)
//{
//    Console.WriteLine("Risco de hiperglicemia");
//}
//else
//{
//    Console.WriteLine("Valor normal");
//}

//if (media < 80)
//{
//    Console.WriteLine("Favor diminuir 2 unidades de insulina, Média de glicemia: " + media.ToString("F"));
//}
//else if (media > 150)
//{
//    Console.WriteLine("Favor adicionar 2 unidades de insulina, Média de glicemia: " + media.ToString("C"));
//}

/*
10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
O programa deve mostrar os dados do atleta mais novo e mais alto.
 */

//string nome1;
//string nome2;
//int idade1;
//int idade2;
//double altura1;
//double altura2;

//Console.WriteLine("Digite os dados do atleta 1 - nome, idade e altura: ");
//nome1 = Console.ReadLine();
//idade1 = int.Parse(Console.ReadLine());
//altura1 = double.Parse(Console.ReadLine());

//Console.WriteLine("Digite os dados do atleta 2 - nome, idade e altura: ");
//nome2 = Console.ReadLine();
//idade2 = int.Parse(Console.ReadLine());
//altura2 = double.Parse(Console.ReadLine());

//if (idade1 < idade2 && altura1 > altura2)  //mais novo e mais alto
//{
//    Console.WriteLine("O atleta " + nome1 + " de idade de " + idade1 + " anos e altura " + altura1 + " metros");
//    Console.WriteLine("É o mais novo e mais alto");
//}
//else
//{
//    Console.WriteLine("O atleta " + nome2 + " de idade de " + idade2 + " anos e altura " + altura2 + " metros");
//    Console.WriteLine("É o mais novo e mais alto");
//}

/*
 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
O programa deve exibir se a hora digitada está ou não válida. 
Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
No final do processamento, exibir o salário total e o salário excedente do operário.

13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58
Para mulheres: (62.1 * h) - 44.7

14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
do arquivo usando este link (em minutos).

15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.
 */