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
        public string telefone;
        public string cpf;
        public string login;
        public string senha;
        public string status;
        public string tipo;
        public string dataNascimento;

        public Usuario(string nome, string telefone, string cpf, string login, string senha, string status, string tipo, string dataNascimento)
        {
            this.nome = nome;   
            this.telefone = telefone;
            this.cpf = cpf; 
            this.login = login; 
            this.senha = senha;
            this.status = status;   
            this.tipo = tipo;
            this.dataNascimento = dataNascimento;
        }

        public void MostrarDadosUsuario()
        {
            //MessageBox.Show("Nome: " + this.nome);
            //MessageBox.Show("Telefone: " + this.telefone);
            //MessageBox.Show("CPF: " + this.cpf);
            //MessageBox.Show("Login: " + this.login);
            //MessageBox.Show("Senha: " + this.senha);
            //MessageBox.Show("Status: " + this.status);
            //MessageBox.Show("Tipo: " + this.tipo);

            MessageBox.Show("Nome: " + this.nome +
            "\nTelefone: " + this.telefone +
            "\nCPF: " + this.cpf +
            "\nData de Nascimento: " + dataNascimento +
            "\nLogin: " + this.login +
            "\nSenha: " + this.senha +
            "\nStatus: " + this.status +
            "\nTipo: " + this.tipo);

        }
    }
}
