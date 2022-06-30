namespace WF_Criptografia
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Frase = new System.Windows.Forms.TextBox();
            this.button_Criptografar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Cripto = new System.Windows.Forms.Label();
            this.button_Descriptografar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Descriptografada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Chave = new System.Windows.Forms.TextBox();
            this.button_CriptoSimetrico = new System.Windows.Forms.Button();
            this.button_DescriptoSimetrico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase:";
            // 
            // textBox_Frase
            // 
            this.textBox_Frase.Location = new System.Drawing.Point(99, 33);
            this.textBox_Frase.Name = "textBox_Frase";
            this.textBox_Frase.Size = new System.Drawing.Size(277, 20);
            this.textBox_Frase.TabIndex = 1;
            // 
            // button_Criptografar
            // 
            this.button_Criptografar.Location = new System.Drawing.Point(394, 33);
            this.button_Criptografar.Name = "button_Criptografar";
            this.button_Criptografar.Size = new System.Drawing.Size(100, 26);
            this.button_Criptografar.TabIndex = 2;
            this.button_Criptografar.Text = "&Cripto Assimétrica";
            this.button_Criptografar.UseVisualStyleBackColor = true;
            this.button_Criptografar.Click += new System.EventHandler(this.button_Criptografar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frase Criptografada:";
            // 
            // label_Cripto
            // 
            this.label_Cripto.AutoSize = true;
            this.label_Cripto.Location = new System.Drawing.Point(169, 116);
            this.label_Cripto.Name = "label_Cripto";
            this.label_Cripto.Size = new System.Drawing.Size(13, 13);
            this.label_Cripto.TabIndex = 4;
            this.label_Cripto.Text = "--";
            // 
            // button_Descriptografar
            // 
            this.button_Descriptografar.Location = new System.Drawing.Point(381, 140);
            this.button_Descriptografar.Name = "button_Descriptografar";
            this.button_Descriptografar.Size = new System.Drawing.Size(160, 29);
            this.button_Descriptografar.TabIndex = 5;
            this.button_Descriptografar.Text = "Descripto Assimétrico";
            this.button_Descriptografar.UseVisualStyleBackColor = true;
            this.button_Descriptografar.Click += new System.EventHandler(this.button_Descriptografar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frase Descriptografada:";
            // 
            // label_Descriptografada
            // 
            this.label_Descriptografada.AutoSize = true;
            this.label_Descriptografada.Location = new System.Drawing.Point(169, 227);
            this.label_Descriptografada.Name = "label_Descriptografada";
            this.label_Descriptografada.Size = new System.Drawing.Size(13, 13);
            this.label_Descriptografada.TabIndex = 7;
            this.label_Descriptografada.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chave:";
            // 
            // textBox_Chave
            // 
            this.textBox_Chave.Location = new System.Drawing.Point(571, 33);
            this.textBox_Chave.Name = "textBox_Chave";
            this.textBox_Chave.Size = new System.Drawing.Size(184, 20);
            this.textBox_Chave.TabIndex = 9;
            // 
            // button_CriptoSimetrico
            // 
            this.button_CriptoSimetrico.Location = new System.Drawing.Point(571, 65);
            this.button_CriptoSimetrico.Name = "button_CriptoSimetrico";
            this.button_CriptoSimetrico.Size = new System.Drawing.Size(160, 29);
            this.button_CriptoSimetrico.TabIndex = 10;
            this.button_CriptoSimetrico.Text = "Cripto Simétrico";
            this.button_CriptoSimetrico.UseVisualStyleBackColor = true;
            this.button_CriptoSimetrico.Click += new System.EventHandler(this.button_CriptoSimetrico_Click);
            // 
            // button_DescriptoSimetrico
            // 
            this.button_DescriptoSimetrico.Location = new System.Drawing.Point(571, 140);
            this.button_DescriptoSimetrico.Name = "button_DescriptoSimetrico";
            this.button_DescriptoSimetrico.Size = new System.Drawing.Size(160, 29);
            this.button_DescriptoSimetrico.TabIndex = 11;
            this.button_DescriptoSimetrico.Text = "Descripto Simétrico";
            this.button_DescriptoSimetrico.UseVisualStyleBackColor = true;
            this.button_DescriptoSimetrico.Click += new System.EventHandler(this.button_DescriptoSimetrico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_DescriptoSimetrico);
            this.Controls.Add(this.button_CriptoSimetrico);
            this.Controls.Add(this.textBox_Chave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Descriptografada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Descriptografar);
            this.Controls.Add(this.label_Cripto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Criptografar);
            this.Controls.Add(this.textBox_Frase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Frase;
        private System.Windows.Forms.Button button_Criptografar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Cripto;
        private System.Windows.Forms.Button button_Descriptografar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Descriptografada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Chave;
        private System.Windows.Forms.Button button_CriptoSimetrico;
        private System.Windows.Forms.Button button_DescriptoSimetrico;
    }
}

