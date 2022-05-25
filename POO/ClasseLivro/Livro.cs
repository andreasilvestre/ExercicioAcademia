using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    class Livro
    {
        public string titulo;
        public string autor;
        public int paginas;
        public int ano;
        public int edicao;
        public Livro(string tit, string au, int pag, int an, int ed)
        {
            titulo = tit;
            autor = au;
            paginas = pag;
            ano = an;
            edicao = ed;
        }

        public void apresentarInfoLivro()
        {
            //Console.WriteLine("O livro de título " + titulo + " autor " + autor + " edição " + edicao + " lançado em " + ano);
            Console.WriteLine("O livro com titulo de " + titulo + " do autor " + autor + " edição " + edicao + " lançado no ano de " + ano + " com " + paginas + " páginas");
        } 
    }
}
