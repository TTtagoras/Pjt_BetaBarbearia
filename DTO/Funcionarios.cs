using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pjt_Projeto.DTO
{
    internal class Funcionarios
    {
        private conexaoDB Funcionario;

        private int _ID;
        private string _PrimeiroNome;
        private string _UltimoNome;
        private string _Telefone;
        private string _Email;
        private string _Username;
        private string _Senha;
        private string _Endereco;
        private string _NumeroDaCasa;
        private string _CEP;

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        public string PrimeiroNome
        {
            get
            {
                return _PrimeiroNome;
            }
            set
            {
                _PrimeiroNome = value;
            }
        }

        public string UltimoNome
        {
            get
            {
                return _UltimoNome;
            }
            set
            {
                _UltimoNome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _Telefone;
            }
            set
            {
                _Telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        public string Username
        {
            get
            {
                return _Username;
            }
            set
            {
                _Username = value;
            }
        }

        public string Senha
        {
            get
            {
                return _Senha;
            }
            set
            {
                _Senha = value;
            }
        }

        public string Endereco
        {
            get
            {
                return _Endereco;
            }
            set
            {
                _Endereco = value;
            }
        }

        public string NumeroDaCasa
        {
            get
            {
                return _NumeroDaCasa;
            }
            set
            {
                _NumeroDaCasa = value;
            }
        }

        public string CEP
        {
            get
            {
                return _CEP;
            }
            set
            {
                _CEP = value;
            }
        }

        public Funcionarios()
        {
            this.Funcionario = new conexaoDB();

        }

        public void CadastrarFuncionario()
        {
            this.Funcionario.NonQuery(
                "INSERT INTO `funcionarios`(`PrimeiroNome`, `UltimoNome`, `Telefone`, `Email`, `UserName`, `Senha`, `Endereco`, `NumeroDaCasa`, `CEP`) VALUES('" + PrimeiroNome + "', '" + UltimoNome + "', '" + Telefone + "', '" + Email + "', '" + Username + "', '" + Senha + "', '" + Endereco + "', '" + NumeroDaCasa + "', '" + CEP + "');"
            );
        }

        public void AlterarFucionario(string idCliente)
        {
            this.Funcionario.NonQuery(
                "UPDATE `funcionarios` SET `PrimeiroNome`= '" + PrimeiroNome + "',`UltimoNome`= '" + UltimoNome + "',`Telefone`= '" + Telefone + "',`Email`= '" + Email + "',`UserName`= '" + Username + "',`Senha`= '" + Senha + "', `Endereco`= '" + Endereco + "', `NumeroDaCasa`= '" + NumeroDaCasa + "', `CEP`= '" + CEP + "'  WHERE id = '" + idCliente + "'");
        }

        public MySqlDataReader ListarClientes()
        {
            return this.Funcionario.Query("");
        }

        public MySqlDataReader ListarClientes(String filtro)
        {
            if (filtro == "")
            {
                return ListarClientes();
            }
            return this.Funcionario.Query("Select * from clientes where PrimeiroNome LIKE '%" + filtro + "%' order by PrimeiroNome asc");
        }

            public Funcionarios(int ID, string PrimeiroNome, string UltimoNome, string Telefone, string Email, string Username, string Senha, string Endereco, string NumeroDaCasa, string CEP)
            {
                this.ID = ID;
                this.PrimeiroNome = PrimeiroNome;
                this.UltimoNome = UltimoNome;
                this.Telefone = Telefone;
                this.Email = Email;
                this.Username = Username;
                this.Senha = Senha;
                this.Endereco = Endereco;
                this.NumeroDaCasa = NumeroDaCasa;
                this.CEP = CEP;
            }
        }

    }

