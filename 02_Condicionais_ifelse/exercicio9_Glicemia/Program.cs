Console.WriteLine("\n " +
"\n Exercício 9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, " +
"\n representando a medição diária de um paciente diabético. " +
"\n Para cada valor recebido analisar e informar ao paciente o seguinte:" +
"\n Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia" +
"\n Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia." +
"\n " +
"\n Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for " +
"\n menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que" +
"\n 150, avisá-lo que será necessário adicionar 2 unidades de insulina." +
"\n " +
"\n se  media < 80 => favor diminuir 2 unidades de insulina" +
"\n se media > 150 => favor adicionar 2 unidades de insulina");

//tenho dúvida/duvida se pode ser assim o summary - tres variaveis juntas
/// <summary> 
/// guarda os valores diários de glicemia
/// </summary>
double vl_glicemia1, vl_glicemia2, vl_glicemia3;

/// <summary>
/// guarda a média de três valores de glicemia
/// </summary>
double media;

Console.WriteLine("Digite três valores de glicemia em jejum: ");
vl_glicemia1 = double.Parse(Console.ReadLine());
vl_glicemia2 = double.Parse(Console.ReadLine());
vl_glicemia3 = double.Parse(Console.ReadLine());

media = (vl_glicemia1 + vl_glicemia2 + vl_glicemia3) / 3;

if (vl_glicemia1 < 65 || vl_glicemia2 < 65 || vl_glicemia3 < 65)
{
    Console.WriteLine("Risco de hipoglicemia");
}
else if (vl_glicemia1 > 250 || vl_glicemia2 > 250 || vl_glicemia3 > 250)
{
    Console.WriteLine("Risco de hiperglicemia");
}
else
{
    Console.WriteLine("Valor normal");
}

if (media < 80)
{
    Console.WriteLine("Favor diminuir 2 unidades de insulina, Média de glicemia: " + media.ToString("F"));
}
else if (media > 150)
{
    Console.WriteLine("Favor adicionar 2 unidades de insulina, Média de glicemia: " + media.ToString("F"));
}
