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
    public partial class MenuPrincipal : Form
    {
        private CategoriaVehiculoLogica logicaCategoria;
        private VehiculoLogica logicaVehiculo;
        private VendedorLogica logicaVendedor;
        public MenuPrincipal()
        {
            InitializeComponent();
            logicaCategoria = new CategoriaVehiculoLogica();
            logicaVehiculo = new VehiculoLogica();
            logicaVendedor = new VendedorLogica();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Botones registrar y consultar categoría----------------
        private void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            formRegistrarCategoria formRegistrarCat = new formRegistrarCategoria(logicaCategoria);
            formRegistrarCat.ShowDialog();
        }

        private void btnConsultarCategoria_Click(object sender, EventArgs e)
        {
            formConsultarCategoria formConsultarCat = new formConsultarCategoria(logicaCategoria);
            formConsultarCat.ShowDialog();
        }
        //-----------------------------------------
        //Botones registrar y consultar vehículos
        private void btnRegistrarVehiculos_Click(object sender, EventArgs e)
        {
            if (!logicaCategoria.hayCategorias())
            {
                MessageBox.Show("Debe registrar al menos una categoría antes de registrar un vehículo...");
                return;
            }

            FormRegistrarVehiculo formRegistrarVehiculo = new FormRegistrarVehiculo(logicaVehiculo, logicaCategoria);
            formRegistrarVehiculo.ShowDialog();
        }

        private void btnConsultarVehiculos_Click(object sender, EventArgs e)
        {
            FormConsultarVehiculo formConsultarVehiculo = new FormConsultarVehiculo(logicaVehiculo);
            formConsultarVehiculo.ShowDialog();
        }

        private void btnRegistrarVendedores_Click(object sender, EventArgs e)
        {
            
        }
    }
}
