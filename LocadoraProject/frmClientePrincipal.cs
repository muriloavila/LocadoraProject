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
    public partial class frmClientePrincipal : Form
    {
        modeloCliente usuario = new modeloCliente();
        public frmClientePrincipal(modeloCliente cliente)
        {
            InitializeComponent();
            usuario = cliente;
        }

        private void frmClientePrincipal_Load(object sender, EventArgs e)
        {
            
            List<modeloDvd> listaDvd = usuario.Selecionar();
            foreach (modeloDvd dvd in listaDvd)
            {
                dataGridView1.Rows.Add(dvd.Id.ToString(), dvd.Nome, dvd.Ano, dvd.Genero);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            frmItemDesc itemDesc = new frmItemDesc(usuario.SelecionarDesc(id));
            itemDesc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario.UpdateLogin();
            button1.Text = usuario.UltimoLogin.ToString();
        }
    }
}
