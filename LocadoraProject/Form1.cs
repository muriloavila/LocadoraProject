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
    public partial class Form1 : Form
    {
        dataControlador data = new dataControlador();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbAdm.Checked == true)
            {
                modeloAdm adm = new modeloAdm();
                adm = data.LoginAdm(txtLogin.Text, txtSenha.Text);
                if (adm == null)
                {
                    MessageBox.Show("Não foi posivel fazer o Login como Administrador");
                }
                else
                {
                    frmAdmPrincipal admForm = new frmAdmPrincipal(adm);
                    admForm.ShowDialog();
                }
            }
            else if (rdbCliente.Checked == true)
            {
                modeloCliente cliente = new modeloCliente();
                    cliente= data.LoginCliente(txtLogin.Text, txtSenha.Text);
                if (cliente == null)
                {
                    MessageBox.Show("Não foi possivel fazer o login como Cliente");
                }
                else
                {
                    frmClientePrincipal clienteForm = new frmClientePrincipal(cliente);
                    clienteForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Selecione um tipo de Conta para Logar");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
