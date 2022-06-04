﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula030622
{
    public class Carro
    {
        public string modelo;
        public string fabricante;
        public bool ar;
        public bool dh;
        public bool abs;
        public bool airbag;
        public bool ve;
        public int portas;

        public Carro(string modelo, string fabricante, bool ar, bool dh, bool abs, bool airbag, bool ve, int portas)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ar = ar;
            this.dh = dh;
            this.abs = abs;
            this.airbag = airbag;
            this.ve = ve;
            this.portas = portas;
        }

        public void MostrarDadosCarro()
        {
            MessageBox.Show("Modelo: " + modelo);
            MessageBox.Show("Fabricante " + this.fabricante);
            MessageBox.Show("Ar " + this.ar);
            MessageBox.Show("DH " + this.dh);
            MessageBox.Show("ABS " + this.abs);
            MessageBox.Show("Air bag " + this.airbag);
            MessageBox.Show("Vidros eletrico " + this.ve);
            MessageBox.Show("Portas " + this.portas);

        }
    }
}
