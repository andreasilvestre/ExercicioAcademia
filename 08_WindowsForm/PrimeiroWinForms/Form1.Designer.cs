namespace PrimeiroWinForms
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
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.LightCoral;
            this.btOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btOk.Location = new System.Drawing.Point(287, 279);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(154, 51);
            this.btOk.TabIndex = 7;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btCancel.Location = new System.Drawing.Point(458, 279);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(154, 51);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(185, 31);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(288, 20);
            this.tbNome.TabIndex = 0;
            this.tbNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(132, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(132, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail:";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(185, 77);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(288, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(26, 120);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(30, 155);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 7;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(384, 155);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 8;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(384, 190);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 9;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(48, 197);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo:";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(99, 120);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(462, 20);
            this.tbEndereco.TabIndex = 2;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(99, 156);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(167, 20);
            this.tbTelefone.TabIndex = 3;
            // 
            // tbSexo
            // 
            this.tbSexo.Location = new System.Drawing.Point(99, 197);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(167, 20);
            this.tbSexo.TabIndex = 4;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(428, 152);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(186, 20);
            this.tbBairro.TabIndex = 5;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(428, 190);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(186, 20);
            this.tbCidade.TabIndex = 6;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(48, 279);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(649, 363);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbSexo);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Name = "Form1";
            this.Text = "Meu primeiro formulário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbSexo;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lblMensagem;
    }
}

