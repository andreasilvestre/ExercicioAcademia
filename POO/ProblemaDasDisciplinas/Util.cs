using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDasDisciplinas
{
    class Util
    {
        /// <summary>
        /// método de classe que recebe uma lista de alunos e a exibe no console/terminal
        /// </summary>
        /// <param name="frase">texto para exibir no terminal</param>
        /// <param name="lista">lista de alunos matriculados</param>
        public static void exibirLista(string frase, List<Aluno> lista)
        {
            Console.WriteLine(frase);
            foreach (Aluno i in lista)
            {
                Console.WriteLine(i.Matricula + " - " + i.pegaNomeSobrenome() + " - " + i.Email);
            }
        }


        /// <summary>
        /// método de classe que abre dois arquivos texto com nomes de alunos em disciplinas e popula nas listas
        /// </summary>
        /// <param name="lista1">contém todos os alunos da disciplina 1</param>
        /// <param name="lista2">contém todos os alunos da disciplina 2</param>
        public static void carregarListas(List<Aluno> lista1, List<Aluno> lista2)
        {
            Console.WriteLine("Trabalhando com listas e arquivos ....");
            StreamReader leitor;

            string nomeArquivo1 = "disciplina1.dat";
            string nomeArquivo2 = "disciplina2.dat";
            string[] vetorDados;

            try
            {
                //Console.Write("Digite nome do arquivo com nomes de alunos da disciplina 1: ");
                //nomeArquivo1 = Console.ReadLine();
                if (lista1.Count.Equals(0))
                {
                    leitor = new StreamReader(nomeArquivo1);
                    do
                    {
                        vetorDados = leitor.ReadLine().Split(";"); //matricula;nome;email
                        lista1.Add(new Aluno(vetorDados[0], vetorDados[1], vetorDados[2]));

                    } while (!leitor.EndOfStream); //repete-se a leitura da linha até que o leitor não chegue no final do arquivo
                    leitor.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo1 com problemas ou inexistente");
            }

            try
            {
                //Console.Write("Digite nome do arquivo com nomes de alunos da disciplina 2: ");
                //nomeArquivo2 = Console.ReadLine();
                if (lista2.Count.Equals(0))
                {
                    leitor = new StreamReader(nomeArquivo2);

                    do
                    {
                        vetorDados = leitor.ReadLine().Split(";"); //matricula;nome;email
                        lista2.Add(new Aluno(vetorDados[0], vetorDados[1], vetorDados[2]));

                    } while (!leitor.EndOfStream); //repete-se a leitura da linha até que o leitor não chegue no final do arquivo
                    leitor.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo2 com problemas ou inexistente");
            }
        }


        public static void exibirComuns(List<Aluno> lista1, List<Aluno> lista2)
        {
            List<Aluno> listaComuns = new List<Aluno>(); 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exibindo alunos em comuns E GRAVANDO ARQUIVO...");

            //StreamWriter escritor = new StreamWriter("alunosComuns.dat", true); //com append/add
            StreamWriter escritor = new StreamWriter("alunosComuns.dat");//sem true sobrepoe arquivo

            foreach (Aluno i in lista1)
            {
                foreach (Aluno i2 in lista2)
                {
                    if (i.Matricula == i2.Matricula)
                    {
                        Console.WriteLine(i.Matricula + " - " + i.pegaNomeSobrenome() + " - " + i.Email);
                        //Aluno aluno = new Aluno(i.Matricula, i.Nome, i.Email);
                        try
                        {
                            //escritor.WriteLine(objeto.Matricula + ";" + objeto.Nome + ";" + objeto.Email);
                            escritor.WriteLine(i.Matricula + ";" + i.Nome + ";" + i.Email);
                            escritor.Flush();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro - Arquivo de usuários com problemas" + e);
                        }
                    }
                }
                
            } //fim foreach
            escritor.Close();
        }//fim metodo

        //para gravar alunos em comum, caso queira em ==> construção
        
        private static void gravarArquivo(Aluno objeto)
        //private static void gravarArquivo(string matricula, string nome, string email)
        {
            try
            {
                //StreamWriter escritor = new StreamWriter("alunosComuns.dat", true); //com append/add
                StreamWriter escritor = new StreamWriter("alunosComuns.dat");//sem true sobrepoe arquivo

                //escritor.WriteLine(objeto.Matricula + ";" + objeto.Nome + ";" + objeto.Email);
                escritor.WriteLine(objeto.Matricula + ";" + objeto.Nome + ";" + objeto.Email);
                escritor.Flush();
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro - Arquivo de usuários com problemas" + e);
            }
        }

    }
}