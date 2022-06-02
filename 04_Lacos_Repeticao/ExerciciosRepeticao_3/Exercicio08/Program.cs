Console.WriteLine("EXERCICIO08 - ACHAR NUMERO INTEIRO" +
"\n 8. Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro, solicite-o até" +
"\n que seja. após, informe se ele é par ou impar." +
"\n Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.\n");

//num_inteiro = (int)numero;  //pega somente a parte inteira

/// <summary>
/// guarda o número digitado 
/// </summary>
string numero;

/// <summary>
///  Guarda o numero inteiro digitado. Se não for inteiro, guarda 0. 
/// </summary>
int num_inteiro;

/// <summary>
/// Guarda True ou False. Se número digitado é imteiro, guarda True, senão False.
/// </summary>
bool eh_inteiro = false;

/// <summary>
/// guarda os caracteres s/n - repetir sim, repetir não.
/// </summary>
char repetir;

do
{
    do
    {
        Console.WriteLine("Digite um número inteiro: ");
        numero = Console.ReadLine();
        eh_inteiro = int.TryParse(numero, out num_inteiro);

    } while (eh_inteiro == false);

    if (num_inteiro % 2 == 0)
    {
        Console.WriteLine("O número informado é Par.");
    }
    else
    {
        Console.WriteLine("O número informado é Ímpar.");
    }

    Console.WriteLine("Deseja repetir a análise do número? (s/n)");
    repetir = char.Parse(Console.ReadLine());
    repetir = char.ToUpper(repetir);
    

} while (repetir == 'S');

//verificação de dados:
Console.WriteLine("Mostra número convertido em inteiro: " + num_inteiro + " É inteiro? " + eh_inteiro);