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
    public partial class frmClientes : Form
    {
        modeloAdm admin = new modeloAdm();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            List<modeloCliente> listaClientes = admin.SelecionarClientes();
            foreach(modeloCliente cliente in listaClientes)
            {
                dataGridView1.Rows.Add(cliente.Id.ToString(),
                                        cliente.Nome, cliente.Email,
                                        cliente.Telefone, cliente.Endereco,
                                        cliente.Login, cliente.UltimoFilme,
                                        cliente.UltimoLogin.ToString());
            }
        }
    }
}
