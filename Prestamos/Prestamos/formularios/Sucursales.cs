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

namespace Prestamos.formularios
{
    public partial class Sucursales : Form
    {
        SqlConnection connPrestamos;
        SqlDataAdapter dataAdapter;
        DataSet sucursales;

        public Sucursales()
        {
            InitializeComponent();
            try 
            {
                connPrestamos = new SqlConnection("Data Source=DESKTOP-U0D57M6\\SQLEXPRESS;Initial Catalog=prestamos;Integrated Security=True");
                sucursales = new DataSet();
            } 
            catch (Exception ex) { MessageBox.Show("No se conectó con la base de datos: " + ex.ToString()); }

        }

        private void Sucursales_Load(object sender, EventArgs e)
        {
            using (dataAdapter = new SqlDataAdapter())
            {
                dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM sucursales", connPrestamos);
                dataAdapter.Fill(sucursales);
                dgvSucursales.DataSource = sucursales.Tables[0];
            }
        }
    }
}
