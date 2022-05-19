/*
Exercício 11: Escreva um algoritmo para ler o número de eleitores de um município, 
o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um 
representa em relação ao total de eleitores.
*/

Console.WriteLine("\nExercício 11: Escreva um algoritmo para ler o número de eleitores de um município,\n " +
    "o número de votos brancos, nulos e válidos.Calcule e escreva o percentual que cada um \n" +
    "representa em relação ao total de eleitores.");

double tot_eleitores, vt_brancos, vt_nulos, vt_validos;
double porc_brancos, porc_nulos, porc_validos;

Console.Write("Digite o total de eleitores do município: ");
tot_eleitores = double.Parse (Console.ReadLine());

Console.Write("Digite o total de votos brancos: ");
vt_brancos = double.Parse (Console.ReadLine());

Console.Write("Digite o total de votos nulos: ");
vt_nulos = double.Parse (Console.ReadLine());

Console.Write("Digite o total de votos válidos: ");
vt_validos = double.Parse (Console.ReadLine());

porc_brancos = (vt_brancos * 100) / tot_eleitores;
porc_nulos = (vt_nulos * 100) / tot_eleitores; 
porc_validos = (vt_validos * 100) / tot_eleitores;

Console.WriteLine("O resumo da eleição ficou assim:");
Console.WriteLine("Votos brancos: " + porc_brancos + "%");
Console.WriteLine("Votos nulos: " + porc_nulos + "%");
Console.WriteLine("Votos válidos: " + porc_validos + "%");

