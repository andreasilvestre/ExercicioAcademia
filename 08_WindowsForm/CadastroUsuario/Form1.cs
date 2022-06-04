using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbCPF.Clear();
            tbTelefone.Clear();
            tbLogin.Clear();
            tbSenha.Clear();
            cbStatus.ResetText();
            cbTipo.ResetText();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(tbNome.Text,int.Parse(tbTelefone.Text), double.Parse(tbCPF.Text),tbLogin.Text,tbSenha.Text,cbStatus.Text,cbTipo.Text);
            u.MostrarDadosUsuario();
        }
    }
}
