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
    public partial class FormConsultarVehiculo : Form
    {
        private VehiculoLogica logicaVehiculo;
        public FormConsultarVehiculo(VehiculoLogica logica)
        {
            InitializeComponent();
            logicaVehiculo = logica;

        }


        private void FormConsultarVehiculo_Load(object sender, EventArgs e)
        {
            cargarVehiculos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarVehiculos()
        {
            try
            {
                dgvConsultarVehiculos.Rows.Clear();

                Vehiculo[] vehiculos = logicaVehiculo.ObtenerVehiculos();

                for(int i = 0; i < vehiculos.Length; i++)
                {
                    if(vehiculos[i] != null)
                    {
                        dgvConsultarVehiculos.Rows.Add(
                        vehiculos[i].IdVehiculo,
                        vehiculos[i].Marca,
                        vehiculos[i].Modelo,
                        vehiculos[i].Anio,
                        vehiculos[i].Precio,
                        vehiculos[i].Categoria.NombreCategoria,
                        vehiculos[i].Categoria.Descripcion,
                        vehiculos[i].Estado
                        );
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al cargar los vehículos... " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
