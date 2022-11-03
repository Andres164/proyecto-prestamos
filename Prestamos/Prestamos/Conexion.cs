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
                
                cn = new SqlConnection("Data Source=Baio-PC\\SQLEXPRESS;Initial Catalog=prestamos;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex) { MessageBox.Show("No se conectó con la base de datos: " + ex.ToString()); }
        }
        public string insertarSP(string Nombre, string Celular)
        {
            string salida = "Se insertó Registro"; 
            try
            { //Crear un Objeto comando
              //
              SqlCommand cmd = new SqlCommand("dbo.SP_INSERTA_CLIENTE", cn);
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
    }
}
