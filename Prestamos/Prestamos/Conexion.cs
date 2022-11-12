using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prestamos
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Conexion()
        {
            try
            {
                //Declarar la cadena (objeto) de conexión al servidor 
                cmd = new SqlCommand();
                cn = new SqlConnection("Data Source=Baio-PC\\SQLEXPRESS;Initial Catalog=prestamos;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex) { MessageBox.Show("No se conectó con la base de datos: " + ex.ToString()); }
        }
        public DataTable selectPrestamos()
        {
            DataTable dtDatos = new DataTable();
            try
            {
                this.cmd = new SqlCommand("SELECT * From Prestamos", this.cn);
                this.dr = null;
                this.dr = cmd.ExecuteReader();
                dtDatos.Load(this.dr);
                return dtDatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new DataTable();
            }
        }
        public DataTable selectClientes()
        {
            //crear objeto data table
            DataTable dtDatos = new DataTable();
            try
            {
                this.cmd = new SqlCommand("SELECT * From CLIENTES", this.cn);
                //cmd = new SqlCommand("SELECT * From CLIENTES where ISBN = '" + txtISBN.Text + "'", cn);

                //CREAR OBJETO DATAREADER(ACCESO A DATOS DE SOLO LECTURA)
                this.dr = null;
                this.dr = cmd.ExecuteReader();
                //pasar los datos del obejto datareader al objeto datatable
                dtDatos.Load(this.dr);
                return dtDatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new DataTable();
            }
            finally { dr.Close(); }
        }
        public string buscarCliente(string telefono)
        {
            //crear objeto data table
            DataTable dtDatos = new DataTable();
            //cmd = new SqlCommand("SELECT * From CLIENTES", cn);
            this.cmd = new SqlCommand("SELECT Nombre From CLIENTES where Celular = '" + telefono + "'", this.cn);

            //CREAR OBJETO DATAREADER(ACCESO A DATOS DE SOLO LECTURA)
            this.dr = null;
            this.dr = this.cmd.ExecuteReader();
            //pasar los datos del obejto datareader al objeto datatable
            if (dr.Read())
            {
                string registro = this.dr.GetString(0);
                dr.Close();
                return registro;
            }
            else
            {
                MessageBox.Show("Registro no encontrado");
                dr.Close();
                return "Registro no encontrado";
            }
        }
        public string insertarSP(string Nombre, string Celular)
        {
            string salida = "Se insertó Registro"; 
            try
            { //Crear un Objeto comando
              //
              SqlCommand cmd = new SqlCommand("dbo.SP_INSERTA_CLIENTES", cn);
              //Indicar que sera Store Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                
                
                //limpiar parametros
                
                cmd.Parameters.Clear(); 
                
                cmd.Parameters.AddWithValue("@Nombre", Nombre); 
                cmd.Parameters.AddWithValue("@Celular", Celular);
                
                //Ejecutar la sentencia sql en el servidor
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { salida = "No se conecto: " + ex.ToString(); }
            return salida;
        }
        public int actualizarNombreCliente(string celular, string nombre)
        {
            try
            {
                // cambiar a uso de preparacion de declaracion por seguridad
                SqlCommand cmd = new SqlCommand("UPDATE clientes SET Nombre = '" + nombre + "' WHERE celular = '" + celular + "'", this.cn);
                if ( cmd.ExecuteNonQuery() > 0 )
                    return 0;
                else
                    return 1;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return 1; 
            }
        }
        public int eliminarCliente(string celular)
        {
            // cambiar a uso de preparacion de declaracion por seguridad
            SqlCommand cmd = new SqlCommand($"DELETE FROM Clientes WHERE celular = '{celular}'", this.cn);
            if (cmd.ExecuteNonQuery() > 0)
                return 0;
            else
                return 1;
        }
    }
}
