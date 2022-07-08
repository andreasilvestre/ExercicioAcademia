using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Relacionamento
{
    public class BaseContext : DbContext //lembre de fazer a importação
    {
        //instanciando BaseContext com o banco com esse nome
        public BaseContext() : base("BancoDadosVeiculos") { }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
    }
}
