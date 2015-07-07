using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraProject.classes
{
    public class modeloAdm : modelo
    {
        private string login;
        private string email;
        private string senha;
        private dataControlador data = new dataControlador();

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public List<modeloDvd> Selecionar()
        {
            return data.Selecionar();
        }

        public List<modeloCliente> SelecionarClientes()
        {
            List<modeloCliente> listaClientes = new List<modeloCliente>();
            List<tabCliente> listaTab = data.SelecionarClientes();
            foreach (var clientes in listaTab)
            {
                modeloCliente cliente = new modeloCliente();
                cliente.Id = clientes.Id;
                cliente.Nome = clientes.nome;
                cliente.Email = clientes.email;
                cliente.Telefone = clientes.telefone;
                cliente.Endereco = clientes.endereco;
                cliente.Login = clientes.login;
                cliente.Senha = clientes.senha;
                cliente.UltimoFilme = clientes.ultimoFilme;
                cliente.UltimoLogin = Convert.ToDateTime(clientes.ultimoLogin);
                listaClientes.Add(cliente);
            }
            return listaClientes;
        }
    }
}
