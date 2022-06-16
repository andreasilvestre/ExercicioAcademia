using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Simples_WinForm_BD
{
    public partial class frmCadPessoas : Form
    {
        public frmCadPessoas()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            tbNome.Text = "";
            tbIdade.Text = "";
            tbCPF.Text = "";
            tbEndereco.Text = "";
            tbBairro.Text = "";
            tbCEP.Text = "";
            tbCidade.Text = "";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            //tbNome.Text = "";
            //tbIdade.Text = "";
            //tbCPF.Text = "";
            //tbEndereco.Text = "";
            //tbBairro.Text = "";
            //tbCEP.Text = "";
            //tbCidade.Text = "";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //string nome, int idade, string cpf, string end, string bairro, string cep, string cidade)
            Pessoa p = new Pessoa(tbNome.Text, int.Parse(tbIdade.Text), tbCPF.Text, tbEndereco.Text, tbBairro.Text, tbCEP.Text, tbCidade.Text);
            MessageBox.Show("Nome do indivíduo: " + p.nome + " CPF: " + p.cpf);
            Limpar();
            p.gravarPessoa();
        }
    }
}
