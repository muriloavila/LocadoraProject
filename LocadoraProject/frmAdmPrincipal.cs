using LocadoraProject.classes;
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
    public partial class frmAdmPrincipal : Form
    {
        modeloAdm admin = new modeloAdm();
        public frmAdmPrincipal(modeloAdm adm)
        {
            InitializeComponent();
            admin = adm;
        }

        private void frmAdmPrincipal_Load(object sender, EventArgs e)
        {
            List<modeloDvd> listaDvd = admin.Selecionar();
            foreach (modeloDvd dvd in listaDvd)
            {
                dataGridView1.Rows.Add(dvd.Id.ToString(), dvd.Nome, dvd.Ano, dvd.Genero);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmClientes clientesForm = new frmClientes();
            clientesForm.ShowDialog();
        }
    }
}
