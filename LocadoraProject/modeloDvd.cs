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
    class modeloDvd
    {
        private int id;
        private string nome;
        private int ano;
        private string genero;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = RemoverAcentos(value).Replace("\\", "\\\\").Replace("'", "\"\'\"").Replace(";", "\";\""); }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = RemoverAcentos(value).Replace("\\", "\\\\").Replace("'", "\"\'\"").Replace(";", "\";\""); }
        }

        public string RemoverAcentos(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";
            else
            {
                byte[] bytes = System.Text.Encoding.GetEncoding("iso-8859-8").GetBytes(input);
                return System.Text.Encoding.UTF8.GetString(bytes);
            }
        }

        public void Inserir(){
            dataControlador dc = new dataControlador();
            dc.Inserir(this);
        }
    }
}
