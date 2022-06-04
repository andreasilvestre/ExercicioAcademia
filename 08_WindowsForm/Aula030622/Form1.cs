using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula030622
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbModeloCarro.Clear();
            tbFabricante.Clear();
            //lbOpcionais.ClearSelected();
            //lbOpcionais.Items.Clear();
            //lbOpcionais.Items.Add("Asas");

            foreach (int checados in lbOpcionais.CheckedIndices)
            {
                lbOpcionais.SetItemChecked(checados, false);
                
            }
            cbPortas.ResetText();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Modelo: " + tbModeloCarro.Text);
            //MessageBox.Show("Fabricante: " + tbFabricante.Text);
            //foreach  (string opc in lbOpcionais.CheckedItems)
            //{
            //    MessageBox.Show("Opcionais: " + opc);
            //}
            ////MessageBox.Show("Opcionais: ");
            //MessageBox.Show("Portas: " + cbPortas.Text);

            bool ac = false, dh = false, abs = false, ve = false, ab = false;
            int portas;
            foreach (string opc in lbOpcionais.CheckedItems)
            {

                if (opc == "Ar Condicionado")
                {
                    ac = true;
                }
                if (opc == "Direção Hidráulica")
                {
                    dh = true;
                }
                if (opc == "Freios ABS")
                {
                    abs = true;
                }
                if (opc == "Vidros Elétricos")
                {
                    ve = true;
                }
                if (opc == "Air Bag")
                {
                    ab = true;
                }
            }
            portas = 0;
            if (cbPortas.Text == "2 portas") portas = 2;
            else if (cbPortas.Text == "3 portas") portas = 3;
            else if (cbPortas.Text == "4 portas") portas = 4;
            else if (cbPortas.Text == "5 portas") portas = 5;
            Carro c = new Carro(tbModeloCarro.Text, tbFabricante.Text, ac, dh, abs, ab, ve, portas);
            
            c.MostrarDadosCarro();
        }
    }
}
