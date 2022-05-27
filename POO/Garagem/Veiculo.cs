using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagem
{
    class Veiculo
    {
        string placa;
        DateTime datahoraEntrada;

        private void gerarDataHoraEntrada()
        {
            this.datahoraEntrada = DateTime.Now;
            //this.datahoraEntrada = this.datahoraEntrada.ToString();
        }

        //construtor usado no cadastro de um usuario
        public Veiculo(string placa)
        {
            this.placa = placa;
            this.gerarDataHoraEntrada();
        }

        //construtor usado para popular a lista a partir do arquivo (banco)
        public Veiculo(string placa, DateTime datahoraEntrada)
        {
            this.placa = placa;
            this.datahoraEntrada = datahoraEntrada;
        }

        public string Placa { get => placa; set => placa = value; }

        public DateTime DataHoraEntrada { get => datahoraEntrada; }
    }
}