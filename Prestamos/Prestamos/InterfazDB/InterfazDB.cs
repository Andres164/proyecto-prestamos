using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Prestamos.InterfazDB
{
    internal class InterfazDB
    {
        protected SqlConnection conn;
        protected string nombreTabla;
        public InterfazDB(string nobmreTabla)
        {
            this.conn = Conexion.ConexionPrestamos();
            this.nombreTabla = nobmreTabla;
        }
        public DataTable selectTodos() { return select($"SELECT * FROM {this.nombreTabla}"); }
        public void updateDB(DataTable updatedTable)
        {
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM {this.nombreTabla}", this.conn))
            {
                SqlCommandBuilder commandBldr = new SqlCommandBuilder(dataAdapter);
                commandBldr.GetInsertCommand();
                commandBldr.GetUpdateCommand();
                commandBldr.GetDeleteCommand();
                dataAdapter.Update(updatedTable);
            }
        }

        protected DataTable select(string query)
        {
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.conn))
            {
                DataTable table = new DataTable();
                table.Rows.Clear();
                dataAdapter.Fill(table);
                return table;
            }
        }
        protected DataTable obtenerEstructuraDataTable()
        {
            DataTable dt = select($"SELECT TOP 1 * FROM {this.nombreTabla}");
            dt.Clear();
            return dt;
        }
    }
}
