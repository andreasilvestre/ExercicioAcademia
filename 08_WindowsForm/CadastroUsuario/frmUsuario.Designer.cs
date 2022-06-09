namespace CadastroUsuario
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.pbLimpar = new System.Windows.Forms.PictureBox();
            this.pbSalvar = new System.Windows.Forms.PictureBox();
            this.pbOlhoSenha = new System.Windows.Forms.PictureBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.btCarregarLista = new System.Windows.Forms.Button();
            this.nme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOlhoSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(16, 33);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(13, 90);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 15);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login:";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbStatus.Location = new System.Drawing.Point(17, 222);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(180, 24);
            this.cbStatus.TabIndex = 4;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.cbTipo.Location = new System.Drawing.Point(217, 222);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(180, 24);
            this.cbTipo.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(13, 141);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 15);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(14, 203);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(51, 15);
            this.lbStatus.TabIndex = 13;
            this.lbStatus.Text = "Status:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(214, 203);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 15);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(14, 266);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(67, 15);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(14, 323);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 15);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(16, 52);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(360, 22);
            this.tbNome.TabIndex = 0;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(16, 109);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(360, 22);
            this.tbLogin.TabIndex = 1;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(16, 160);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSenha.MaxLength = 10;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(181, 22);
            this.tbSenha.TabIndex = 2;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // pbLimpar
            // 
            this.pbLimpar.Image = global::CadastroUsuario.Properties.Resources.limpar_limpo;
            this.pbLimpar.Location = new System.Drawing.Point(313, 311);
            this.pbLimpar.Name = "pbLimpar";
            this.pbLimpar.Size = new System.Drawing.Size(79, 53);
            this.pbLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLimpar.TabIndex = 19;
            this.pbLimpar.TabStop = false;
            this.pbLimpar.Click += new System.EventHandler(this.pbLimpar_Click);
            // 
            // pbSalvar
            // 
            this.pbSalvar.Image = global::CadastroUsuario.Properties.Resources.salve_;
            this.pbSalvar.Location = new System.Drawing.Point(228, 310);
            this.pbSalvar.Name = "pbSalvar";
            this.pbSalvar.Size = new System.Drawing.Size(79, 54);
            this.pbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalvar.TabIndex = 18;
            this.pbSalvar.TabStop = false;
            this.pbSalvar.Click += new System.EventHandler(this.pbSalvar_Click);
            // 
            // pbOlhoSenha
            // 
            this.pbOlhoSenha.BackColor = System.Drawing.Color.Pink;
            this.pbOlhoSenha.Image = global::CadastroUsuario.Properties.Resources.olho;
            this.pbOlhoSenha.Location = new System.Drawing.Point(193, 160);
            this.pbOlhoSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbOlhoSenha.Name = "pbOlhoSenha";
            this.pbOlhoSenha.Size = new System.Drawing.Size(30, 22);
            this.pbOlhoSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOlhoSenha.TabIndex = 17;
            this.pbOlhoSenha.TabStop = false;
            this.pbOlhoSenha.Click += new System.EventHandler(this.pbOlhoSenha_Click);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTelefone.Location = new System.Drawing.Point(17, 284);
            this.mtbTelefone.Mask = "(00)00000-0000   ";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(124, 22);
            this.mtbTelefone.TabIndex = 6;
            this.mtbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(17, 342);
            this.mtbCPF.Mask = "000,000,000/00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(124, 22);
            this.mtbCPF.TabIndex = 7;
            this.mtbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // mtbDataNascimento
            // 
            this.mtbDataNascimento.Location = new System.Drawing.Point(241, 160);
            this.mtbDataNascimento.Mask = "00/00/0000";
            this.mtbDataNascimento.Name = "mtbDataNascimento";
            this.mtbDataNascimento.Size = new System.Drawing.Size(124, 22);
            this.mtbDataNascimento.TabIndex = 3;
            this.mtbDataNascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtbDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(238, 141);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(152, 16);
            this.lblDataNascimento.TabIndex = 21;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nme,
            this.login,
            this.senha,
            this.DtNascimento,
            this.status,
            this.tipo,
            this.telefone,
            this.cpf});
            this.dgUsuarios.Location = new System.Drawing.Point(415, 33);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.Size = new System.Drawing.Size(394, 331);
            this.dgUsuarios.TabIndex = 22;
            // 
            // btCarregarLista
            // 
            this.btCarregarLista.Location = new System.Drawing.Point(107, 392);
            this.btCarregarLista.Name = "btCarregarLista";
            this.btCarregarLista.Size = new System.Drawing.Size(200, 44);
            this.btCarregarLista.TabIndex = 23;
            this.btCarregarLista.Text = "&Carregar Lista";
            this.btCarregarLista.UseVisualStyleBackColor = true;
            this.btCarregarLista.Click += new System.EventHandler(this.btCarregarLista_Click);
            // 
            // nme
            // 
            this.nme.HeaderText = "Nome";
            this.nme.Name = "nme";
            this.nme.ReadOnly = true;
            this.nme.Width = 150;
            // 
            // login
            // 
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Width = 150;
            // 
            // senha
            // 
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            // 
            // DtNascimento
            // 
            this.DtNascimento.HeaderText = "Data Nasc.";
            this.DtNascimento.Name = "DtNascimento";
            this.DtNascimento.ReadOnly = true;
            this.DtNascimento.Width = 80;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 130;
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 120;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Width = 120;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(819, 448);
            this.Controls.Add(this.btCarregarLista);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.mtbDataNascimento);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.pbLimpar);
            this.Controls.Add(this.pbSalvar);
            this.Controls.Add(this.pbOlhoSenha);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmUsuario";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOlhoSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.PictureBox pbOlhoSenha;
        private System.Windows.Forms.PictureBox pbSalvar;
        private System.Windows.Forms.PictureBox pbLimpar;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Button btCarregarLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nme;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
    }
}

