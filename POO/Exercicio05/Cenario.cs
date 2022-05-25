using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Cenario
    {
        /// <summary>
        /// guarda adescriçãpo cenário
        /// </summary>
        string descricao;

        /// <summary>
        /// guarda a data de criação do cenário
        /// </summary>
        DateTime data_criacao;

        /// <summary>
        /// guarda a altura do cenário
        /// </summary>
        float altura;

        /// <summary>
        /// propriedade de acesso  da descrição
        /// </summary>
        public string Descricao { get => descricao; set => descricao = value; }
        
        /// <summary>
        /// propriedade de acesso da data de Criação
        /// </summary>
        public DateTime Data_criacao { get => data_criacao; set => data_criacao = value; }
        
        /// <summary>
        /// propriedade de acesso da altura
        /// </summary>
        public float Altura { get => altura; set => altura = value; }

        /// <summary>
        /// método construtor básico
        /// </summary>
        public Cenario()
        {
        }

        /// <summary>
        /// método construtor do cenário com todos atributos
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="data_criacao"></param>
        /// <param name="altura"></param>
        public Cenario(string descricao, DateTime data_criacao, float altura)
        {
            this.descricao = descricao;
            this.data_criacao = data_criacao;
            this.altura = altura;
        }

        /// <summary>
        /// método que mostra os dados do cenário na tela do usuário
        /// </summary>
        public void exibirDados()
        {
            Console.WriteLine("Exibindo dados...");
            Console.WriteLine(Descricao + "|" + Data_criacao.ToString("d") + "|" + Altura);
        }

        /// <summary>
        /// método que calcula o intervalo de tempo entre a data de criação e a data atual
        /// </summary>
        /// <returns></returns>
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
