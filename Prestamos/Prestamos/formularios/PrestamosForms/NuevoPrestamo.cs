using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos.formularios.Prestamos
{
    public partial class NuevoPrestamo : Form
    {
        InterfazDB.Clientes interfazClientes;
        InterfazDB.Prestamos interfazPrestamos;
        DataTable dtClientes;
        DataView dvClientes;

        public NuevoPrestamo()
        {
            InitializeComponent();
            interfazClientes = new InterfazDB.Clientes();
            interfazPrestamos = new InterfazDB.Prestamos();
            dtClientes = interfazClientes.selectTodos();
            dvClientes = new DataView(dtClientes);
        }

        private void PagarPrestamo_Load(object sender, EventArgs e)
        {
            cargarDatosDeTablaAlDgv();
        }

        private void txtBoxCelular_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBoxCelular.Text.Length == 0)
                cargarDatosDeTablaAlDgv();
            else
            {
                string celular = this.txtBoxCelular.Text;
                if (!esCelularValido(celular))
                {
                    MessageBox.Show("Numero de celular invalido", "Valor invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtBoxCelular.Text = "";
                }
                else
                {
                    dvClientes.ApplyDefaultSort = true;
                    try 
                    { 
                        dvClientes.RowFilter = $"CELULAR LIKE '{celular}*'"; 
                    } 
                    catch(Exception ex) { MessageBox.Show(ex.ToString(), "Filtro"); }
                    this.dgvClientes.DataSource = this.dvClientes;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string celular = this.txtBoxCelular.Text;
            decimal importe = this.numUpDownImporte.Value;
            interfazPrestamos.insertarRegistro(celular, importe);
        }
        private void btnBorrar_Click(object sender, EventArgs e) { this.txtBoxCelular.Clear(); }

        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }

        private bool esCelularValido(string texto)
        {
            foreach(char letra in texto)
            {
                if(letra < '0' || letra > '9')
                    return false;
            }
            return true;
        }
        private void cargarDatosDeTablaAlDgv() { this.dgvClientes.DataSource = this.dtClientes; }
    }
}
