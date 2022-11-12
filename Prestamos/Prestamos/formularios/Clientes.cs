using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Prestamos
{
    public partial class frmClientes : Form
    {
        private Conexion conexion;
        public frmClientes()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void cargarDataGridDatos() { this.dgvDatos.DataSource = this.conexion.selectClientes(); }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.conexion.insertarSP(txtNombre.Text, txtCelular.Text));
            // GetData("select nombre, telefono from Proveedores");
            cargarDataGridDatos();

        }

        private void frmClientes_Load(object sender, EventArgs e) { cargarDataGridDatos(); }
        private void btnBuscar_Click(object sender, EventArgs e) { this.txtNombre.Text = this.conexion.buscarCliente(this.txtCelular.Text); }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCelular.Clear();
        }

        private void btnRefrescar_Click(object sender, EventArgs e) { cargarDataGridDatos(); }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if ( this.conexion.actualizarNombreCliente(this.txtCelular.Text, this.txtNombre.Text) == 0 )
            {
                MessageBox.Show("Operacion Exitosa");
                cargarDataGridDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if( this.conexion.eliminarCliente(this.txtCelular.Text) == 0 )
            {
                MessageBox.Show("Operacion Exitosa");
                cargarDataGridDatos();
            }
        }
    }
}
