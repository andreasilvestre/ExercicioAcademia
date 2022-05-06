Console.WriteLine("12 - Elabore um programa em VS que leia as variáveis " +
    "\n 'codigo' e 'numeroHoras', respectivamente código e " +
    "\n número de horas trabalhadas de um operário.Na sequência, " +
    "\n calcule o salário sabendo - se que ele ganha " +
    "\n R$ 10,00 por hora. Quando o número de horas exceder " +
    "\n a 50 calcule o excesso de pagamento " +
    "\n armazenando - o na variável 'extra'', caso contrário zerar " +
    "\n tal variável. A hora excedente de trabalho vale R$ 20, 00. " +
    "\n No final do processamento, exibir o salário total " +
    "\n e o salário excedente do operário. ");

/// <summary>
/// recebe o código do operário
/// </summary>
int codigo;

/// <summary>
/// recebe a quantidade horas trabalhadas pelo operário
/// </summary>
int qt_hora;  // R$10,00/hora

/// <summary>
/// guarda o valor do salário calculado
/// </summary>
double salario;

/// <summary>
/// recebe a quantidade horas extras trabalhadas
/// </summary>
double qt_hora_extra;  // qt_hora > 50  - R$20,00

/// <summary>
/// guarda o valor total do salário, incluindo o valor das horas extras
/// </summary>
double salario_total;

/// <summary>
/// guarda o valor calculado de horas extras
/// </summary>
double vl_extra;

Console.WriteLine("Digite o código do operário e o numero de horas trabalhadas: ");
codigo = int.Parse(Console.ReadLine());
qt_hora = int.Parse(Console.ReadLine());

if (qt_hora <= 50)
{
    salario = qt_hora * 10;
    qt_hora_extra = 0;
    Console.WriteLine("O salário do operário é: " + salario.ToString("C"));
}
else
{
    //70 horas = 70-50 = 20
    qt_hora_extra = qt_hora - 50;
    salario = 50 * 10;
    vl_extra = qt_hora_extra * 20;
    salario_total = salario + vl_extra;
    Console.WriteLine(" O salário total é " + salario_total.ToString("C"));
    Console.WriteLine(" O salário excedente é " + vl_extra.ToString("C"));
}
