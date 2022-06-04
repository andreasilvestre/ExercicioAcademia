namespace Aula030622
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lblModeloCarro = new System.Windows.Forms.Label();
            this.tbModeloCarro = new System.Windows.Forms.TextBox();
            this.lblFabricanteCarro = new System.Windows.Forms.Label();
            this.tbFabricante = new System.Windows.Forms.TextBox();
            this.lblOpcionais = new System.Windows.Forms.Label();
            this.lbOpcionais = new System.Windows.Forms.CheckedListBox();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.lblPortas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(355, 307);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(133, 47);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(508, 307);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(103, 47);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lblModeloCarro
            // 
            this.lblModeloCarro.AutoSize = true;
            this.lblModeloCarro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblModeloCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloCarro.Location = new System.Drawing.Point(95, 25);
            this.lblModeloCarro.Name = "lblModeloCarro";
            this.lblModeloCarro.Size = new System.Drawing.Size(88, 13);
            this.lblModeloCarro.TabIndex = 2;
            this.lblModeloCarro.Text = "Modelo do Carro:";
            // 
            // tbModeloCarro
            // 
            this.tbModeloCarro.BackColor = System.Drawing.SystemColors.Window;
            this.tbModeloCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModeloCarro.Location = new System.Drawing.Point(237, 25);
            this.tbModeloCarro.Name = "tbModeloCarro";
            this.tbModeloCarro.Size = new System.Drawing.Size(251, 20);
            this.tbModeloCarro.TabIndex = 3;
            // 
            // lblFabricanteCarro
            // 
            this.lblFabricanteCarro.AutoSize = true;
            this.lblFabricanteCarro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFabricanteCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricanteCarro.Location = new System.Drawing.Point(95, 70);
            this.lblFabricanteCarro.Name = "lblFabricanteCarro";
            this.lblFabricanteCarro.Size = new System.Drawing.Size(103, 13);
            this.lblFabricanteCarro.TabIndex = 4;
            this.lblFabricanteCarro.Text = "Fabricante do Carro:";
            // 
            // tbFabricante
            // 
            this.tbFabricante.BackColor = System.Drawing.SystemColors.Window;
            this.tbFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFabricante.Location = new System.Drawing.Point(237, 70);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.Size = new System.Drawing.Size(251, 20);
            this.tbFabricante.TabIndex = 5;
            // 
            // lblOpcionais
            // 
            this.lblOpcionais.AutoSize = true;
            this.lblOpcionais.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOpcionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionais.Location = new System.Drawing.Point(98, 127);
            this.lblOpcionais.Name = "lblOpcionais";
            this.lblOpcionais.Size = new System.Drawing.Size(57, 13);
            this.lblOpcionais.TabIndex = 6;
            this.lblOpcionais.Text = "Opcionais:";
            // 
            // lbOpcionais
            // 
            this.lbOpcionais.BackColor = System.Drawing.SystemColors.Window;
            this.lbOpcionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpcionais.FormattingEnabled = true;
            this.lbOpcionais.Items.AddRange(new object[] {
            "Ar Condicionado",
            "Direção Hidraúlica",
            "Freios ABS",
            "Air Bag",
            "Vidros Elétricos"});
            this.lbOpcionais.Location = new System.Drawing.Point(237, 118);
            this.lbOpcionais.Name = "lbOpcionais";
            this.lbOpcionais.Size = new System.Drawing.Size(159, 79);
            this.lbOpcionais.TabIndex = 7;
            // 
            // cbPortas
            // 
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Items.AddRange(new object[] {
            "2 portas",
            "3 portas",
            "4 portas",
            "5 portas"});
            this.cbPortas.Location = new System.Drawing.Point(237, 240);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(209, 21);
            this.cbPortas.TabIndex = 8;
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Location = new System.Drawing.Point(107, 251);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(66, 13);
            this.lblPortas.TabIndex = 9;
            this.lblPortas.Text = "Qtde Portas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(621, 362);
            this.Controls.Add(this.lblPortas);
            this.Controls.Add(this.cbPortas);
            this.Controls.Add(this.lbOpcionais);
            this.Controls.Add(this.lblOpcionais);
            this.Controls.Add(this.tbFabricante);
            this.Controls.Add(this.lblFabricanteCarro);
            this.Controls.Add(this.tbModeloCarro);
            this.Controls.Add(this.lblModeloCarro);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lblModeloCarro;
        private System.Windows.Forms.TextBox tbModeloCarro;
        private System.Windows.Forms.Label lblFabricanteCarro;
        private System.Windows.Forms.TextBox tbFabricante;
        private System.Windows.Forms.Label lblOpcionais;
        private System.Windows.Forms.CheckedListBox lbOpcionais;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.Label lblPortas;
    }
}

