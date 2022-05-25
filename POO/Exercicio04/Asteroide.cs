using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Asteroide
    {
        /// <summary>
        /// armazena a posição x do asteroide
        /// </summary>
        int posicao_x;

        /// <summary>
        /// armazena a posição y do asteroide
        /// </summary>
        int posicao_y;

        int tamanho; //de 0 10
        int velocidade; //de 1 a 5;
        int energia;// de 1 a 5

        public int Posicao_x { get => posicao_x; set => posicao_x = value; }
        public int Posicao_y { get => posicao_y; set => posicao_y = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }
        public int Energia { get => energia; set => energia = value; }

        public Asteroide()
        {
        }

        public Asteroide(int posicao_x, int posicao_y, int tamanho, int velocidade, int energia)
        {
            this.posicao_x = posicao_x;
            this.posicao_y = posicao_y;
            this.tamanho = tamanho;
            this.velocidade = velocidade;
            this.energia = energia;
        }


        public Asteroide(int posicao_x, int posicao_y)
        {
            this.posicao_x = posicao_x;
            this.posicao_y = posicao_y;
        }

        public static void mostrarLista(List<Asteroide> lista)
        {
            foreach (Asteroide i in lista)
	        {
                Console.WriteLine(i.Posicao_x + "x" + i.Posicao_y + " | " + i.Tamanho + " | " + i.Velocidade + " | " + i.Energia );
	        }
        }

        public static List<Asteroide> pegaLista(List<Asteroide> lista)
        {
            //foreach (Asteroide i in lista)
            //{
            //    i.Posicao_x + "x" + i.Posicao_y + " | " + i.Tamanho + " | " + i.Velocidade + " | " + i.Energia);
            //}
            return lista;
        }
    }//class
}//namespace
