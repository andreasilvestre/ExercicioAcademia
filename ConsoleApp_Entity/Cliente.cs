using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Entity
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
