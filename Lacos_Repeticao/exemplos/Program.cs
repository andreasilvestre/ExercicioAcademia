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

int x, taboada;

Console.WriteLine("Digite um número qualquer: ");
x = int.Parse(Console.ReadLine());

for (int i = 1; i<= 10; i++)
{
    taboada = x * i;
    Console.WriteLine($"Taboada: {x} x {i} = {taboada}");
}