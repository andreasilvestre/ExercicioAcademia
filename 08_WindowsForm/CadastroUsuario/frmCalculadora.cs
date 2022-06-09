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
    public partial class frmCalculadora : Form
    {

        double n1;
        double n2;
        string operacao;
        double resultado;
        
        
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text +  "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text +  "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "3";
        }

        private void btResultado_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(txtVisor.Text);
            lblVisor.Text = lblVisor.Text + txtVisor.Text + " = ";

            txtVisor.Text = null;
            if (operacao == "+")
            {
                resultado = n1 + n2;

            }
            txtVisor.Text = resultado.ToString();
        }
        private void btSomar_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtVisor.Text);
            lblVisor.Text = n1 + " + ";
            txtVisor.Text = null;
            operacao = "+";
        }


        private void txtVisor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                this.AcceptButton = btResultado;
            }
        }

        private void txtVisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //btResultado.;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btC_Click(object sender, EventArgs e)
        {
            txtVisor.Text = null;
            lblVisor.Text = null;
            txtVisor.TabIndex = 0;
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtVisor_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = Convert.ToString(e.KeyValue); //ver tecla temp

            if (e.KeyValue == 13)
            {
                n2 = double.Parse(txtVisor.Text);
                lblVisor.Text = lblVisor.Text + txtVisor.Text + " = ";

                txtVisor.Text = null;
                if (operacao == "+")
                {
                    resultado = n1 + n2;

                }
                txtVisor.Text = resultado.ToString();
            }
            if (e.KeyValue == 107) // + somar
            {
                n1 = double.Parse(txtVisor.Text);
                lblVisor.Text = n1 + " + ";
                txtVisor.Text = "";
                operacao = "+";

            }
            if (e.KeyValue == 109) // - subtrair
            {
                lblVisor.Text = lblVisor.Text + " - ";
                n1 = double.Parse(txtVisor.Text);
            }
            if (e.KeyValue == 106) // * multiplicar
            {
                lblVisor.Text = lblVisor.Text + " x ";
            }
            if (e.KeyValue == 111) // / dividir
            {
                lblVisor.Text = lblVisor.Text + " / ";

            }
        }

        private void btC_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}