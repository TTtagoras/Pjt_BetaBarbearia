using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Pjt_Projeto.DTO;
using Pjt_Projeto.Frm;

namespace Pjt_Projeto.Frm
{
    public partial class Frm_ListarCliente : Form
    {
        private Clientes clienteD;

        int ID;
        string PrimeiroNome;
        string UltimoNome;
        string Telefone;
        string Email;
        string Username;
        string Senha;

        public Frm_ListarCliente()
        {
            InitializeComponent();
        }

        private void Frm_Lista_Cliente_Load(object sender, EventArgs e)
        {
            listarClientes();
        }

        private void Btn_BuscarCLiente_Click(object sender, EventArgs e)
        {
            String Filtro = Txt_BuscarCliente.Text;
            MySqlDataReader temp = this.clienteD.ListarClientes(Filtro);
            DataTable dt = new DataTable();
            dt.Load(temp);
            DataGrid_LisaDeClinte.DataSource = dt;
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
            listarClientes();
        }
        public void listarClientes()
        {
            this.clienteD = new Clientes();
            MySqlDataReader temp = this.clienteD.ListarClientes();
            DataTable dt = new DataTable();
            dt.Load(temp);
            DataGrid_LisaDeClinte.DataSource = dt;
        }

        private void Btn_Atualizar_Click_1(object sender, EventArgs e)
        {

            listarClientes();

        }

        public void DataGrid_LisaDeClinte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = DataGrid_LisaDeClinte.Rows[e.RowIndex];
            ID = (int)linha.Cells[0].Value;
            PrimeiroNome = linha.Cells[1].Value.ToString();
            UltimoNome = linha.Cells[2].Value.ToString();
            Telefone = linha.Cells[3].Value.ToString();
            Email = linha.Cells[4].Value.ToString();
            Username = linha.Cells[5].Value.ToString();
            Senha = linha.Cells[6].Value.ToString();
            Lbl_NomeDoCliente.Text = PrimeiroNome;
            Lbl_Telefone.Text = Telefone;
        }

        private void Btn_AlterarCliente_Click(object sender, EventArgs e)
        {
            if (PrimeiroNome == null)
            {
                MessageBox.Show("Selecione um primeiro nome");
                return;
            }
            else
            {
                Frm_CadastroDoClinte form = new Frm_CadastroDoClinte(ID, PrimeiroNome, UltimoNome, Telefone, Email, Username, Senha);
                form.Show();
            }

        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {

        }
    }
}
