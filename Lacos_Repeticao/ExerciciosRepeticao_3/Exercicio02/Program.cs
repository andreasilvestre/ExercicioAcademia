Console.WriteLine("Exercicio02" +
"\n 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja " +
"\n informar um outro número. Caso positivo, o programa em VS deve ser repetido." +
"\n " +
"\n Exemplo: " +
"\n Digite um número inteiro positivo: 8" +
"\n Numero digitado: 8" +
"\n Números inteiros pares entre 1 e 8: 2, 4, 6." +
"\n " +
"\n Deseja informar outro número (s/n)? S" +
"\n " +
"\n Digite um número inteiro positivo: 12" +
"\n Numero digitado: 20" +
"\n Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10." +
"\n " +
"\n Deseja informar outro número (s/n)? N  \n");


/// <summary>
/// guarda o numero digitado pelo usuário
/// </summary>
int numero; //inteiro > 0
            //numeros pares de 1 a numero

//guarda se sim ou não s/n para executar o exercicio 01 novamente
char outroNumero; // s/n

outroNumero = 'S';

do
{

    Console.WriteLine("Digite um número inteiro e positivo: ");
    numero = int.Parse(Console.ReadLine());

    while (numero <= 0)
    {
        Console.WriteLine("Número inválido, digite um número inteiro e positivo: ");
        numero = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Os números pares entre 1 e " + numero + " é: ");
    for (int i = 2; i <= numero; i = i + 2)

    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Deseja informar outro número (s/n)?");
    outroNumero = char.Parse(Console.ReadLine());
    
    

} while (outroNumero == 'S' || outroNumero == 's');