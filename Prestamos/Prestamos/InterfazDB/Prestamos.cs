using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Prestamos.InterfazDB
{
    internal class Prestamos : InterfazDB
    {
        DataTable estructuraDt;
        public Prestamos() : base("Prestamos") => this.estructuraDt = obtenerEstructuraDataTable();

        public void insertarRegistro(string celular, decimal importe)
        {
            DataRow nuevoPrestamo = this.estructuraDt.NewRow();
            nuevoPrestamo[1] = celular;
            nuevoPrestamo[2] = importe;
            this.estructuraDt.Rows.Add(nuevoPrestamo);
            updateDB(this.estructuraDt);
            estructuraDt.Clear();
        }
        public void pagarPrestamo(int id_prestamo, string celularPrestatario)
        {
            DataTable prestamo = select($"SELECT * FROM {this.nombreTabla} WHERE id_prestamo = {id_prestamo}");
        }
    }
}
