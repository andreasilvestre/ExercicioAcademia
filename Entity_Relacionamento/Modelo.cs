using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Relacionamento
{
    [Table("Modelos")] //fique ligado nessa notação
    public class Modelo
    {
        private string v;

        public Modelo(string v)
        {
            this.v = v;
        }

        [Key()] //forçando que Id é a chave primária
        public int Id { get; set; }
        public string Nome { get; set; }

        public void Salvar()
        {
            var db = new BaseContext();
            db.Modelos.Add(this);
            db.SaveChanges();
        }

        public static List<Modelo> Todos()
        {
            var db = new BaseContext();
            return db.Modelos.ToList();
        }

    }

}
