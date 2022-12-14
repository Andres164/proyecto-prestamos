using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prestamos.formularios;

namespace Prestamos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmClientes = new frmClientes();
            frmClientes.Show();
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSucursales = new Sucursales();
            frmSucursales.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPrestamos = new PrestamosFrm();
            frmPrestamos.Show();
        }
    }
}
