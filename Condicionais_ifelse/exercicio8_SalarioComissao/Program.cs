Console.WriteLine("Exercício 8 - Faça um programa no VS que receba o código, nome," +
    "\n salário base e o total de vendas de um funcionário." +
"\n Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas." +
"\n Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas." +
"\n E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do " +
"\n total de vendas.");

/// <summary>
/// guarda o código do funcionário
/// </summary>
int codigo;

/// <summary>
/// guarda o nome do funcionário
/// </summary>
string nome;

/// <summary>
/// guarda o salario base do funcionário
/// </summary>
double salario_base;

/// <summary>
/// guarda o total de vendas em reais feito pelo funcionário
/// </summary>
double tot_vendas;

/// <summary>
/// guarda o salário final do funcionário
/// </summary>
double salario_final;

Console.WriteLine("Digite o codigo, o nome, o salario base e o total de vendas: ");
codigo = int.Parse(Console.ReadLine());
nome = Console.ReadLine();
salario_base = double.Parse(Console.ReadLine());
tot_vendas = double.Parse(Console.ReadLine());

if (tot_vendas > 500 && tot_vendas < 1000)
{
    salario_final = salario_base + (tot_vendas * 0.05); //5%
    Console.WriteLine("Salário final é: " + salario_final.ToString("C"));
}
else if (tot_vendas > 1000 && tot_vendas < 5000)
{
    salario_final = salario_base + (tot_vendas * 0.07); //7%
    Console.WriteLine("Salário final é: " + salario_final.ToString("C"));
}
else if (tot_vendas > 5000)
{
    salario_final = salario_base + (tot_vendas * 0.10); //10%
    Console.WriteLine("Salário final é: " + salario_final.ToString("C"));
}