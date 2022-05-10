namespace Pjt_Projeto
{
    partial class Frm_Principal
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
            this.Btn_Adicioanar = new System.Windows.Forms.Button();
            this.Mc_Calendario = new System.Windows.Forms.MonthCalendar();
            this.Dgv_QuadroDeHorarios = new System.Windows.Forms.DataGridView();
            this.Btn_PaginaDeListar = new System.Windows.Forms.Button();
            this.Btn_NovoCliente = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_QuadroDeHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Adicioanar
            // 
            this.Btn_Adicioanar.Location = new System.Drawing.Point(665, 413);
            this.Btn_Adicioanar.Name = "Btn_Adicioanar";
            this.Btn_Adicioanar.Size = new System.Drawing.Size(123, 25);
            this.Btn_Adicioanar.TabIndex = 0;
            this.Btn_Adicioanar.Text = "Adicionar horario";
            this.Btn_Adicioanar.UseVisualStyleBackColor = true;
            // 
            // Mc_Calendario
            // 
            this.Mc_Calendario.Location = new System.Drawing.Point(9, 8);
            this.Mc_Calendario.Name = "Mc_Calendario";
            this.Mc_Calendario.TabIndex = 1;
            this.Mc_Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Dgv_QuadroDeHorarios
            // 
            this.Dgv_QuadroDeHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_QuadroDeHorarios.Location = new System.Drawing.Point(248, 45);
            this.Dgv_QuadroDeHorarios.Name = "Dgv_QuadroDeHorarios";
            this.Dgv_QuadroDeHorarios.RowTemplate.Height = 25;
            this.Dgv_QuadroDeHorarios.Size = new System.Drawing.Size(540, 361);
            this.Dgv_QuadroDeHorarios.TabIndex = 2;
            this.Dgv_QuadroDeHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_QuadroDeHorarios_CellContentClick);
            // 
            // Btn_PaginaDeListar
            // 
            this.Btn_PaginaDeListar.Location = new System.Drawing.Point(23, 413);
            this.Btn_PaginaDeListar.Name = "Btn_PaginaDeListar";
            this.Btn_PaginaDeListar.Size = new System.Drawing.Size(89, 25);
            this.Btn_PaginaDeListar.TabIndex = 3;
            this.Btn_PaginaDeListar.Text = "Listar Clientes";
            this.Btn_PaginaDeListar.UseVisualStyleBackColor = true;
            this.Btn_PaginaDeListar.Click += new System.EventHandler(this.Btn_PaginaDeListar_Click);
            // 
            // Btn_NovoCliente
            // 
            this.Btn_NovoCliente.Location = new System.Drawing.Point(118, 413);
            this.Btn_NovoCliente.Name = "Btn_NovoCliente";
            this.Btn_NovoCliente.Size = new System.Drawing.Size(89, 25);
            this.Btn_NovoCliente.TabIndex = 9;
            this.Btn_NovoCliente.Text = "Novo Cliente";
            this.Btn_NovoCliente.UseVisualStyleBackColor = true;
            this.Btn_NovoCliente.Click += new System.EventHandler(this.Btn_NovoCliente_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(408, 4);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(239, 38);
            this.hScrollBar1.TabIndex = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.Btn_NovoCliente);
            this.Controls.Add(this.Btn_PaginaDeListar);
            this.Controls.Add(this.Dgv_QuadroDeHorarios);
            this.Controls.Add(this.Mc_Calendario);
            this.Controls.Add(this.Btn_Adicioanar);
            this.Name = "Frm_Principal";
            this.Text = " Principal";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_QuadroDeHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_Adicioanar;
        private MonthCalendar Mc_Calendario;
        private DataGridView Dgv_QuadroDeHorarios;
        private Button Btn_PaginaDeListar;
        private Button Btn_NovoCliente;
        private HScrollBar hScrollBar1;
    }
}