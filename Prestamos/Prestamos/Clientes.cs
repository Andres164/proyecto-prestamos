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
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Crea Objeto conexion
            Conexion c = new Conexion();
            //Instanciar
            
            MessageBox.Show(c.insertarSP(txtNombre.Text, txtCelular.Text));
           // GetData("select nombre, telefono from Proveedores");

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;

            //crear objeto data table
            DataTable dtDatos = new DataTable();
            cn = new SqlConnection("Data Source=Baio-PC\\SQLEXPRESS;Initial Catalog=prestamos;Integrated Security=True");
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * From CLIENTES", cn);
                //cmd = new SqlCommand("SELECT * From CLIENTES where ISBN = '" + txtISBN.Text + "'", cn);

                //CREAR OBJETO DATAREADER(ACCESO A DATOS DE SOLO LECTURA)
                dr = null;
                dr = cmd.ExecuteReader();
                //pasar los datos del obejto datareader al objeto datatable
                dtDatos.Load(dr);

                dgvDatos.DataSource = dtDatos;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;

            //crear objeto data table
            DataTable dtDatos = new DataTable();
            cn = new SqlConnection("Data Source=DESKTOP-ULBD6KD\\SQLEXPRESS;Initial Catalog=prestamos;Integrated Security=True");
            cn.Open();
            //cmd = new SqlCommand("SELECT * From CLIENTES", cn);
            cmd = new SqlCommand("SELECT Nombre From CLIENTES where Celular = '" + txtCelular.Text + "'", cn);

            //CREAR OBJETO DATAREADER(ACCESO A DATOS DE SOLO LECTURA)
            dr = null;
            dr = cmd.ExecuteReader();
            //pasar los datos del obejto datareader al objeto datatable

            if (dr.Read())
            {
                txtNombre.Text = dr.GetString(0);

            }
            else

            {
                MessageBox.Show("Registro no encontrado");
            }

            //Cerrar conexion
            cn.Close();
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCelular.Clear();
        }
    }
}
