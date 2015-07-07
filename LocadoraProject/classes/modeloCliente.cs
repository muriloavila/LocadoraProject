using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraProject
{
   public class modeloCliente : modelo
    {
        private string email;
        private string telefone;
        private string endereco;
        private string login;
        private string senha;
        private DateTime ultimoLogin;
        private string ultimoFilme;
        private dataControlador data = new dataControlador();

        public string Email
        { 
            get { return email; }
            set { email = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public DateTime UltimoLogin
        {
            get { return ultimoLogin; }
            set { ultimoLogin = value; }
        }

        public string UltimoFilme
        {
            get { return ultimoFilme; }
            set { ultimoFilme = value; }
        }

        public void UpdateLogin()
        {
            data.UpdateLogin(this);
        }
    }
}
