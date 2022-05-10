using Pjt_Projeto.Frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pjt_Projeto
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            Frm_login logar = new Frm_login();
            logar.ShowDialog();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Btn_NovoCliente_Click(object sender, EventArgs e)
        {
            int ID = 0;
            string PrimeiroNome = "";
            string UltimoNome = "";
            string Telefone = "";
            string Email = "";
            string Username = "";
            string Senha = "";
            Frm_CadastroDoClinte form = new Frm_CadastroDoClinte(ID, PrimeiroNome, UltimoNome, Telefone, Email, Username, Senha);
            form.Show();
            //listarClientes();
        }

        private void Dgv_QuadroDeHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Btn_PaginaDeListar_Click(object sender, EventArgs e)
        {
            Frm_ListarCliente listar = new Frm_ListarCliente();
            listar.Show();  
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
