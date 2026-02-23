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
    public partial class FormRegistrarVehiculo : Form
    {
        private VehiculoLogica logicaVehiculo;
        private CategoriaVehiculoLogica logicaCategoria;
        public FormRegistrarVehiculo(VehiculoLogica logica, CategoriaVehiculoLogica logicaCat)
        {
            InitializeComponent();
            logicaVehiculo = logica;
            logicaCategoria = logicaCat;
        }

        private void FormRegistrarVehiculo_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }
        //Método para limpiar campos del registro de vehículos
        private void limpiarCampos()
        {
            txtIdVehiculo.Clear();
            txtMarcaVehiculo.Clear();
            txtModeloCarro.Clear();
            txtAnioVehiculo.Clear();
            txtPrecioVehiculo.Clear();
            txtEstadoVehiculo.Clear();
            cmbCategoriaVehiculo.SelectedIndex = -1;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id;
            
            if(!int.TryParse(txtIdVehiculo.Text, out id))
            {
                MessageBox.Show("El ID debe ser un número entero...");
                return;
            }

            int anio;

            if(!int.TryParse(txtAnioVehiculo.Text, out anio))
            {
                MessageBox.Show("El año debe ser un número entero...");
                return;
            }

            decimal precio;

            if(!decimal.TryParse(txtPrecioVehiculo.Text, out precio))
            {
                MessageBox.Show("El precio debe ser un número decimal...");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEstadoVehiculo.Text))
            {
                MessageBox.Show("El estado no puede estar vacío...");
                return;
            }

            char estado = char.ToUpper(txtEstadoVehiculo.Text[0]);

            CategoriaVehiculo categoriaSeleccionada = cmbCategoriaVehiculo.SelectedItem as CategoriaVehiculo;

            string mensaje = logicaVehiculo.agregarVehiculo(id, txtMarcaVehiculo.Text, txtModeloCarro.Text, anio, precio, categoriaSeleccionada, estado);

            if(mensaje != null)
            {
                MessageBox.Show(mensaje);
                return;
            }
            MessageBox.Show("¡Vehículo registrado!");
            limpiarCampos();
        }

        //Método para cargar las categorías, si no hay, muestra un mensaje informando
        private void cargarCategorias()
        {
            try
            {
                cmbCategoriaVehiculo.Items.Clear();
                CategoriaVehiculo[] categorias = logicaCategoria.ObtenerCategorias();

                for(int i = 0; i < categorias.Length; i++)
                {
                    if (categorias[i] != null)
                    {
                        cmbCategoriaVehiculo.Items.Add(categorias[i]);
                    }
                }

                if(cmbCategoriaVehiculo.Items.Count > 0)
                {
                   cmbCategoriaVehiculo.SelectedIndex = 0;
                }
                else
                {
                    btnGuardar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, no se cargaron las categorías... " + ex.Message);

            }
        }
    }
}
