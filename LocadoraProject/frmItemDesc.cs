using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraProject
{
    public partial class frmItemDesc : Form
    {
        modeloDvd dvd = new modeloDvd();
        public frmItemDesc(modeloDvd aDvd)
        {
            InitializeComponent();
            dvd = aDvd;
        }

        private void itemDesc_Load(object sender, EventArgs e)
        {
            
            lblNome.Text = dvd.Nome;
            lblAno.Text = dvd.Ano.ToString();
            lblGenero.Text = dvd.Genero;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nomeDoArquivo = openFileDialog1.FileName;
                dvd.setCapa(nomeDoArquivo);
                pcbCapa.Image = dvd.getCapa();
            }
        }
    }
}
