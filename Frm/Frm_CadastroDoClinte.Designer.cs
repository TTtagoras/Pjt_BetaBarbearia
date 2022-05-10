namespace Pjt_Projeto
{
    partial class Frm_CadastroDoClinte
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
            this.Txt_PrimiroNome = new System.Windows.Forms.TextBox();
            this.Lbl_PrimeiroNome = new System.Windows.Forms.Label();
            this.Lbl_UltimoNome = new System.Windows.Forms.Label();
            this.Txt_UltimoNome = new System.Windows.Forms.TextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.Lbl_NomeDeUsuario = new System.Windows.Forms.Label();
            this.TxtB_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Btn_Logar = new System.Windows.Forms.Button();
            this.Lbl_senha = new System.Windows.Forms.Label();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_PrimiroNome
            // 
            this.Txt_PrimiroNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_PrimiroNome.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_PrimiroNome.Location = new System.Drawing.Point(12, 34);
            this.Txt_PrimiroNome.Name = "Txt_PrimiroNome";
            this.Txt_PrimiroNome.PlaceholderText = "Digite aqui seu nome";
            this.Txt_PrimiroNome.Size = new System.Drawing.Size(151, 20);
            this.Txt_PrimiroNome.TabIndex = 1;
            // 
            // Lbl_PrimeiroNome
            // 
            this.Lbl_PrimeiroNome.AutoSize = true;
            this.Lbl_PrimeiroNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PrimeiroNome.Location = new System.Drawing.Point(12, 12);
            this.Lbl_PrimeiroNome.Name = "Lbl_PrimeiroNome";
            this.Lbl_PrimeiroNome.Size = new System.Drawing.Size(122, 19);
            this.Lbl_PrimeiroNome.TabIndex = 1;
            this.Lbl_PrimeiroNome.Text = "Primeiro Nome";
            // 
            // Lbl_UltimoNome
            // 
            this.Lbl_UltimoNome.AutoSize = true;
            this.Lbl_UltimoNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_UltimoNome.Location = new System.Drawing.Point(12, 68);
            this.Lbl_UltimoNome.Name = "Lbl_UltimoNome";
            this.Lbl_UltimoNome.Size = new System.Drawing.Size(107, 19);
            this.Lbl_UltimoNome.TabIndex = 3;
            this.Lbl_UltimoNome.Text = "Ultimo Nome";
            this.Lbl_UltimoNome.Click += new System.EventHandler(this.Lbl_UltimoNome_Click);
            // 
            // Txt_UltimoNome
            // 
            this.Txt_UltimoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_UltimoNome.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_UltimoNome.Location = new System.Drawing.Point(12, 90);
            this.Txt_UltimoNome.Name = "Txt_UltimoNome";
            this.Txt_UltimoNome.PlaceholderText = "Digite aqui seu ultimo nome";
            this.Txt_UltimoNome.Size = new System.Drawing.Size(151, 20);
            this.Txt_UltimoNome.TabIndex = 2;
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Telefone.Location = new System.Drawing.Point(12, 127);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(74, 19);
            this.Lbl_Telefone.TabIndex = 5;
            this.Lbl_Telefone.Text = "Telefone";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Email.Location = new System.Drawing.Point(207, 12);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(56, 19);
            this.Lbl_Email.TabIndex = 7;
            this.Lbl_Email.Text = "E-mail";
            // 
            // Txt_Email
            // 
            this.Txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Email.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Email.Location = new System.Drawing.Point(207, 34);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.PlaceholderText = "Digite aqui se E-mail";
            this.Txt_Email.Size = new System.Drawing.Size(151, 20);
            this.Txt_Email.TabIndex = 4;
            // 
            // Txt_Username
            // 
            this.Txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Username.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Username.Location = new System.Drawing.Point(207, 90);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.PlaceholderText = "Digite aqui seu usuario";
            this.Txt_Username.Size = new System.Drawing.Size(151, 20);
            this.Txt_Username.TabIndex = 5;
            this.Txt_Username.TextChanged += new System.EventHandler(this.Txt_Username_TextChanged);
            // 
            // Lbl_NomeDeUsuario
            // 
            this.Lbl_NomeDeUsuario.AutoSize = true;
            this.Lbl_NomeDeUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_NomeDeUsuario.Location = new System.Drawing.Point(207, 68);
            this.Lbl_NomeDeUsuario.Name = "Lbl_NomeDeUsuario";
            this.Lbl_NomeDeUsuario.Size = new System.Drawing.Size(141, 19);
            this.Lbl_NomeDeUsuario.TabIndex = 9;
            this.Lbl_NomeDeUsuario.Text = "Nome de Usuario";
            // 
            // TxtB_Telefone
            // 
            this.TxtB_Telefone.Location = new System.Drawing.Point(12, 149);
            this.TxtB_Telefone.Mask = "+55 (99) 0 0000-0000";
            this.TxtB_Telefone.Name = "TxtB_Telefone";
            this.TxtB_Telefone.Size = new System.Drawing.Size(151, 23);
            this.TxtB_Telefone.TabIndex = 3;
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(207, 188);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(130, 33);
            this.Btn_Cadastrar.TabIndex = 7;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click_1);
            // 
            // Btn_Logar
            // 
            this.Btn_Logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Logar.Location = new System.Drawing.Point(12, 188);
            this.Btn_Logar.Name = "Btn_Logar";
            this.Btn_Logar.Size = new System.Drawing.Size(127, 43);
            this.Btn_Logar.TabIndex = 8;
            this.Btn_Logar.Text = "Voltar para o login";
            this.Btn_Logar.UseVisualStyleBackColor = true;
            this.Btn_Logar.Click += new System.EventHandler(this.Btn_Logar_Click);
            // 
            // Lbl_senha
            // 
            this.Lbl_senha.AutoSize = true;
            this.Lbl_senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_senha.Location = new System.Drawing.Point(207, 130);
            this.Lbl_senha.Name = "Lbl_senha";
            this.Lbl_senha.Size = new System.Drawing.Size(58, 19);
            this.Lbl_senha.TabIndex = 14;
            this.Lbl_senha.Text = "Senha";
            // 
            // Txt_senha
            // 
            this.Txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_senha.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_senha.Location = new System.Drawing.Point(207, 152);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.PasswordChar = '.';
            this.Txt_senha.PlaceholderText = "Digite aqui sua Senha";
            this.Txt_senha.Size = new System.Drawing.Size(151, 20);
            this.Txt_senha.TabIndex = 6;
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(337, 224);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(0, 15);
            this.Lbl_ID.TabIndex = 15;
            // 
            // Frm_CadastroDoClinte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 243);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.Lbl_senha);
            this.Controls.Add(this.Txt_senha);
            this.Controls.Add(this.Btn_Logar);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.TxtB_Telefone);
            this.Controls.Add(this.Lbl_NomeDeUsuario);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Lbl_Telefone);
            this.Controls.Add(this.Lbl_UltimoNome);
            this.Controls.Add(this.Txt_UltimoNome);
            this.Controls.Add(this.Lbl_PrimeiroNome);
            this.Controls.Add(this.Txt_PrimiroNome);
            this.Name = "Frm_CadastroDoClinte";
            this.Text = "Cadasro do Cliente";
            this.Load += new System.EventHandler(this.Frm_CadastroDoClinte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Txt_PrimiroNome;
        private Label Lbl_PrimeiroNome;
        private Label Lbl_UltimoNome;
        private TextBox Txt_UltimoNome;
        private Label Lbl_Telefone;
        private Label Lbl_Email;
        private TextBox Txt_Email;
        private TextBox Txt_Username;
        private Label Lbl_NomeDeUsuario;
        private MaskedTextBox TxtB_Telefone;
        private Button Btn_Cadastrar;
        private Button Btn_Logar;
        private Label Lbl_senha;
        private TextBox Txt_senha;
        private Label Lbl_ID;
    }
}