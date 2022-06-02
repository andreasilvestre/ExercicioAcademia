Console.WriteLine(" 14 - Faça um programa que peça o tamanho de um arquivo para download" +
    "\n (em MB) e a velocidade de um link de Internet (em Mbps). Em seguida," +
    "\n calcule e informe o tempo aproximado de download do arquivo usando este link (em minutos).");

/// <summary>
/// armazena o tamanho do arquivo a ser baixado
/// </summary>
int tamanho_arquivo;

/// <summary>
/// armazena a velocidade da internet para o link informado
/// </summary>
int veloc_internet;

/// <summary>
/// guarda quanto tempo aproximado levará para o arquivo ser baixado
/// </summary>
double tempo_gasto;

Console.WriteLine("Digite o tamanho do arquivo e a velocidade da internet: ");
tamanho_arquivo = int.Parse(Console.ReadLine());
veloc_internet = int.Parse(Console.ReadLine());

tempo_gasto = tamanho_arquivo / veloc_internet;
tempo_gasto = tempo_gasto / 60;

Console.WriteLine(Math.Ceiling(tempo_gasto) + " minutos");
