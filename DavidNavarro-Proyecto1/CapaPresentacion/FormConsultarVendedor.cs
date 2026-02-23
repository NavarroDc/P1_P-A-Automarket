using CapaEntidades;
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

namespace CapaPresentacion
{
    public partial class FormConsultarVendedor : Form
    {
        private VendedorLogica logicaVendedor;
        public FormConsultarVendedor(VendedorLogica logica)
        {
            InitializeComponent();
            logicaVendedor = logica;
        }

        private void cargarVendedores()
        {
            dgvConsultarVendedores.Rows.Clear();

            Vendedor[] vendedores = logicaVendedor.ObtenerVendedores();

            foreach (Vendedor vendedor in vendedores)
            {
                if(vendedor != null)
                {
                    dgvConsultarVendedores.Rows.Add(
                            vendedor.IdVendedor,
                            vendedor.Identificacion,
                            vendedor.NombreCompleto,
                            vendedor.FechaNacimiento.ToShortDateString(),
                            vendedor.FechaIngreso.ToShortDateString(),
                            vendedor.Telefono
                    );
                }
            }
        }
        private void FormConsultarVendedor_Load(object sender, EventArgs e)
        {
            cargarVendedores();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
