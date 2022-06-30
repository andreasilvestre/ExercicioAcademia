using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Criptografia
{
    public partial class Form1 : Form
    {
        Assimetrica a = new Assimetrica();
        Simetrica s;
        public Form1()
        {
            InitializeComponent();
            s = new Simetrica();
        }

        private void button_Criptografar_Click(object sender, EventArgs e)
        {
            string frase, fraseCripto;
            frase= textBox_Frase.Text;
            //Assimetrica a = new Assimetrica();
            fraseCripto = a.encrypt(frase);
            label_Cripto.Text = fraseCripto;
        }

        private void button_Descriptografar_Click(object sender, EventArgs e)
        {
            string frase, fraseDesCripto;
            frase = label_Cripto.Text;
            fraseDesCripto = a.decrypt(frase);
            label_Descriptografada.Text = fraseDesCripto;
        }

        private void button_CriptoSimetrico_Click(object sender, EventArgs e)
        {
            string frase, chave, fraseCripto;
            frase = textBox_Frase.Text;
            chave = textBox_Chave.Text;
            fraseCripto = s.EncryptData(frase,chave);
            label_Cripto.Text = fraseCripto;

        }

        private void button_DescriptoSimetrico_Click(object sender, EventArgs e)
        {
            string fraseCripto, chave, fraseDescripto;
            fraseCripto = label_Cripto.Text;
            chave = textBox_Chave.Text;
            fraseDescripto = s.DecryptData(fraseCripto, chave);
            label_Descriptografada.Text = fraseDescripto;
        }
    }
}
