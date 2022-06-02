using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drop6_Refazer
{
    internal class Pessoa
    {
        public string nome;
        public string email; //será o identificador/id

        //método construtor - obrigatório
        public Pessoa(string n, string e)
        {
            nome = n;
            email = e;  
        }
    }
}
