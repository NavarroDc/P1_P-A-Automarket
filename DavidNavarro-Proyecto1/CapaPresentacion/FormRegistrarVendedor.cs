using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* UNED I Cuatrimestre
 * Programación avanzada
 * Profesor: Johan Figueroa Guevara
 * Proyecto 1: Automarket
 * Estudiante: David Navarro Camacho
 * Fecha: 22/2/2026
 */

namespace CapaPresentacion
{
    public partial class FormRegistrarVendedor : Form
    {
        private VendedorLogica logicaVendedor;
        public FormRegistrarVendedor(VendedorLogica logica)
        {
            InitializeComponent();
            logicaVendedor = logica;
        }

        private void limpiarCampos()
        {
            txtIdVendedor.Clear();
            txtIdentificacionVendedor.Clear();
            txtNombreVendedor.Clear();
            txtTelefonoVendedor.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            dtpFechaIngreso.Value = DateTime.Today;
        }

        private void FormRegistrarVendedor_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id;

            if(!int.TryParse(txtIdVendedor.Text, out id))
            {
                MessageBox.Show("El ID debe ser numérico...");
                return;
            }

            string mensaje = logicaVendedor.agregarVendedor(
                    id,
                    txtIdentificacionVendedor.Text,
                    txtNombreVendedor.Text,
                    dtpFechaNacimiento.Value,
                    dtpFechaIngreso.Value,
                    txtTelefonoVendedor.Text
                );
        }
    }
}
