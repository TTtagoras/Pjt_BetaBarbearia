namespace Pjt_Projeto.Frm
{
    partial class Frm_CadastroDoFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_NomeDeUsuario = new System.Windows.Forms.Label();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Lbl_UltimoNome = new System.Windows.Forms.Label();
            this.Txt_UltimoNome = new System.Windows.Forms.TextBox();
            this.Lbl_PrimeiroNome = new System.Windows.Forms.Label();
            this.Txt_PrimiroNome = new System.Windows.Forms.TextBox();
            this.Lbl_CEP = new System.Windows.Forms.Label();
            this.Txt_CEP = new System.Windows.Forms.TextBox();
            this.Lbl_NumeroDaCasa = new System.Windows.Forms.Label();
            this.Txt_NumeroDaCasa = new System.Windows.Forms.TextBox();
            this.Lbl_Endereço = new System.Windows.Forms.Label();
            this.Txt_Endereco = new System.Windows.Forms.TextBox();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Senha.Location = new System.Drawing.Point(213, 135);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(58, 19);
            this.Lbl_Senha.TabIndex = 28;
            this.Lbl_Senha.Text = "Senha";
            this.Lbl_Senha.Click += new System.EventHandler(this.Lbl_Senha_Click);
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Senha.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Senha.Location = new System.Drawing.Point(213, 157);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '.';
            this.Txt_Senha.PlaceholderText = "Digite aqui sua Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(151, 20);
            this.Txt_Senha.TabIndex = 6;
            this.Txt_Senha.TextChanged += new System.EventHandler(this.Txt_Senha_TextChanged);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Voltar.Location = new System.Drawing.Point(18, 199);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(127, 33);
            this.Btn_Voltar.TabIndex = 26;
            this.Btn_Voltar.Text = "Voltar para  login";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Logar_Click);
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(151, 199);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(130, 33);
            this.Btn_Cadastrar.TabIndex = 10;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // Txt_Telefone
            // 
            this.Txt_Telefone.Location = new System.Drawing.Point(18, 154);
            this.Txt_Telefone.Mask = "+55 (99) 0 0000-0000";
            this.Txt_Telefone.Name = "Txt_Telefone";
            this.Txt_Telefone.Size = new System.Drawing.Size(151, 23);
            this.Txt_Telefone.TabIndex = 3;
            this.Txt_Telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_Telefone_MaskInputRejected);
            // 
            // Lbl_NomeDeUsuario
            // 
            this.Lbl_NomeDeUsuario.AutoSize = true;
            this.Lbl_NomeDeUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_NomeDeUsuario.Location = new System.Drawing.Point(213, 74);
            this.Lbl_NomeDeUsuario.Name = "Lbl_NomeDeUsuario";
            this.Lbl_NomeDeUsuario.Size = new System.Drawing.Size(141, 19);
            this.Lbl_NomeDeUsuario.TabIndex = 23;
            this.Lbl_NomeDeUsuario.Text = "Nome de Usuario";
            this.Lbl_NomeDeUsuario.Click += new System.EventHandler(this.Lbl_NomeDeUsuario_Click);
            // 
            // Txt_Username
            // 
            this.Txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Username.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Username.Location = new System.Drawing.Point(213, 96);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.PlaceholderText = "Digite aqui seu usuario";
            this.Txt_Username.Size = new System.Drawing.Size(151, 20);
            this.Txt_Username.TabIndex = 5;
            this.Txt_Username.TextChanged += new System.EventHandler(this.Txt_Username_TextChanged);
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Email.Location = new System.Drawing.Point(213, 18);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(56, 19);
            this.Lbl_Email.TabIndex = 21;
            this.Lbl_Email.Text = "E-mail";
            this.Lbl_Email.Click += new System.EventHandler(this.Lbl_Email_Click);
            // 
            // Txt_Email
            // 
            this.Txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Email.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Email.Location = new System.Drawing.Point(213, 40);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.PlaceholderText = "Digite aqui seu E-mail";
            this.Txt_Email.Size = new System.Drawing.Size(151, 20);
            this.Txt_Email.TabIndex = 4;
            this.Txt_Email.TextChanged += new System.EventHandler(this.Txt_Email_TextChanged);
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Telefone.Location = new System.Drawing.Point(18, 132);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(74, 19);
            this.Lbl_Telefone.TabIndex = 19;
            this.Lbl_Telefone.Text = "Telefone";
            this.Lbl_Telefone.Click += new System.EventHandler(this.Lbl_Telefone_Click);
            // 
            // Lbl_UltimoNome
            // 
            this.Lbl_UltimoNome.AutoSize = true;
            this.Lbl_UltimoNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_UltimoNome.Location = new System.Drawing.Point(18, 74);
            this.Lbl_UltimoNome.Name = "Lbl_UltimoNome";
            this.Lbl_UltimoNome.Size = new System.Drawing.Size(107, 19);
            this.Lbl_UltimoNome.TabIndex = 18;
            this.Lbl_UltimoNome.Text = "Ultimo Nome";
            this.Lbl_UltimoNome.Click += new System.EventHandler(this.Lbl_UltimoNome_Click);
            // 
            // Txt_UltimoNome
            // 
            this.Txt_UltimoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_UltimoNome.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_UltimoNome.Location = new System.Drawing.Point(18, 96);
            this.Txt_UltimoNome.Name = "Txt_UltimoNome";
            this.Txt_UltimoNome.PlaceholderText = "Digite aqui seu ultimo nome";
            this.Txt_UltimoNome.Size = new System.Drawing.Size(151, 20);
            this.Txt_UltimoNome.TabIndex = 2;
            this.Txt_UltimoNome.TextChanged += new System.EventHandler(this.Txt_UltimoNome_TextChanged);
            // 
            // Lbl_PrimeiroNome
            // 
            this.Lbl_PrimeiroNome.AutoSize = true;
            this.Lbl_PrimeiroNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PrimeiroNome.Location = new System.Drawing.Point(18, 18);
            this.Lbl_PrimeiroNome.Name = "Lbl_PrimeiroNome";
            this.Lbl_PrimeiroNome.Size = new System.Drawing.Size(122, 19);
            this.Lbl_PrimeiroNome.TabIndex = 16;
            this.Lbl_PrimeiroNome.Text = "Primeiro Nome";
            this.Lbl_PrimeiroNome.Click += new System.EventHandler(this.Lbl_PrimeiroNome_Click);
            // 
            // Txt_PrimiroNome
            // 
            this.Txt_PrimiroNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_PrimiroNome.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_PrimiroNome.Location = new System.Drawing.Point(18, 40);
            this.Txt_PrimiroNome.Name = "Txt_PrimiroNome";
            this.Txt_PrimiroNome.PlaceholderText = "Digite aqui seu nome";
            this.Txt_PrimiroNome.Size = new System.Drawing.Size(151, 20);
            this.Txt_PrimiroNome.TabIndex = 1;
            this.Txt_PrimiroNome.TextChanged += new System.EventHandler(this.Txt_PrimiroNome_TextChanged);
            // 
            // Lbl_CEP
            // 
            this.Lbl_CEP.AutoSize = true;
            this.Lbl_CEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_CEP.Location = new System.Drawing.Point(435, 135);
            this.Lbl_CEP.Name = "Lbl_CEP";
            this.Lbl_CEP.Size = new System.Drawing.Size(43, 19);
            this.Lbl_CEP.TabIndex = 34;
            this.Lbl_CEP.Text = "CEP";
            this.Lbl_CEP.Click += new System.EventHandler(this.Lbl_CEP_Click);
            // 
            // Txt_CEP
            // 
            this.Txt_CEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_CEP.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_CEP.Location = new System.Drawing.Point(439, 157);
            this.Txt_CEP.Name = "Txt_CEP";
            this.Txt_CEP.PlaceholderText = "Digite aqui seu CEP";
            this.Txt_CEP.Size = new System.Drawing.Size(151, 20);
            this.Txt_CEP.TabIndex = 9;
            this.Txt_CEP.TextChanged += new System.EventHandler(this.Txt_CEP_TextChanged);
            // 
            // Lbl_NumeroDaCasa
            // 
            this.Lbl_NumeroDaCasa.AutoSize = true;
            this.Lbl_NumeroDaCasa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_NumeroDaCasa.Location = new System.Drawing.Point(439, 74);
            this.Lbl_NumeroDaCasa.Name = "Lbl_NumeroDaCasa";
            this.Lbl_NumeroDaCasa.Size = new System.Drawing.Size(90, 19);
            this.Lbl_NumeroDaCasa.TabIndex = 32;
            this.Lbl_NumeroDaCasa.Text = "Nº da casa";
            this.Lbl_NumeroDaCasa.Click += new System.EventHandler(this.Lbl_NumeroDaCasa_Click);
            // 
            // Txt_NumeroDaCasa
            // 
            this.Txt_NumeroDaCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_NumeroDaCasa.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_NumeroDaCasa.Location = new System.Drawing.Point(439, 96);
            this.Txt_NumeroDaCasa.Name = "Txt_NumeroDaCasa";
            this.Txt_NumeroDaCasa.PlaceholderText = "Digite aqui seu usuario";
            this.Txt_NumeroDaCasa.Size = new System.Drawing.Size(151, 20);
            this.Txt_NumeroDaCasa.TabIndex = 8;
            this.Txt_NumeroDaCasa.TextChanged += new System.EventHandler(this.Txt_NumeroDaCasa_TextChanged);
            // 
            // Lbl_Endereço
            // 
            this.Lbl_Endereço.AutoSize = true;
            this.Lbl_Endereço.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Endereço.Location = new System.Drawing.Point(439, 18);
            this.Lbl_Endereço.Name = "Lbl_Endereço";
            this.Lbl_Endereço.Size = new System.Drawing.Size(83, 19);
            this.Lbl_Endereço.TabIndex = 30;
            this.Lbl_Endereço.Text = "Endereço";
            this.Lbl_Endereço.Click += new System.EventHandler(this.Lbl_Endereço_Click);
            // 
            // Txt_Endereco
            // 
            this.Txt_Endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Endereco.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Endereco.Location = new System.Drawing.Point(439, 40);
            this.Txt_Endereco.Name = "Txt_Endereco";
            this.Txt_Endereco.PlaceholderText = "Digite aqui seu endereço";
            this.Txt_Endereco.Size = new System.Drawing.Size(151, 20);
            this.Txt_Endereco.TabIndex = 7;
            this.Txt_Endereco.TextChanged += new System.EventHandler(this.Txt_Endereco_TextChanged);
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(604, 244);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(0, 15);
            this.Lbl_ID.TabIndex = 35;
            // 
            // Frm_CadastroDoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 264);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Lbl_CEP);
            this.Controls.Add(this.Txt_CEP);
            this.Controls.Add(this.Lbl_NumeroDaCasa);
            this.Controls.Add(this.Txt_NumeroDaCasa);
            this.Controls.Add(this.Lbl_Endereço);
            this.Controls.Add(this.Txt_Endereco);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.Txt_Telefone);
            this.Controls.Add(this.Lbl_NomeDeUsuario);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Lbl_Telefone);
            this.Controls.Add(this.Lbl_UltimoNome);
            this.Controls.Add(this.Txt_UltimoNome);
            this.Controls.Add(this.Lbl_PrimeiroNome);
            this.Controls.Add(this.Txt_PrimiroNome);
            this.Name = "Frm_CadastroDoFuncionario";
            this.Text = "Frm_Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_Senha;
        private TextBox Txt_Senha;
        private Button Btn_Voltar;
        private Button Btn_Cadastrar;
        private MaskedTextBox Txt_Telefone;
        private Label Lbl_NomeDeUsuario;
        private TextBox Txt_Username;
        private Label Lbl_Email;
        private TextBox Txt_Email;
        private Label Lbl_Telefone;
        private Label Lbl_UltimoNome;
        private TextBox Txt_UltimoNome;
        private Label Lbl_PrimeiroNome;
        private TextBox Txt_PrimiroNome;
        private Label Lbl_CEP;
        private TextBox Txt_CEP;
        private Label Lbl_NumeroDaCasa;
        private TextBox Txt_NumeroDaCasa;
        private Label Lbl_Endereço;
        private TextBox Txt_Endereco;
        private Label Lbl_ID;
    }
}