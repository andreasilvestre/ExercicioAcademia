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


Console.WriteLine("4 - Escrever um algoritmo para ler a quantidade de horas aula " +
    "\n dadas por dois professores e o valor por hora recebido por cada um deles." +
    "\n  Mostrar na tela qual dos professores tem o maior salário total.");

int qt_horaA, qt_horaB;
double vl_horaA, vl_horaB;



Console.WriteLine("5 - Escrever um algoritmo para ler duas notas de um aluno e " +
    "\n escrever na tela a palavra “Aprovado” se a média das duas notas for" +
    "\n maior ou igual a 7,0. Caso a média seja inferior a 7,0, o programa " +
    "\n deve ler a nota do exame e calcular a média final. Se esta média for " +
    "\n maior ou igual a 5,0, o programa deve escrever “Aprovado”, " +
    "\n caso contrário deve escrever “Reprovado”.");