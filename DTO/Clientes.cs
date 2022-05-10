using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pjt_Projeto.DTO
{
    internal class Clientes
    {
        private conexaoDB cliente;

        private int _ID;
        private string _PrimeiroNome;
        private string _UltimoNome;
        private string _Telefone;
        private string _Email;
        private string _Username;
        private string _Senha;
        private string _Ativo;


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

        public string Ativo
        {
            get
            {
                return _Ativo;
            }
            set
            {
                _Ativo = value;
            }
        }

        public Clientes()
        {
            this.cliente = new conexaoDB();

        }

        public void CadastrarCliente()
        {
            this.cliente.NonQuery(
                "INSERT INTO `clientes`(`PrimeiroNome`, `UltimoNome`, `Telefone`, `Email`, `UserName`, `Senha`) VALUES('" + PrimeiroNome + "', '" + UltimoNome + "', '" + Telefone + "', '" + Email + "', '" + Username + "', '" + Senha + "');"
            );
        }

        public void AlterarCliente(string idCliente)
        {
            this.cliente.NonQuery(
                "UPDATE `clientes` SET `PrimeiroNome`= '" + PrimeiroNome + "',`UltimoNome`= '" + UltimoNome + "',`Telefone`= '" + Telefone + "',`Email`= '" + Email + "',`UserName`= '" + Username + "',`Senha`= '" + Senha + "' WHERE id = '" + idCliente + "'"
                );
        }

        public MySqlDataReader ListarClientes()
        {
            return this.cliente.Query("Select * from clientes order by PrimeiroNome asc");
        }

        public MySqlDataReader ListarClientes(String filtro)
        {
            if (filtro == "")
            {
                return ListarClientes();
            }
            return this.cliente.Query("Select * from clientes where PrimeiroNome LIKE '%" + filtro + "%' order by PrimeiroNome asc");
        }

        public Clientes(int ID, string PrimeiroNome, string UltimoNome, string Telefone, string Email, string Username, string Senha)
        {
            this.ID = ID;
            this.PrimeiroNome = PrimeiroNome;
            this.UltimoNome = UltimoNome;
            this.Telefone= Telefone;
            this.Email = Email;
            this.Username = Username;
            this.Senha = Senha;
        }

    }
}