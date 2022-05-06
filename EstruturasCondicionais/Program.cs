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


//Console.WriteLine("Exercício 1 - Faça um algoritmo para calcular e mostrar a área de um " +
//    "\n triângulo a partir dos valores da base e da altura lidos pelo teclado: " +
//    "\n Área do triangulo = (base * altura) / 2; " +
//    "\n Teste se a base ou a altura digitada não foi igual a zero. ");

///// <summary>
///// guarda o valor da base de um triangulo
///// </summary>
//double base_tri;

///// <summary>
///// guarda a altura de um triangulo
///// </summary>
//double altura;

///// <summary>
///// guarda o calculo da área de um triangulo
///// </summary>
//double area;

//Console.WriteLine("Digite a base e a altura: ");
//base_tri = double.Parse(Console.ReadLine());
//altura = double.Parse(Console.ReadLine());

//if (base_tri == 0 || altura == 0)
//{
//    Console.WriteLine("Digite valores diferente de zero.");
//}
//else
//{
//    area = (base_tri * altura) / 2;
//    Console.WriteLine("A área do triângulo é: " + area);
//}




//Console.WriteLine("Exercício 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.");

///// <summary>
///// guarda o valor de um número qualquer digitado pelo usuário
///// </summary>
//double numero;

//Console.WriteLine("Digite um número qualquer: ");
//numero = double.Parse(Console.ReadLine());

//if (numero % 2 == 0) Console.WriteLine("Número par.");
//else Console.WriteLine("Número ímpar.");




//Console.WriteLine("Exercício 3 - Escrever um algoritmo para ler quatro valores inteiros," +
//    "\n calcular a sua média, e escrever na tela os que são superiores à média.");

///// <summary>
///// guarda quatro números inteiros digitado pelo usuário
///// </summary>
//double num1, num2, num3, num4;

///// <summary>
///// guarda o valor da media calculada
///// </summary>
//double media;

//Console.WriteLine("Digite 4 números inteiros: ");
//num1 = double.Parse(Console.ReadLine());
//num2 = double.Parse(Console.ReadLine());
//num3 = double.Parse(Console.ReadLine());
//num4 = double.Parse(Console.ReadLine());

//media = (num1 + num2 + num3 + num4) / 4;
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






//Console.WriteLine("Exercício 4 - Escrever um algoritmo para ler a quantidade de horas aula " +
//    "\n dadas por dois professores e o valor por hora recebido por cada um deles." +
//    "\n Mostrar na tela qual dos professores tem o maior salário total.");

////leitura
///// <summary>
///// guarda quantidade de horas trabalhadas pelos professores
///// </summary>
//int qt_horaA, qt_horaB;

///// <summary>
///// guarda o valor da hora de cada professor
///// </summary>
//double vl_horaA, vl_horaB;

////resultado
///// <summary>
///// guarda os dados digitados dos professores
///// </summary>
//string professores;

///// <summary>
///// separa os valores da string professores em trechos separados por espaço em branco
///// </summary>
//string[] valor;

///// <summary>
///// guarda os salários dos professores
///// </summary>
//double salarioA, salarioB;

///// <summary>
///// guarda o total de execuções que o usuário deseja realizar
///// </summary>
//int n;

//Console.WriteLine("Digite o total de testes a realizar: ");
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
//        Console.WriteLine("O professor A tem o maior salario.");
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






//Console.WriteLine("Exercício 5 - Escrever um algoritmo para ler duas notas de um aluno e " +
//    "\n escrever na tela a palavra “Aprovado” se a média das duas notas for" +
//    "\n maior ou igual a 7,0. Caso a média seja inferior a 7,0, o programa " +
//    "\n deve ler a nota do exame e calcular a média final. Se esta média for " +
//    "\n maior ou igual a 5,0, o programa deve escrever “Aprovado”, " +
//    "\n caso contrário deve escrever “Reprovado”.");

////notas válidas de 0 a 10

///// <summary>
///// guarda a nota 1 de um aluno
///// </summary>
//double nota1;

///// <summary>
///// guarda a nota 2 de um aluno
///// </summary>
//double nota2;

///// <summary>
///// guarda a media das duas notas informadas
///// </summary>
//double media;

///// <summary>
///// guarda a nota do exame de recuperação
///// </summary>
//double nota_exame;

///// <summary>
///// guarda a média final, calculada através da média de notas e nota do exame de recuperação
///// </summary>
//double media_final;

///// <summary>
///// guarda a quantidade de testes a ser realizado pelo usuário
///// </summary>
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





//Console.WriteLine("Exercício 6 - Faça um programa em C# e no Visual Studio para receber o nome" +
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

///// <summary>
///// receb o nome de uma pessoa
///// </summary>
//string nome;

///// <summary>
///// guarda o nome de uma pessoa em maiusculo
///// </summary>
//string nome_maiusculo;

///// <summary>
///// guarda  a altura de uma pessoa
///// </summary>
//double altura;

///// <summary>
///// guarda o peso de uma pessoa
///// </summary>
//double peso;

///// <summary>
///// guarda o índice de massa corporal IMC de uma pessoa
///// </summary>
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


//Console.WriteLine("Exercício 7 - Faça um programa em C# e no VS para receber uma frase qualquer" +
//    "\n e uma palavra de pesquisa. O programa deve avaliar se a palavra aparece na frase," +
//    "\n informando o usuário via mensagem, como por exemplo, A palavra" +
//    "\n encontra-se na frase ou A palavra não se encontra na frase."); 

///// <summary>
///// guarda uma frase digitada pelo usuário
///// </summary>
//string frase;

///// <summary>
///// guarda a palavra que o usuário quer pesquisar na frase
///// </summary>
//string palavra_pesquisa;

////bool retorno_pesquisa;

//Console.WriteLine("Digite uma frase qualquer: ");
//frase = Console.ReadLine();
//frase = frase.ToUpper();

//Console.WriteLine("Digite uma palavra a ser pesquisada");
//palavra_pesquisa = Console.ReadLine();
//palavra_pesquisa = palavra_pesquisa.ToUpper();


//if (frase.Contains(palavra_pesquisa) == false)
//{
//    Console.WriteLine("A palavra não se encontra na frase.");
//}
//else
//{
//    Console.WriteLine("A palabra encontra-se na frase.");
//}





//Console.WriteLine("Exercício 8 - Faça um programa no VS que receba o código, nome," +
//    "\n salário base e o total de vendas de um funcionário." +
//"\n Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas." +
//"\n Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas." +
//"\n E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do " +
//"\n total de vendas."); 

///// <summary>
///// guarda o código do funcionário
///// </summary>
//int codigo;

///// <summary>
///// guarda o nome do funcionário
///// </summary>
//string nome;

///// <summary>
///// guarda o salario base do funcionário
///// </summary>
//double salario_base;

///// <summary>
///// guarda o total de vendas em reais feito pelo funcionário
///// </summary>
//double tot_vendas;

///// <summary>
///// guarda o salário final do funcionário
///// </summary>
//double salario_final;

//Console.WriteLine("Digite o codigo, o nome, o salario base e o total de vendas: ");
//codigo = int.Parse(Console.ReadLine());
//nome = Console.ReadLine();
//salario_base = double.Parse(Console.ReadLine());
//tot_vendas = double.Parse(Console.ReadLine());

//if (tot_vendas > 500 && tot_vendas < 1000) 
//{
//    salario_final = salario_base + (tot_vendas * 0.05); //5%
//    Console.WriteLine("Salário final é: " + salario_final.ToString("C"));
//}
//else if (tot_vendas > 1000 && tot_vendas < 5000)
//{
//    salario_final = salario_base + (tot_vendas * 0.07); //7%
//    Console.WriteLine("Salário final é: " + salario_final.ToString("C"));
//}
//else if (tot_vendas > 5000)
//{
//    salario_final = salario_base + (tot_vendas * 0.10); //10%
//    Console.WriteLine("Salário final é: " + salario_final.ToString("C"));
//}





//Console.WriteLine("\n " +
//"\n Exercício 9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, " +
//"\n representando a medição diária de um paciente diabético. " +
//"\n Para cada valor recebido analisar e informar ao paciente o seguinte:" +
//"\n Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia" +
//"\n Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia." +
//"\n " +
//"\n Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for " +
//"\n menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que" +
//"\n 150, avisá-lo que será necessário adicionar 2 unidades de insulina." +
//"\n " +
//"\n se  media < 80 => favor diminuir 2 unidades de insulina" +
//"\n se media > 150 => favor adicionar 2 unidades de insulina");

////tenho dúvida/duvida se pode ser assim o summary - tres variaveis juntas
///// <summary> 
///// guarda os valores diários de glicemia
///// </summary>
//double vl_glicemia1, vl_glicemia2, vl_glicemia3;

///// <summary>
///// guarda a média de três valores de glicemia
///// </summary>
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
//    Console.WriteLine("Favor adicionar 2 unidades de insulina, Média de glicemia: " + media.ToString("F"));
//}



//Console.WriteLine("\n" +
//"\n Exercício 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura)." +
//"\n O programa deve mostrar os dados do atleta mais novo e mais alto.");

///// <summary>
///// receb o nome do atleta 1
///// </summary>
//string nome1;

///// <summary>
///// receb o nome do atleta 2
///// </summary>
//string nome2;

///// <summary>
///// guarda a idade do atleta 1
///// </summary>
//int idade1;

///// <summary>
///// guarda a idade do atleta2
///// </summary>
//int idade2;

///// <summary>
///// guarda a altura do atleta 1
///// </summary>
//double altura1;

///// <summary>
///// guarda a idade do atleta 2
///// </summary>
//double altura2;

//Console.WriteLine("Digite os dados do atleta 1 - nome, idade e altura: ");
//nome1 = Console.ReadLine();
//idade1 = int.Parse(Console.ReadLine());
//altura1 = double.Parse(Console.ReadLine());

//Console.WriteLine("Digite os dados do atleta 2 - nome, idade e altura: ");
//nome2 = Console.ReadLine();
//idade2 = int.Parse(Console.ReadLine());
//altura2 = double.Parse(Console.ReadLine());

//if (idade1 < idade2 && altura1 > altura2)  //mais novo e mais alto o mesmo atleta
//{
//    Console.WriteLine("O atleta " + nome1 + " de idade de " + idade1 + " anos e altura " + altura1 + " metros");
//    Console.WriteLine("É o mais novo e mais alto");
//}
//else if (idade2 < idade1 && altura2 > altura1)  // mais novo e mais alto o mesmo atleta
//{
//    Console.WriteLine("O atleta " + nome2 + " de idade de " + idade2 + " anos e altura " + altura2 + " metros");
//    Console.WriteLine("É o mais novo e mais alto");
//}
//else
//{
//    Console.WriteLine("Não existe um mesmo atleta mais novo e mais alto");
//}





//Console.WriteLine(" 11 - Faça um programa no VS que receba uma hora, dividida em 2" +
//    "\n variáveis (uma para hora e outra para minutos)." +
//    "\n O programa deve exibir se a hora digitada está ou não válida." +
//    "\n Lembre que usaremos o padrão de hora com 24h, de 0 a 23.");

////10:16

///// <summary>
///// recebe hora com valor de 0 a 23.
///// </summary>
//int hora;

///// <summary>
///// recebe minuto com valor 1 a 59 minutos
///// </summary>
//int minuto;

///// <summary>
///// recebe hora inteira digitada pelo usuário
///// </summary>
//string hora_digitada;

///// <summary>
///// separa a hora digitada em hora e minuto
///// </summary>
//string[] split; //10:16


//Console.WriteLine("Digite uma hora no formato HH:MM: ");
//hora_digitada = Console.ReadLine();

//split = hora_digitada.Split(':'); // posição 0 e 1
//hora = int.Parse(split[0]);
//minuto = int.Parse(split[1]);

//Console.WriteLine("Hora splitada: " + split[0] + ":" + split[1]);

//if (hora >=0 && hora <= 23)
//{
//    if (minuto >= 1 && minuto <= 59)
//    {
//        Console.WriteLine("Hora válida.");
//    }
//    else
//    {
//        Console.WriteLine("Minuto inválido.");
//    }
//}
//else
//{
//    Console.WriteLine("Hora inválida.");
//}

//Console.WriteLine("12 - Elabore um programa em VS que leia as variáveis " +
//    "\n 'codigo' e 'numeroHoras', respectivamente código e " +
//    "\n número de horas trabalhadas de um operário.Na sequência, " +
//    "\n calcule o salário sabendo - se que ele ganha " +
//    "\n R$ 10,00 por hora. Quando o número de horas exceder " +
//    "\n a 50 calcule o excesso de pagamento " +
//    "\n armazenando - o na variável 'extra'', caso contrário zerar " +
//    "\n tal variável. A hora excedente de trabalho vale R$ 20, 00. " +
//    "\n No final do processamento, exibir o salário total " +
//    "\n e o salário excedente do operário. ");

///// <summary>
///// recebe o código do operário
///// </summary>
//int codigo;
///// <summary>
///// recebe a quantidade horas trabalhadas pelo operário
///// </summary>
//int qt_hora;  // R$10,00/hora

///// <summary>
///// guarda o valor do salário calculado
///// </summary>
//double salario;

///// <summary>
///// recebe a quantidade horas extras trabalhadas
///// </summary>
//double qt_hora_extra;  // qt_hora > 50  - R$20,00

///// <summary>
///// guarda o valor total do salário, incluindo o valor das horas extras
///// </summary>
//double salario_total;

///// <summary>
///// guarda o valor calculado de horas extras
///// </summary>
//double vl_extra;

//Console.WriteLine("Digite o código do operário e o numero de horas trabalhadas: ");
//codigo = int.Parse(Console.ReadLine()); 
//qt_hora = int.Parse(Console.ReadLine());

//if (qt_hora <= 50)
//{
//    salario = qt_hora * 10;
//    qt_hora_extra = 0;
//    Console.WriteLine("O salário do operário é: " + salario.ToString("C"));
//}
//else
//{
//    //70 horas = 70-50 = 20
//    qt_hora_extra = qt_hora - 50;
//    salario = 50 * 10;
//    vl_extra = qt_hora_extra * 20;
//    salario_total = salario + vl_extra;
//    Console.WriteLine(" O salário total é " + salario_total.ToString("C"));
//    Console.WriteLine(" O salário excedente é " + vl_extra.ToString("C"));
//}


//Console.WriteLine(" 13 - Tendo como dado de entrada a altura (h) de uma pessoa," +
//"\n construa um programa no VS que calcule seu peso ideal, utilizando as seguintes fórmulas:" +
//"\n Para homens: (72.7 * h) - 58" + // subtrai 58
//"\n Para mulheres: (62.1 * h) - 44.7"); // subtrai 44,70

///// <summary>
///// recebe a altura de uma pessoa qualquer
///// </summary>
//double altura;

///// <summary>
///// recebe o sexo da pessoa se é feminino ou masculino
///// </summary>
//string sexo;

///// <summary>
///// guarda o peso ideal das mulheres e dos homens
///// </summary>
//double peso_ideal;

//Console.WriteLine("Digite a altura e o sexo ( feminino ou masculino ) de uma pessoa: ");
//altura = double.Parse(Console.ReadLine());
//sexo = Console.ReadLine();

//if (sexo.Contains("feminino") == true)
//{
//    peso_ideal = (62.1 * altura) - 44.7;
//    Console.WriteLine("O peso ideal é: " + peso_ideal.ToString("F") + " Kg");
//}
//else if (sexo.Contains("masculino") == true)
//{
//    peso_ideal = (72.7 * altura) - 58;
//    Console.WriteLine("O peso ideal é: " + peso_ideal.ToString("F") + " Kg");
//}
//else
//{
//    Console.WriteLine("Sexo inválido.");
//}

//Console.WriteLine(" 14 - Faça um programa que peça o tamanho de um arquivo para download" +
//    "\n (em MB) e a velocidade de um link de Internet (em Mbps). Em seguida," +
//    "\n calcule e informe o tempo aproximado de download do arquivo usando este link (em minutos).");

///// <summary>
///// armazena o tamanho do arquivo a ser baixado
///// </summary>
//int tamanho_arquivo;

///// <summary>
///// armazena a velocidade da internet para o link informado
///// </summary>
//int veloc_internet;

///// <summary>
///// guarda quanto tempo aproximado levará para o arquivo ser baixado
///// </summary>
//double tempo_gasto;

//Console.WriteLine("Digite o tamanho do arquivo e a velocidade da internet: ");
//tamanho_arquivo = int.Parse(Console.ReadLine());
//veloc_internet = int.Parse(Console.ReadLine());

//tempo_gasto = tamanho_arquivo / veloc_internet;
//tempo_gasto = tempo_gasto / 60;

//Console.WriteLine(Math.Ceiling(tempo_gasto) + " minutos");


//RESOLUÇÃO DO PROFESSOR ALEXANDRE
//Console.WriteLine(" 15 - Faça um programa para uma loja de tintas. O programa " +
//    "\n deverá pedir o tamanho em metros quadrados da área a ser pintada." +
//    "\n Considere que a cobertura da tinta é de 1 litro para cada 3 metros " +
//    "\n quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00." +
//    "\n Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.");

///// <summary>
///// recebe o tamanho da área a ser pintada em metros quadrados
///// </summary>
//float tamanhoArea;      //variavel de entrada

///// <summary>
///// armazena a quantidade de tinta a usar em litros
///// </summary>
//float quantidadeTinta;

///// <summary>
///// armazena a quantidade de tinta a usar em latas de 18 litros
///// </summary>
//int quantidadeLatas;

///// <summary>
///// guarda o valor da compra de tintas
///// </summary>
//float valorCompra;

//Console.Write("Informe a área a ser pintada (metros quadrados): ");
//tamanhoArea = float.Parse(Console.ReadLine());

//quantidadeTinta = tamanhoArea / 3; //cobertura da tinta é de 1 litro por 3 metros quadrados
//quantidadeLatas = (int)Math.Ceiling(quantidadeTinta / 18); // tinta é vendida em latas de 18 litros
//valorCompra = quantidadeLatas * 80; //a lata custa R$ 80,00

//Console.WriteLine("A quantidade de tinta para cobrir a área é de: " + quantidadeTinta + " litros");
//Console.WriteLine("A quantidade de latas de 18 litros para cobrir a área é de: " + quantidadeLatas);
//Console.WriteLine("O valor total a ser gasto é de: R$ " + valorCompra);