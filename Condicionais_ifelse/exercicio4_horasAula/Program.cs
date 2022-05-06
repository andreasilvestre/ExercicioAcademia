Console.WriteLine("Exercício 4 - Escrever um algoritmo para ler a quantidade de horas aula " +
    "\n dadas por dois professores e o valor por hora recebido por cada um deles." +
    "\n Mostrar na tela qual dos professores tem o maior salário total.");

//leitura
/// <summary>
/// guarda quantidade de horas trabalhadas pelos professores
/// </summary>
int qt_horaA, qt_horaB;

/// <summary>
/// guarda o valor da hora de cada professor
/// </summary>
double vl_horaA, vl_horaB;

//resultado
/// <summary>
/// guarda os dados digitados dos professores
/// </summary>
string professores;

/// <summary>
/// separa os valores da string professores em trechos separados por espaço em branco
/// </summary>
string[] valor;

/// <summary>
/// guarda os salários dos professores
/// </summary>
double salarioA, salarioB;

/// <summary>
/// guarda o total de execuções que o usuário deseja realizar
/// </summary>
int n;

Console.WriteLine("Digite o total de testes a realizar: ");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("\nDigite a quantidade de horas dos dois professores" +
    "\n e o valor hora de cada um, separado por espaço:");
    professores = Console.ReadLine();

    valor = professores.Split(' ');
    qt_horaA = int.Parse(valor[0]);
    qt_horaB = int.Parse(valor[1]);
    vl_horaA = double.Parse(valor[2]);
    vl_horaB = double.Parse(valor[3]);

    Console.WriteLine(qt_horaA + " | " + qt_horaB + " | " + vl_horaA + " | " + vl_horaB); //leitura apenas

    salarioA = qt_horaA * vl_horaA;
    salarioB = qt_horaB * vl_horaB;

    Console.WriteLine("Os salários dos professores A e B são: ");
    Console.WriteLine(salarioA.ToString("C") + " | " + salarioB.ToString("C"));

    //o Math.Floor(variavel) e (int)varivel retorna apenas a parte inteira sem arredondar
    //Ambos retorna mesmo resulado
    //Console.WriteLine("Math.Floor: " + Math.Floor(vl_horaA) + " | " + Math.Floor(vl_horaB));
    //Console.WriteLine("int: " + (int)vl_horaA + " | " + (int)vl_horaB); //testando o (int)variavael
    //Console.WriteLine(salarioA.ToString("F") + " | " + salarioB.ToString("F")); //testar duas casas decimais
    //retorna true se achar a palavra 100, false se não achou
    //Console.WriteLine("Texto digitado: " + professores + professores.Contains("100"));

    if (salarioA > salarioB)
    {
        Console.WriteLine("O professor A tem o maior salario.");
    }
    else if (salarioA == salarioB)
    {
        Console.WriteLine("Ambos professores tem o mesmo salário.");
    }
    else
    {
        Console.WriteLine("O professor B tem o maior salario.");
    }
}
