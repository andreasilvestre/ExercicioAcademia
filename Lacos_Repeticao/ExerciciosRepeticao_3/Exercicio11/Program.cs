Console.WriteLine("EXERCICIO11 - usar List<double> LISTA" +
"\n PENDENCIA - VER LISTA COMPOSTA POR MAIS DE UM TIPO. EX NOME E NOTA DOS ALUNOS" +
"\n 11: Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, " +
"\n a média aritmética da turma e a quantidade de alunos da turma. Usar como flag a nota 12.");


/// <summary>
/// guarda o nome de cada aluno informado
/// </summary>
List<string> listaAluno = new List<string>(); // naõ está servindo pra nada por enquanto

/// <summary>
/// guarda a relação de notas dos respectivos alunos informados
/// </summary>
List<double> listaNota = new List<double>(); //toda vez que usar new colocar parenteses () no final

/// <summary>
/// guarda o total de alunos da turma analisada
/// </summary>
int totalAlunos;

/// <summary>
/// guarda a somatoria das notas e depois a média final da turma
/// </summary>
double mediaNota = 0;

Console.WriteLine("Digite a quantidade de Alunos: ");
totalAlunos = int.Parse(Console.ReadLine());

for (int i = 0; i < totalAlunos; i++)
{
    Console.WriteLine("Digite o nome do aluno: ");
    listaAluno.Add(Console.ReadLine());

    Console.WriteLine("Digite a nota do aluno " + listaAluno[i] + " (nota de 0 a 12)");
    listaNota.Add(double.Parse(Console.ReadLine()));

    mediaNota = mediaNota + listaNota[i];
}

mediaNota = mediaNota / listaNota.Count;
listaNota.Sort();// ordena a lista em ordem crescente, de 0 a totalAlunos

Console.WriteLine("Nota mais alta: " + listaNota[listaNota.Count - 1]);
Console.WriteLine("Nota mais baixa: " + listaNota[0]);
Console.WriteLine("Total de alunos: " + listaNota.Count);
Console.WriteLine("A média aritmética da turma é: " + mediaNota.ToString("F"));