/*

Exercício 12: Um motorista de taxi deseja calcular o rendimento de seu carro na praça. 
Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia,
o número de litros de combustível gasto e o valor total (R$) recebido dos passageiros. 
Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

Média do consumo = Total quilometragem/ quantidade de combustível gasto

Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
 */

Console.WriteLine("Exercício 12: Um motorista de taxi deseja calcular o rendimento de seu carro na praça.\n" +
    " Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a \n" +
    "marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final\n" +
    " do dia, o número de litros de combustível gasto e o valor total (R$) recebido\n" +
    "dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.\n" +
    "Fórmulas: \n" +
    "Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia \n" +
    "Média do consumo = Total quilometragem/ quantidade de combustível gasto \n" +
    "Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)");

    int km_inicio, km_final, km_total, tot_combustivel;
    //double vl_combustivel = 6.90;
    double tot_recebido;
    double media_consumo, lucro_dia;

// leitura dos dados que serão  informados
    Console.Write("Informe o Km inicial do dia: ");
    km_inicio =int.Parse(Console.ReadLine());

    Console.Write("Informe o Km final do dia: ");
    km_final = int.Parse(Console.ReadLine());

    Console.Write("Informe o total de combustível gasto no dia (em litros): ");
    tot_combustivel = int.Parse(Console.ReadLine());

    Console.Write("Informe o valor (R$) recebido no dia: ");
    tot_recebido = double.Parse(Console.ReadLine());

    km_total = km_final - km_inicio; // Total de kilometragem do dia
    media_consumo = km_total / tot_combustivel;
    lucro_dia = tot_recebido - (tot_combustivel * 6.90);

    Console.WriteLine("A média de consumo de combustível gasto no dia foi de " + media_consumo + " Km/L");
    Console.WriteLine("O lucro dia foi de " + lucro_dia + " reais");
