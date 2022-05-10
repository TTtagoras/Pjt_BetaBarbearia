namespace Pjt_Projeto
{
    partial class Frm_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.Btn_Logar = new System.Windows.Forms.Button();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Lbl_NomeDeUsuario = new System.Windows.Forms.Label();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.Btn_CadastrarFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Senha";
            // 
            // Txt_senha
            // 
            this.Txt_senha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_senha.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_senha.Location = new System.Drawing.Point(65, 106);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.PasswordChar = '.';
            this.Txt_senha.PlaceholderText = "Digite aqui sua Senha";
            this.Txt_senha.Size = new System.Drawing.Size(151, 20);
            this.Txt_senha.TabIndex = 1;
            // 
            // Btn_Logar
            // 
            this.Btn_Logar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Logar.Location = new System.Drawing.Point(78, 149);
            this.Btn_Logar.Name = "Btn_Logar";
            this.Btn_Logar.Size = new System.Drawing.Size(127, 33);
            this.Btn_Logar.TabIndex = 2;
            this.Btn_Logar.Text = "Logar";
            this.Btn_Logar.UseVisualStyleBackColor = true;
            this.Btn_Logar.Click += new System.EventHandler(this.Btn_Logar_Click);
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(8, 197);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(127, 47);
            this.Btn_Cadastrar.TabIndex = 3;
            this.Btn_Cadastrar.Text = "criar cadastro como Cliente";
            this.Btn_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // Lbl_NomeDeUsuario
            // 
            this.Lbl_NomeDeUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_NomeDeUsuario.AutoSize = true;
            this.Lbl_NomeDeUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_NomeDeUsuario.Location = new System.Drawing.Point(65, 39);
            this.Lbl_NomeDeUsuario.Name = "Lbl_NomeDeUsuario";
            this.Lbl_NomeDeUsuario.Size = new System.Drawing.Size(141, 19);
            this.Lbl_NomeDeUsuario.TabIndex = 23;
            this.Lbl_NomeDeUsuario.Text = "Nome de Usuario";
            this.Lbl_NomeDeUsuario.Click += new System.EventHandler(this.Lbl_NomeDeUsuario_Click);
            // 
            // Txt_Username
            // 
            this.Txt_Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Username.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Username.Location = new System.Drawing.Point(65, 61);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.PlaceholderText = "Digite aqui seu usuario";
            this.Txt_Username.Size = new System.Drawing.Size(151, 20);
            this.Txt_Username.TabIndex = 0;
            this.Txt_Username.TextChanged += new System.EventHandler(this.Txt_Username_TextChanged);
            // 
            // Btn_CadastrarFuncionario
            // 
            this.Btn_CadastrarFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_CadastrarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CadastrarFuncionario.Location = new System.Drawing.Point(141, 197);
            this.Btn_CadastrarFuncionario.Name = "Btn_CadastrarFuncionario";
            this.Btn_CadastrarFuncionario.Size = new System.Drawing.Size(127, 47);
            this.Btn_CadastrarFuncionario.TabIndex = 4;
            this.Btn_CadastrarFuncionario.Text = "Criar cadastro como funcionario";
            this.Btn_CadastrarFuncionario.UseVisualStyleBackColor = true;
            this.Btn_CadastrarFuncionario.Click += new System.EventHandler(this.Btn_CadastrarFuncionario_Click);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 264);
            this.Controls.Add(this.Btn_CadastrarFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_senha);
            this.Controls.Add(this.Btn_Logar);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.Lbl_NomeDeUsuario);
            this.Controls.Add(this.Txt_Username);
            this.Name = "Frm_login";
            this.Text = "Frm_login";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Txt_senha;
        private Button Btn_Logar;
        private Button Btn_Cadastrar;
        private Label Lbl_NomeDeUsuario;
        private TextBox Txt_Username;
        private Button Btn_CadastrarFuncionario;
    }
}