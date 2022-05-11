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
using Pjt_Projeto.Frm;

namespace Pjt_Projeto
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();

          
        }

        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            if ((Txt_Username.Text == "") || (Txt_senha.Text == ""))
            {
                MessageBox.Show("É necessario preencher todos os campos.");

                //Txt_Username.ForeColor = Color.Red;
                //    MessageBox.Show("Informe o seu primeiro nome.");
                //    return;

                //Txt_senha.ForeColor = Color.Red;
                //    MessageBox.Show("Informe o seu ultimo nome.");
                //    return;
                

                //comentário novo :D
            }
            else
            {
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=cadastros; password=root;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();
                    string comando = "SELECT * from `cadastros`.`clientes` WHERE (Username='" + Txt_Username.Text+ "' and Senha='" + Txt_senha.Text+"');";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();
                    if (logado.HasRows)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("login ou senha incorretos");
                        Txt_Username.Text = "";
                        Txt_senha.Text = "";
                    }
                    conexao.Close();

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //if(Txt_Username.Text == "eueu" && Txt_senha.Text == "123")
            //{
            //    this.Close();
               
            //}
            //if (Txt_Username.Text == "" || Txt_senha.Text == "")
            //{
            //    MessageBox.Show("É necessario preencher todos os campos");
            //}
            //if(Txt_Username.Text != "eueu" || Txt_senha.Text != "123")
            //{
            //    MessageBox.Show("Nome de usuario ou senha incorretos");
            //    Txt_Username.Text = "";
            //    Txt_senha.Text = "";
            //}


        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            int ID = 0;
            string PrimeiroNome = "";
            string UltimoNome = "";
            string Telefone = "";
            string Email = "";
            string Username = "";
            string Senha = "";


            Frm_CadastroDoClinte Cadastro = new Frm_CadastroDoClinte(ID, PrimeiroNome, UltimoNome, Telefone, Email, Username, Senha);
            Cadastro.Show();
        }

        private void Btn_CadastrarFuncionario_Click(object sender, EventArgs e)
        {
            int ID = 0;
            string PrimeiroNome = "";
            string UltimoNome = "";
            string Telefone = "";
            string Email = "";
            string Username = "";
            string Senha = "";
            string Endereco = "";
            string NumeroDaCasa = "";
            string CEP = "";


            Frm_CadastroDoFuncionario Cadastro = new Frm_CadastroDoFuncionario(ID, PrimeiroNome, UltimoNome, Telefone, Email, Username, Senha, Endereco, NumeroDaCasa, CEP);
            Cadastro.Show();
             
        }

        private void Lbl_NomeDeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
             
        }

        private void Txt_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
