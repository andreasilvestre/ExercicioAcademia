using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Relacionamento
{
    [Table("Veiculos")] //fique ligado nessa notação
    public class Veiculo
    {
        [Key()] //forçando que Id é chave primária
        public int Id { get; set; }

        [ForeignKey("Modelo")] //informando que ModeloId vem da tabela/classe Modelo
        public int ModeloId { get; set; }

        //atenção, para garantir uma associação em tempo de execução, cria-se um objeto Modelo virtual
        public virtual Modelo Modelo { get; set; } //lazy load

        public string Nome { get; set; }
        public int Ano { get; set; }

        //para a classe Veiculo
        public void Salvar()
        {
            var db = new BaseContext();
            db.Veiculos.Add(this);
            db.SaveChanges();
        }

        public static List<Veiculo> Todos()
        {
            var db = new BaseContext();
            return db.Veiculos.ToList();
        }

    }
}
