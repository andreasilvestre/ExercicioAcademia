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
    public partial class frmAutomovel : Form
    {
        static List<Carro> carros = new List<Carro>();

        public frmAutomovel()
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
            dgAutomoveis.Rows.Clear();
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
                if (opc == "Direção Hidraúlica")
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
            
            //c.MostrarDadosCarro();
            carros.Add(c);
            //mostraListaCarros();
            dgAutomoveis.Rows.Add(tbModeloCarro.Text, tbFabricante.Text, ac, dh, abs, ab, ve, portas);
        }
        static void mostraListaCarros() {
            foreach (Carro c in carros)
            {
                MessageBox.Show("Carro " + c.modelo + "\nFabricante " + c.fabricante + "\nDH " + c.dh + "\nAr " + c.ar + "\nABS " + c.abs + "\nAir bag " + c.airbag + "\nVidros eletrico " + c.ve + "\nPortas " + c.portas);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgAutomoveis.Rows.Clear();
            foreach (Carro c in carros)
            {
                //ac, dh, abs, ab, ve, portas);
                dgAutomoveis.Rows.Add(c.modelo, c.fabricante,c.ar, c.dh, c.abs, c.airbag,c.ve,c.portas);
            }
            //dgAutomoveis.Rows.Add(c.)
        }
    }
}
