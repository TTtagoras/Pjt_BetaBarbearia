using Pjt_Projeto.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pjt_Projeto.Frm
{
    public partial class Frm_CadastroDoFuncionario : Form
    {
        private Funcionarios funcionario;

        public Frm_CadastroDoFuncionario(int ID, string PrimeiroNome, string UltimoNome, string Telefone, string Email, string Username, string Senha, string Endereco, string NumeroDaCasa, string CEP)
        {
            InitializeComponent();

            Lbl_ID.Text = ID.ToString();
            Txt_PrimiroNome.Text = PrimeiroNome;
            Txt_UltimoNome.Text = UltimoNome;
            Txt_Telefone.Text = Telefone;
            Txt_Email.Text = Email;
            Txt_Username.Text = Username;
            Txt_Senha.Text = Senha;
            Txt_Endereco.Text = Endereco;
            Txt_NumeroDaCasa.Text = NumeroDaCasa;
            Txt_CEP.Text = CEP;
        }

        public void salvarRegistro()
        {
            try
            {
                this.funcionario = new Funcionarios();
                this.funcionario.PrimeiroNome = Txt_PrimiroNome.Text;
                this.funcionario.UltimoNome = Txt_UltimoNome.Text;
                this.funcionario.Telefone = Txt_Telefone.Text;
                this.funcionario.Email = Txt_Email.Text;
                this.funcionario.Username = Txt_Username.Text;
                this.funcionario.Senha = Txt_Senha.Text;
                this.funcionario.Endereco = Txt_Endereco.Text;
                this.funcionario.NumeroDaCasa = Txt_NumeroDaCasa.Text;
                this.funcionario.CEP = Txt_CEP.Text;
                this.funcionario.CadastrarFuncionario();
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
                    MessageBox.Show("Não é possivel conectar no banco de dados!", "Erro no salvamentoo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
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
                MessageBox.Show("Informe o seuultimo nome.");
                return;
            }
            if (Txt_Telefone.Text.Equals("+55 (  )       -"))
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
            if (Txt_Senha.Text.Equals(""))
            {
                Lbl_Senha.ForeColor = Color.Red;
                MessageBox.Show("Informe a sua senha");
                return;
            }
            if (Txt_Endereco.Text.Equals(""))
            {
                Lbl_Endereço.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu ndereço.");
                return;
            }
            if (Txt_NumeroDaCasa.Text.Equals(""))
            {
                Lbl_NumeroDaCasa.ForeColor = Color.Red;
                MessageBox.Show("Informe o numero da sua casa.");
                return;
            }
            if (Txt_CEP.Text.Equals(""))
            {
                Lbl_CEP.ForeColor = Color.Red;
                MessageBox.Show("Informe o seu CEP.");
                return;
            }
            Frm_ListarCliente lista = new Frm_ListarCliente();
            lista.listarClientes();
            salvarRegistro();
        }

        private void Txt_Telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Txt_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            Frm_login voltar = new Frm_login();
            voltar.Show();
        }

        private void Lbl_UltimoNome_Click(object sender, EventArgs e)
        {

        }

        private void Txt_CEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_NumeroDaCasa_Click(object sender, EventArgs e)
        {

        }

        private void Txt_NumeroDaCasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Endereço_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Senha_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_NomeDeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Telefone_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_CEP_Click(object sender, EventArgs e)
        {

        }

        private void Txt_UltimoNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_PrimeiroNome_Click(object sender, EventArgs e)
        {

        }

        private void Txt_PrimiroNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
