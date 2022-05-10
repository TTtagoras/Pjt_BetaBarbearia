namespace Pjt_Projeto.Frm
{
    partial class Frm_ListarCliente
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
            this.Lbl_BuscarCliente = new System.Windows.Forms.Label();
            this.Txt_BuscarCliente = new System.Windows.Forms.TextBox();
            this.Btn_BuscarCLiente = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.DataGrid_LisaDeClinte = new System.Windows.Forms.DataGridView();
            this.Btn_NovoCliente = new System.Windows.Forms.Button();
            this.Btn_AlterarCliente = new System.Windows.Forms.Button();
            this.Lbl_NomeDoCliente = new System.Windows.Forms.Label();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_LisaDeClinte)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_BuscarCliente
            // 
            this.Lbl_BuscarCliente.AutoSize = true;
            this.Lbl_BuscarCliente.Location = new System.Drawing.Point(12, 18);
            this.Lbl_BuscarCliente.Name = "Lbl_BuscarCliente";
            this.Lbl_BuscarCliente.Size = new System.Drawing.Size(82, 15);
            this.Lbl_BuscarCliente.TabIndex = 0;
            this.Lbl_BuscarCliente.Text = "Buscar Cliente";
            // 
            // Txt_BuscarCliente
            // 
            this.Txt_BuscarCliente.Location = new System.Drawing.Point(12, 36);
            this.Txt_BuscarCliente.Name = "Txt_BuscarCliente";
            this.Txt_BuscarCliente.Size = new System.Drawing.Size(330, 23);
            this.Txt_BuscarCliente.TabIndex = 1;
            // 
            // Btn_BuscarCLiente
            // 
            this.Btn_BuscarCLiente.Location = new System.Drawing.Point(369, 36);
            this.Btn_BuscarCLiente.Name = "Btn_BuscarCLiente";
            this.Btn_BuscarCLiente.Size = new System.Drawing.Size(75, 23);
            this.Btn_BuscarCLiente.TabIndex = 2;
            this.Btn_BuscarCLiente.Text = "Buscar";
            this.Btn_BuscarCLiente.UseVisualStyleBackColor = true;
            this.Btn_BuscarCLiente.Click += new System.EventHandler(this.Btn_BuscarCLiente_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(12, 415);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(86, 23);
            this.Btn_Excluir.TabIndex = 3;
            this.Btn_Excluir.Text = "Excluir";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.Location = new System.Drawing.Point(450, 36);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Atualizar.TabIndex = 4;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = true;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click_1);
            // 
            // DataGrid_LisaDeClinte
            // 
            this.DataGrid_LisaDeClinte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_LisaDeClinte.Location = new System.Drawing.Point(12, 65);
            this.DataGrid_LisaDeClinte.Name = "DataGrid_LisaDeClinte";
            this.DataGrid_LisaDeClinte.RowTemplate.Height = 25;
            this.DataGrid_LisaDeClinte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_LisaDeClinte.Size = new System.Drawing.Size(776, 344);
            this.DataGrid_LisaDeClinte.TabIndex = 7;
            this.DataGrid_LisaDeClinte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_LisaDeClinte_CellContentClick);
            // 
            // Btn_NovoCliente
            // 
            this.Btn_NovoCliente.Location = new System.Drawing.Point(588, 415);
            this.Btn_NovoCliente.Name = "Btn_NovoCliente";
            this.Btn_NovoCliente.Size = new System.Drawing.Size(89, 23);
            this.Btn_NovoCliente.TabIndex = 8;
            this.Btn_NovoCliente.Text = "Novo Cliente";
            this.Btn_NovoCliente.UseVisualStyleBackColor = true;
            this.Btn_NovoCliente.Click += new System.EventHandler(this.Btn_NovoCliente_Click);
            // 
            // Btn_AlterarCliente
            // 
            this.Btn_AlterarCliente.Location = new System.Drawing.Point(683, 415);
            this.Btn_AlterarCliente.Name = "Btn_AlterarCliente";
            this.Btn_AlterarCliente.Size = new System.Drawing.Size(105, 23);
            this.Btn_AlterarCliente.TabIndex = 9;
            this.Btn_AlterarCliente.Text = "Alterar Cliente";
            this.Btn_AlterarCliente.UseVisualStyleBackColor = true;
            this.Btn_AlterarCliente.Click += new System.EventHandler(this.Btn_AlterarCliente_Click);
            // 
            // Lbl_NomeDoCliente
            // 
            this.Lbl_NomeDoCliente.AutoSize = true;
            this.Lbl_NomeDoCliente.Location = new System.Drawing.Point(550, 18);
            this.Lbl_NomeDoCliente.Name = "Lbl_NomeDoCliente";
            this.Lbl_NomeDoCliente.Size = new System.Drawing.Size(19, 15);
            this.Lbl_NomeDoCliente.TabIndex = 10;
            this.Lbl_NomeDoCliente.Text = "....";
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Location = new System.Drawing.Point(550, 39);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(19, 15);
            this.Lbl_Telefone.TabIndex = 11;
            this.Lbl_Telefone.Text = "....";
            // 
            // Frm_ListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Telefone);
            this.Controls.Add(this.Lbl_NomeDoCliente);
            this.Controls.Add(this.Btn_AlterarCliente);
            this.Controls.Add(this.Btn_NovoCliente);
            this.Controls.Add(this.DataGrid_LisaDeClinte);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_BuscarCLiente);
            this.Controls.Add(this.Txt_BuscarCliente);
            this.Controls.Add(this.Lbl_BuscarCliente);
            this.Name = "Frm_ListarCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Lista_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_LisaDeClinte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_BuscarCliente;
        private TextBox Txt_BuscarCliente;
        private Button Btn_BuscarCLiente;
        private Button Btn_Excluir;
        private Button Btn_Atualizar;
        private DataGridView DataGrid_LisaDeClinte;
        private Button Btn_NovoCliente;
        private Button Btn_AlterarCliente;
        private Label Lbl_NomeDoCliente;
        private Label Lbl_Telefone;
    }
}