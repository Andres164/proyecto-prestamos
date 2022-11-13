using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Prestamos.InterfazDB
{
    internal class Clientes
    {
        SqlConnection conn;
        public Clientes() => conn = Conexion.ConexionPrestamos();

        public DataTable selectClientes() { return selectClientes("SELECT * FROM clientes"); }
        public DataTable buscarCliente(string celular) { return selectClientes($"SELECT * FROM clientes WHERE celular = '{celular}'"); }

        private DataTable selectClientes(string query)
        {
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.conn))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                return table;
            }
        }
    }
}
