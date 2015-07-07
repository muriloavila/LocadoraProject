using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Criado por Murilo Nogueira. 04/07/2015
 * Modelo De classe muito bom vou usa-lo varias vezes, só mudar as variaveis,
 * \o/
 */
namespace LocadoraProject
{
    public class modelo
    {
        private int id;
        private string nome;
        dataControlador data = new dataControlador();
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<modeloDvd> Selecionar()
        {
            return data.Selecionar();
        }

        public modeloDvd SelecionarDesc(int id)
        {
            return data.SelecionarDesc(this.Id);
        }
    }
}
