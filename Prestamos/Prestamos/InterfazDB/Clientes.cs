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
    internal class Clientes : InterfazDB
    {
        public Clientes() : base("Clientes") { }
        public DataTable buscar(string celular) { return select($"SELECT * FROM clientes WHERE celular = '{celular}'"); }
    }
}
