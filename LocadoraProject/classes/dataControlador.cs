using LocadoraProject.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraProject
{
   public class dataControlador
    {
        private dblocadoraDataContext dblocadora = new dblocadoraDataContext();

        public modeloAdm LoginAdm(string login, string senha)
        {
            modeloAdm admin = new modeloAdm();
            var queryLogin =
                from administrador in dblocadora.tabAdms
                where administrador.login == login
                where administrador.senha == senha
                select administrador;
            if (queryLogin.Count() > 0) 
            {
                foreach (var adm in queryLogin)
                {
                    admin.Id = adm.Id;
                    admin.Nome = adm.nome;
                    admin.Login = adm.login;
                    admin.Email = adm.email;
                    admin.Senha = adm.senha;
                }
                return admin;
            } 
            else { return null; }
        }

        public modeloCliente LoginCliente(string login, string senha)
        {
            modeloCliente usuario = new modeloCliente();
             var queryLoginUser =
                    from cliente in dblocadora.tabClientes
                    where cliente.login == login
                    where cliente.senha == senha
                    select cliente;
                if (queryLoginUser.Count() > 0){
                    foreach (var cliente in queryLoginUser)
                    {
                        usuario.Id = cliente.Id;
                        usuario.Nome = cliente.nome;
                        usuario.Email = cliente.email;
                        usuario.Telefone = cliente.telefone;
                        usuario.Endereco = cliente.endereco;
                        usuario.Login = cliente.login;
                        usuario.Senha = cliente.senha;
                        usuario.UltimoLogin = Convert.ToDateTime(cliente.ultimoLogin);
                        usuario.UltimoFilme = cliente.ultimoFilme;
                    }
                    return usuario;
                }
                else{return null;}
        }
        
       public List<modeloDvd> Selecionar()
        {
            List<modeloDvd> listaDvd = new List<modeloDvd>();
            var queryDvd =
                from dvds in dblocadora.tabDvds
                select dvds;
            foreach (var dvdModel in queryDvd)
            {
                modeloDvd dvd = new modeloDvd();
                dvd.Id = dvdModel.Id;
                dvd.Nome = dvdModel.nome;
                dvd.Ano = Convert.ToInt32(dvdModel.ano);
                dvd.Genero = dvdModel.genero;
                listaDvd.Add(dvd);
            }
            return listaDvd;
        }

       public modeloDvd SelecionarDesc(int id)
       {
           modeloDvd dvd = new modeloDvd();
           var queryDvd =
               from nDvd in dblocadora.tabDvds
               where nDvd.Id == id
               select nDvd;
           foreach (var aDvd in queryDvd)
           {
               if (aDvd.Id == id)
               {
                   dvd.Id = aDvd.Id;
                   dvd.Nome = aDvd.nome;
                   dvd.Ano = Convert.ToInt32(aDvd.ano);
                   dvd.Genero = aDvd.genero;
                   //dvd.Capa = aDvd.capa.ToArray();
               }
           }
           return dvd;
       }

       public void UpdateLogin(modeloCliente cliente)
       {
           var queryCliente =
               from nCliente in dblocadora.tabClientes
               where nCliente.Id == cliente.Id
               select nCliente;
           foreach (var clienteLogin in queryCliente)
           {
               clienteLogin.ultimoLogin = DateTime.Today;
               dblocadora.SubmitChanges();
               cliente.UltimoLogin = Convert.ToDateTime(clienteLogin.ultimoLogin);
           }
       }

       public List<tabCliente> SelecionarClientes()
       {
           List<tabCliente> listaCliente = new List<tabCliente>();
           var querySelectClientes =
               from clientes in dblocadora.tabClientes
               select clientes;
           foreach (var cliente in querySelectClientes)
           {
               listaCliente.Add(cliente);
           }
           return listaCliente;
       }
    }
}
