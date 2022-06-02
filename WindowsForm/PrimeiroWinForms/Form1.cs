using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no botão OK.");
            MessageBox.Show("Nome: " + tbNome.Text.ToUpper() +
                "\nEmail: " + tbEmail.Text.ToLower() +
                "\nTelefone: " + tbTelefone.Text + " Sexo: " + tbSexo.Text.ToUpper() +
                "\nEndereço: " + tbEndereco.Text.ToUpper() +
                "\nBairro: " + tbBairro.Text.ToUpper() + " Cidade: " + tbCidade.Text.ToUpper());

            MessageBox.Show("Cadastro efetuado com sucesso");
            tbNome.Clear();
            tbEmail.Clear();
            tbEndereco.Text = "";
            tbBairro.Text = "Nova Verona";
            lblMensagem.Text = "Tudo ok, Cadastro efetuado com sucesso!";
            tbTelefone.Text = "";
            tbSexo.Clear();
            tbCidade.Clear();

        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Cancelar");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Sejam todos bem vindos!" +
            //    "\n Você está entrando no programa Show!");
        }
    }
}
