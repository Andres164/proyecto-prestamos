using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Prestamos.formularios
{
    public partial class Sucursales : Form
    {
        SqlConnection connPrestamos;
        SqlDataAdapter dataAdapter;
        DataTable sucursales;

        public Sucursales()
        {
            InitializeComponent();
            try 
            {
                connPrestamos = new SqlConnection("Data Source=Baio-PC\\SQLEXPRESS;" +
                                                  "Initial Catalog=prestamos;" +
                                                  "Integrated Security=True");
                sucursales = new DataTable();
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("No se conectó con la base de datos: " + ex.ToString()); 
            }

        }

        private void Sucursales_Load(object sender, EventArgs e)
        {
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM sucursales",
                                                       connPrestamos);
            dataAdapter.Fill(sucursales);
            dgvSucursales.DataSource = sucursales;
            dgvSucursales.Columns[0].ReadOnly = true;
            dgvSucursales.Columns[0].AutoSizeMode = 
                DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            builder.GetInsertCommand();
            builder.GetUpdateCommand();
            builder.GetDeleteCommand();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e) 
        {
            try 
            { 
                dataAdapter.Update(sucursales); 
            }
            catch (SqlException ex) 
            {  
                if(ex.Number == 515)
                    MessageBox.Show("No se permiten campos nulos\n" + ex.Message, "Error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.ToString(), "SQL Exeption", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.ToString(), "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            sucursales.Clear();
            dataAdapter.Fill(sucursales);
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            sucursales.Clear();
            dataAdapter.Fill(sucursales);
        }
    }
}
