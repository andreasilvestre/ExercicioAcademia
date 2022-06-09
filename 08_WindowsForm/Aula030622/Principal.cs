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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btCadastrarAuto_Click(object sender, EventArgs e)
        {
            //Application.Run(new frmAutomovel()); NÃO FUNCIONA
            frmAutomovel fAuto = new frmAutomovel();
            fAuto.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void miImpressora_Click(object sender, EventArgs e)
        {

        }

        private void AutomovelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutomovel fAuto = new frmAutomovel();
            fAuto.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
