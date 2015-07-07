using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace LocadoraProject
{
    public class modeloDvd : modelo
    {
        private int ano;
        private string genero;
        private byte[] capa;
        private dataControlador data = new dataControlador();

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public byte[] Capa
        {
            get { return capa; }
            set { capa = value; }
        }
        public void setCapa(string imagemLocal)
        {
            Bitmap bmp = new Bitmap(imagemLocal);
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Bmp);
            this.Capa = ms.ToArray();
        }

        public Image getCapa()
        {
            MemoryStream ms = new MemoryStream(this.Capa);
            Image imagem = Image.FromStream(ms);
            return imagem;
        }
    }
}
