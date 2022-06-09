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
    public partial class frmUsuario : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            //tbNome.Clear();
            //tbCPF.Clear();
            //tbTelefone.Clear();
            //tbLogin.Clear();
            //tbSenha.Clear();
            //cbStatus.ResetText();
            //cbTipo.ResetText();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //Usuario u = new Usuario(tbNome.Text,int.Parse(mtbTelefone.Text), double.Parse(tbCPF.Text),tbLogin.Text, tbSenha.Text,cbStatus.Text,cbTipo.Text);

            //u.MostrarDadosUsuario();
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbOlhoSenha_Click(object sender, EventArgs e)
        {
            if (tbSenha.UseSystemPasswordChar == true)
            {
                tbSenha.UseSystemPasswordChar = false;
            }
            else
            {

                tbSenha.UseSystemPasswordChar = true;
            }
        }

        private void btVerSenha_Click(object sender, EventArgs e)
        {
            if (tbSenha.UseSystemPasswordChar == true)
            {
                tbSenha.UseSystemPasswordChar = false;
            }
            else
            {
                
                tbSenha.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbSalvar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("TELEFOME COM MASCARA: " + mtbTelefone.Text);

            

            Usuario u = new Usuario(tbNome.Text, mtbTelefone.Text, mtbCPF.Text, tbLogin.Text, tbSenha.Text, cbStatus.Text, cbTipo.Text, mtbDataNascimento.Text);

            //u.MostrarDadosUsuario();
            dgUsuarios.Rows.Add(tbNome.Text, tbLogin.Text, tbSenha.Text, mtbDataNascimento.Text, cbStatus.Text, cbTipo.Text, mtbTelefone.Text, mtbCPF.Text);
            usuarios.Add(u);

            tbNome.Clear();
            mtbCPF.Clear();
            mtbTelefone.Clear();
            tbLogin.Clear();
            tbSenha.Clear();
            cbStatus.ResetText();
            cbTipo.ResetText();
            mtbDataNascimento.Clear();
        }

        private void pbLimpar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            mtbCPF.Clear();
            mtbTelefone.Clear();
            tbLogin.Clear();
            tbSenha.Clear();
            cbStatus.ResetText();
            cbTipo.ResetText();
            mtbDataNascimento.Clear();

            dgUsuarios.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("olá botão, estou testando o alt b sublinhado");
        }

        private void tbTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCarregarLista_Click(object sender, EventArgs e)
        {
            dgUsuarios.Rows.Clear();
            foreach (Usuario i in usuarios)
            {
                dgUsuarios.Rows.Add(i.nome, i.login, i.senha, i.dataNascimento, i.status, i.tipo, i.telefone, i.cpf);
            }
        }
    }
}
