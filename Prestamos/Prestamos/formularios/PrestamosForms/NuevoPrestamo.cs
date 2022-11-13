using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos.formularios.Prestamos
{
    public partial class NuevoPrestamo : Form
    {
        Conexion conexion = new Conexion();
        public NuevoPrestamo()
        {
            InitializeComponent();
        }

        private void PagarPrestamo_Load(object sender, EventArgs e)
        {
            this.dgvClientes.DataSource = this.conexion.selectClientes();
        }

        private void txtBoxCelular_Leave(object sender, EventArgs e)
        {
            if(this.txtBoxCelular.Text.Length == 0)
                this.dgvClientes.DataSource = this.conexion.selectClientes();
            else
            {
                string celular = this.txtBoxCelular.Text;
                if(!esCelularValido(celular))
                {
                    MessageBox.Show("Numero de celular invalido", "Valor invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtBoxCelular.Text = "";
                }
                else
                {
                    this.dgvClientes.DataSource = this.conexion.buscarCliente(celular);
                    //MessageBox.Show(this.conexion.buscarCliente(celular).Rows[0].ToString());
                }
            }
        }

        private bool esCelularValido(string texto)
        {
            foreach(char letra in texto)
            {
                if(letra < '0' || letra > '9')
                    return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBoxCelular.Text.Length == 0)
                MessageBox.Show("Ingrese un celular");
        }
    }
}
