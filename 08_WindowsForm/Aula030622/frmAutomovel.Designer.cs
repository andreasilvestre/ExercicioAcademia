namespace Aula030622
{
    partial class frmAutomovel
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
            this.dgAutomoveis = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.modeloCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ac = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ans = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ab = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ve = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.portas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomoveis)).BeginInit();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(199, 303);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(76, 47);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(284, 303);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(88, 47);
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
            this.lblModeloCarro.Location = new System.Drawing.Point(7, 25);
            this.lblModeloCarro.Name = "lblModeloCarro";
            this.lblModeloCarro.Size = new System.Drawing.Size(88, 13);
            this.lblModeloCarro.TabIndex = 2;
            this.lblModeloCarro.Text = "Modelo do Carro:";
            // 
            // tbModeloCarro
            // 
            this.tbModeloCarro.BackColor = System.Drawing.SystemColors.Window;
            this.tbModeloCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModeloCarro.Location = new System.Drawing.Point(116, 25);
            this.tbModeloCarro.Name = "tbModeloCarro";
            this.tbModeloCarro.Size = new System.Drawing.Size(251, 20);
            this.tbModeloCarro.TabIndex = 3;
            // 
            // lblFabricanteCarro
            // 
            this.lblFabricanteCarro.AutoSize = true;
            this.lblFabricanteCarro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFabricanteCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricanteCarro.Location = new System.Drawing.Point(7, 70);
            this.lblFabricanteCarro.Name = "lblFabricanteCarro";
            this.lblFabricanteCarro.Size = new System.Drawing.Size(103, 13);
            this.lblFabricanteCarro.TabIndex = 4;
            this.lblFabricanteCarro.Text = "Fabricante do Carro:";
            // 
            // tbFabricante
            // 
            this.tbFabricante.BackColor = System.Drawing.SystemColors.Window;
            this.tbFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFabricante.Location = new System.Drawing.Point(116, 70);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.Size = new System.Drawing.Size(251, 20);
            this.tbFabricante.TabIndex = 5;
            // 
            // lblOpcionais
            // 
            this.lblOpcionais.AutoSize = true;
            this.lblOpcionais.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOpcionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionais.Location = new System.Drawing.Point(10, 127);
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
            this.lbOpcionais.Location = new System.Drawing.Point(116, 118);
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
            this.cbPortas.Location = new System.Drawing.Point(116, 240);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(209, 21);
            this.cbPortas.TabIndex = 8;
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Location = new System.Drawing.Point(19, 251);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(66, 13);
            this.lblPortas.TabIndex = 9;
            this.lblPortas.Text = "Qtde Portas:";
            // 
            // dgAutomoveis
            // 
            this.dgAutomoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutomoveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modeloCarro,
            this.fabricante,
            this.ac,
            this.dh,
            this.ans,
            this.ab,
            this.ve,
            this.portas});
            this.dgAutomoveis.Location = new System.Drawing.Point(378, 25);
            this.dgAutomoveis.Name = "dgAutomoveis";
            this.dgAutomoveis.Size = new System.Drawing.Size(424, 325);
            this.dgAutomoveis.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "&Carregar da Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modeloCarro
            // 
            this.modeloCarro.HeaderText = "Modelo";
            this.modeloCarro.Name = "modeloCarro";
            this.modeloCarro.Width = 60;
            // 
            // fabricante
            // 
            this.fabricante.HeaderText = "Fabricante";
            this.fabricante.Name = "fabricante";
            this.fabricante.Width = 80;
            // 
            // ac
            // 
            this.ac.HeaderText = "AR";
            this.ac.Name = "ac";
            this.ac.ReadOnly = true;
            this.ac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ac.Width = 40;
            // 
            // dh
            // 
            this.dh.HeaderText = "DH";
            this.dh.Name = "dh";
            this.dh.Width = 40;
            // 
            // ans
            // 
            this.ans.HeaderText = "ABS";
            this.ans.Name = "ans";
            this.ans.Width = 40;
            // 
            // ab
            // 
            this.ab.HeaderText = "AB";
            this.ab.Name = "ab";
            this.ab.Width = 40;
            // 
            // ve
            // 
            this.ve.HeaderText = "VE";
            this.ve.Name = "ve";
            this.ve.Width = 40;
            // 
            // portas
            // 
            this.portas.HeaderText = "Portas";
            this.portas.Name = "portas";
            // 
            // frmAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(814, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgAutomoveis);
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
            this.Name = "frmAutomovel";
            this.Text = "Cadastrando automóveis";
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomoveis)).EndInit();
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
        private System.Windows.Forms.DataGridView dgAutomoveis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloCarro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ac;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ans;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ab;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ve;
        private System.Windows.Forms.DataGridViewTextBoxColumn portas;
    }
}

