Console.WriteLine(" 11 - Faça um programa no VS que receba uma hora, dividida em 2" +
    "\n variáveis (uma para hora e outra para minutos)." +
    "\n O programa deve exibir se a hora digitada está ou não válida." +
    "\n Lembre que usaremos o padrão de hora com 24h, de 0 a 23.");

//10:16

/// <summary>
/// recebe hora com valor de 0 a 23.
/// </summary>
int hora;

/// <summary>
/// recebe minuto com valor 1 a 59 minutos
/// </summary>
int minuto;

/// <summary>
/// recebe hora inteira digitada pelo usuário
/// </summary>
string hora_digitada;

/// <summary>
/// separa a hora digitada em hora e minuto
/// </summary>
string[] split; //10:16


Console.WriteLine("Digite uma hora no formato HH:MM: ");
hora_digitada = Console.ReadLine();

split = hora_digitada.Split(':'); // posição 0 e 1
hora = int.Parse(split[0]);
minuto = int.Parse(split[1]);

Console.WriteLine("Hora splitada: " + split[0] + ":" + split[1]);

if (hora >= 0 && hora <= 23)
{
    if (minuto >= 1 && minuto <= 59)
    {
        Console.WriteLine("Hora válida.");
    }
    else
    {
        Console.WriteLine("Minuto inválido.");
    }
}
else
{
    Console.WriteLine("Hora inválida.");
}