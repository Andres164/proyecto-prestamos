using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos.formularios
{
    public partial class Prestamos : Form
    {
        Conexion conexion;
        public Prestamos()
        {
            InitializeComponent();
            this.conexion = new Conexion();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            this.dgvPrestamos.DataSource = conexion.selectPrestamos();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.dgvPrestamos.DataSource = conexion.selectPrestamos();
        }
    }
}
