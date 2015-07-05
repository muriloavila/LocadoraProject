using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraProject
{
   protected class dataControlador
    {
        dblocadoraDataContext dblocadora = new dblocadoraDataContext();
        public void Inserir(modeloDvd dvd)
        {
            tabDvd nDvd = new tabDvd();
            nDvd.nome = dvd.Nome;
            nDvd.ano = dvd.Ano;
            nDvd.genero = dvd.Genero;

            dblocadora.tabDvds.InsertOnSubmit(nDvd);
            dblocadora.SubmitChanges();
        }
    }
}
