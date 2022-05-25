using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Cenario
    {
        string descricao;
        DateTime data_criacao;
        float altura;

        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Data_criacao { get => data_criacao; set => data_criacao = value; }
        public float Altura { get => altura; set => altura = value; }

        public Cenario()
        {
        }

        public Cenario(string descricao, DateTime data_criacao, float altura)
        {
            this.descricao = descricao;
            this.data_criacao = data_criacao;
            this.altura = altura;
        }

        public TimeSpan calcularTempo()
        {
            TimeSpan intervalo;
            intervalo = DateTime.Now.Subtract(Data_criacao);
            //ou
            //intervalo = DateTime.Now - Data_criacao;
            return intervalo;
        }
    }
}
