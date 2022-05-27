using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem
{
    class Util
    {
        public static void exibirLista(string frase, List<Veiculo> lista)
        {
            Console.WriteLine(frase);
            foreach (Veiculo i in lista)
            {
                Console.WriteLine(i.Placa + " - " + i.DataHoraEntrada);
            }
        }

        public static void carregarListas(List<Veiculo> lista)
        {
            StreamReader leitor;
            string nomeArquivo = "garagem.dat";
            string[] vetorDados;
            try
            {
                leitor = new StreamReader(nomeArquivo);
                do
                {
                    vetorDados = leitor.ReadLine().Split(";"); //placa;dataHoraEntrada
                    DateTime DataHoraEntrada = DateTime.Parse(vetorDados[1]);
                    lista.Add(new Veiculo(vetorDados[0], DataHoraEntrada));
                } while (!leitor.EndOfStream); //repete-se a leitura da linha até que o leitor não chegue no final do arquivo
                leitor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro - Arquivo de veículos com problemas ou inexistente " + e);
            }
        }

        private static bool jaCadastrado(Veiculo objeto, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (objeto.Placa.Equals(i.Placa))
                {
                    return true;
                }
            }
            return false;
        }

        private static void gravarArquivo(Veiculo objeto)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("garagem.dat", true);

                escritor.WriteLine(objeto.Placa + ";" + objeto.DataHoraEntrada);
                escritor.Flush();
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro - Arquivo de usuários com problemas" + e);
            }
        }


        public static void cadastrarVeiculo(string frase, List<Veiculo> lista)
        {
            Console.WriteLine(frase);
            string placa;
            do
            {
                Console.Write("Digite a placa: ");
                placa = Console.ReadLine().ToUpper();
                if (placa.Length != 7)
                {
                    Console.WriteLine("Digite a placa com 7 caracteres.");
                }
                else
                {
                    break;
                }
            } while (true);

            Veiculo objeto = new Veiculo(placa);

            if (!Util.jaCadastrado(objeto, lista))
            {
                lista.Add(objeto);
                //gravar no arquivo
                Util.gravarArquivo(objeto);
            }
            else
            {
                Console.WriteLine("Este veículo com esta placa já está na base de dados!");
            }
        }
    }
}