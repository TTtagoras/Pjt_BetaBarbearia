using Pjt_Projeto.DTO;
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
    public partial class Frm_CadastroDoClinte : Form
    {
        private Clientes clientef;

        public Frm_CadastroDoClinte(int ID, string PrimeiroNome, string UltimoNome, string Telefone, string Email, string Username, string Senha)
        {
            InitializeComponent();

            Lbl_ID.Text = ID.ToString();
            Txt_PrimiroNome.Text = PrimeiroNome;
            Txt_UltimoNome.Text = UltimoNome;
            TxtB_Telefone.Text = Telefone;
            Txt_Email.Text = Email;
            Txt_Username.Text = Username;
            Txt_senha.Text = Senha;
            
        }

        public void Clear()
        {
            Txt_PrimiroNome.Text = "";
            Txt_UltimoNome.Text = "";
            TxtB_Telefone.Text = "";
            Txt_Email.Text = "";
            Txt_Username.Text = "";
            Txt_senha.Text = "";
        }

        public void salvarRegistro()
        {
            try
            {
                this.clientef = new Clientes();
                this.clientef.PrimeiroNome = Txt_PrimiroNome.Text;
                this.clientef.UltimoNome = Txt_UltimoNome.Text;
                this.clientef.Telefone = TxtB_Telefone.Text;
                this.clientef.Email = Txt_Email.Text;
                this.clientef.Username = Txt_Username.Text;
                this.clientef.Senha = Txt_senha.Text;
                this.clientef.CadastrarCliente();
                MessageBox.Show("Registro salvo com sucesso.");
                this.Close();
            }
            catch (Exception c)
            {
                if (c.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Usuário Já existe! ", "Erro no Formulário", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Lbl_NomeDeUsuario.ForeColor = Color.Red;
                    this.Lbl_NomeDeUsuario.Text = "Usuário Duplicado";
                }
                else
                {
                    MessageBox.Show("Não é possivel conectar no banco de dados!" , "Erro no salvamentoo", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                }

            }
        }
     
        private void Frm_CadastroDoClinte_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cadastrar_Click_1(object sender, EventArgs e)
        {
            if (Txt_PrimiroNome.Text.Equals(""))
            {
                Lbl_PrimeiroNome.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu primeiro nome.");
                return;
            }
            if (Txt_UltimoNome.Text.Equals(""))
            {
                Lbl_UltimoNome.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu ultimo nome.");
                return;
            }
            if (TxtB_Telefone.Text.Equals("+55 (  )       -"))
            {
                Lbl_Telefone.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu telefone.");
                return;
            }
            if (Txt_Email.Text.Equals(""))
            {
                Lbl_Email.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu email.");
                return;
            }
            if (Txt_Username.Text.Equals(""))
            {
                Lbl_NomeDeUsuario.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu nome de usuario");
                return;
            }
            if (Txt_senha.Text.Equals(""))
            {
                Lbl_senha.ForeColor = Color.Red;
                MessageBox.Show("Informe a sua senha");
                return;
            }
            Frm_ListarCliente lista = new Frm_ListarCliente();
            lista.listarClientes();
            salvarRegistro();
            

        }

        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            Frm_login voltar = new Frm_login();
            voltar.Show();
        }

        private void Txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_UltimoNome_Click(object sender, EventArgs e)
        {

        }
    }
}
