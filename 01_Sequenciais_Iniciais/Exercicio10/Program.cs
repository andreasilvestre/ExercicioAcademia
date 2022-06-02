    /*
    Exercício 10: Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
    para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
    realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
    notas de menor valor fossem distribuídas em número mínimo possível. 
    Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, 
    três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
    Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
    de acordo com o critério da “distribuição ótima”.
     */

Console.WriteLine("\nExercício 10: Um programa para gerenciar os saques de um caixa eletrônico \n" +
    " deve possuir algum mecanismo para decidir o número de notas de cada valor que deve ser \n " +
    "disponibilizado para o cliente que realizou o saque.Um possível critério seria o da \n " +
    "“distribuição ótima” no sentido de que as notas de menor valor fossem distribuídas \n" +
    " em número mínimo possível. Por exemplo, se a quantia solicitada fosse R$ 87, 00 o \n" +
    "programa deveria indicar uma nota de R$ 50, 00,três notas de R$ 10, 00, uma nota de \n" +
    " R$ 5, 00 e duas notas de R$ 1, 00. Escreva um programa que receba o valor da quantia \n" +
    " solicitada e retorne a distribuição das notas de acordo com o critério da “distribuição ótima”.\n");

int vl_saque, qt_nota, resto, nota;


Console.Write("Digite o valor do saque: ");
vl_saque = int.Parse(Console.ReadLine());

nota = 200;
qt_nota = vl_saque / nota;
resto = vl_saque % nota;
Console.WriteLine("Total de notas de 200 é: " + qt_nota);

nota = 100;
vl_saque = resto;
qt_nota = vl_saque / nota;
resto = vl_saque % nota;
Console.WriteLine("Total de notas de 100 é: " + qt_nota);

nota = 50;
vl_saque = resto;
qt_nota = vl_saque / nota;
resto = vl_saque % nota;
Console.WriteLine("Total de notas de 50 é: " + qt_nota);

nota = 20;
vl_saque = resto;
qt_nota = vl_saque / nota;
resto = vl_saque % nota;
Console.WriteLine("Total de notas de 20 é: " + qt_nota);

nota = 10;
vl_saque = resto;
qt_nota = vl_saque / nota;
resto = vl_saque % nota;
Console.WriteLine("Total de notas de 10 é: " + qt_nota);

nota = 5;
vl_saque = resto;
qt_nota = vl_saque / nota;
resto = vl_saque % nota;
Console.WriteLine("Total de notas de 5 é: " + qt_nota);

nota = 2;
vl_saque = resto;
qt_nota = vl_saque / nota;
resto = vl_saque % nota;
Console.WriteLine("Total de notas de 2 é: " + qt_nota);



















