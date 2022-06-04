using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroUsuario
{
    public class Usuario
    {
        //Atributos: nome, telefone, cpf, login,
        //senha, status (ativo ou inativo), tipo (administrador ou usuário).
        public string nome;
        public int telefone;
        public double cpf;
        public string login;
        public string senha;
        public string status;
        public string tipo;

        public Usuario(string nome, int telefone, double cpf, string login, string senha, string status, string tipo)
        {
            this.nome = nome;   
            this.telefone = telefone;
            this.cpf = cpf; 
            this.login = login; 
            this.senha = senha;
            this.status = status;   
            this.tipo = tipo;
        }

        public void MostrarDadosUsuario()
        {
            MessageBox.Show("Nome: " + this.nome);
            MessageBox.Show("Telefone: " + this.telefone);
            MessageBox.Show("CPF: " + this.cpf);
            MessageBox.Show("Login: " + this.login);
            MessageBox.Show("Senha: " + this.senha);
            MessageBox.Show("Status: " + this.status);
            MessageBox.Show("Tipo: " + this.tipo);

        }
    }
}
