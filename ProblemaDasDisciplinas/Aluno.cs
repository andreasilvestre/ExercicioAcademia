using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDasDisciplinas
{
    internal class Aluno
    {
        string matricula;
        string nome;
        string email;

        public Aluno(string matricula, string nome, string email)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Email = email;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
    }
}
