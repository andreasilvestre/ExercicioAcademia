namespace WindowsForm_BD
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
            this.listView_medidasGlicemia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Conectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_idGlicemia = new System.Windows.Forms.TextBox();
            this.textBox_valorGlicemia = new System.Windows.Forms.TextBox();
            this.textBox_DataMedicao = new System.Windows.Forms.TextBox();
            this.textBox_idPaciente = new System.Windows.Forms.TextBox();
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.button_Remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_medidasGlicemia
            // 
            this.listView_medidasGlicemia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_medidasGlicemia.HideSelection = false;
            this.listView_medidasGlicemia.Location = new System.Drawing.Point(31, 12);
            this.listView_medidasGlicemia.Name = "listView_medidasGlicemia";
            this.listView_medidasGlicemia.Size = new System.Drawing.Size(532, 210);
            this.listView_medidasGlicemia.TabIndex = 0;
            this.listView_medidasGlicemia.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemia.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor Glicêmico";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Medição";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paciente";
            this.columnHeader4.Width = 100;
            // 
            // button_Conectar
            // 
            this.button_Conectar.Location = new System.Drawing.Point(440, 228);
            this.button_Conectar.Name = "button_Conectar";
            this.button_Conectar.Size = new System.Drawing.Size(123, 34);
            this.button_Conectar.TabIndex = 1;
            this.button_Conectar.Text = "Conectar";
            this.button_Conectar.UseVisualStyleBackColor = true;
            this.button_Conectar.Click += new System.EventHandler(this.button_Conectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Glicemia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Glicemia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Medição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id Paciente";
            // 
            // textBox_idGlicemia
            // 
            this.textBox_idGlicemia.Location = new System.Drawing.Point(134, 298);
            this.textBox_idGlicemia.Name = "textBox_idGlicemia";
            this.textBox_idGlicemia.Size = new System.Drawing.Size(170, 20);
            this.textBox_idGlicemia.TabIndex = 6;
            // 
            // textBox_valorGlicemia
            // 
            this.textBox_valorGlicemia.Location = new System.Drawing.Point(134, 338);
            this.textBox_valorGlicemia.Name = "textBox_valorGlicemia";
            this.textBox_valorGlicemia.Size = new System.Drawing.Size(170, 20);
            this.textBox_valorGlicemia.TabIndex = 7;
            // 
            // textBox_DataMedicao
            // 
            this.textBox_DataMedicao.Location = new System.Drawing.Point(134, 370);
            this.textBox_DataMedicao.Name = "textBox_DataMedicao";
            this.textBox_DataMedicao.Size = new System.Drawing.Size(170, 20);
            this.textBox_DataMedicao.TabIndex = 8;
            // 
            // textBox_idPaciente
            // 
            this.textBox_idPaciente.Location = new System.Drawing.Point(134, 407);
            this.textBox_idPaciente.Name = "textBox_idPaciente";
            this.textBox_idPaciente.Size = new System.Drawing.Size(170, 20);
            this.textBox_idPaciente.TabIndex = 9;
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(180, 454);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(124, 32);
            this.button_Adicionar.TabIndex = 10;
            this.button_Adicionar.Text = "Adicionar";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // button_Remover
            // 
            this.button_Remover.Location = new System.Drawing.Point(313, 228);
            this.button_Remover.Name = "button_Remover";
            this.button_Remover.Size = new System.Drawing.Size(112, 33);
            this.button_Remover.TabIndex = 11;
            this.button_Remover.Text = "Remover";
            this.button_Remover.UseVisualStyleBackColor = true;
            this.button_Remover.Click += new System.EventHandler(this.button_Remover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 507);
            this.Controls.Add(this.button_Remover);
            this.Controls.Add(this.button_Adicionar);
            this.Controls.Add(this.textBox_idPaciente);
            this.Controls.Add(this.textBox_DataMedicao);
            this.Controls.Add(this.textBox_valorGlicemia);
            this.Controls.Add(this.textBox_idGlicemia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Conectar);
            this.Controls.Add(this.listView_medidasGlicemia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_medidasGlicemia;
        private System.Windows.Forms.Button button_Conectar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_idGlicemia;
        private System.Windows.Forms.TextBox textBox_valorGlicemia;
        private System.Windows.Forms.TextBox textBox_DataMedicao;
        private System.Windows.Forms.TextBox textBox_idPaciente;
        private System.Windows.Forms.Button button_Adicionar;
        private System.Windows.Forms.Button button_Remover;
    }
}

