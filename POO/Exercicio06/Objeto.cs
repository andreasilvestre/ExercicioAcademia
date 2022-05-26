using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
     class Objeto
    {
        int x;
        int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Objeto()
        {
        }
        public Objeto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void exibirUmObjeto()
        {
            Console.WriteLine("Objeto informado é: " + X + "x" + Y);
        }

        public static void exibirVariosObjetos(List<Objeto> lista)
        {
            foreach (Objeto i in lista)
            {
                Console.WriteLine("Objeto: " + i.x + "x" + i.y);
            }
        }
    }
}
