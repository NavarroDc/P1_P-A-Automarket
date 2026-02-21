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
    public partial class formRegistrarCategoria : Form
    {
        private CategoriaVehiculoLogica logicaCategoria;
        public formRegistrarCategoria(CategoriaVehiculoLogica logica)
        {
            InitializeComponent();
            logicaCategoria = logica;
        }



        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoria;

                //Validar que el id de la categoría sea un número entero
                if (!int.TryParse(txtIdCategoria.Text, out idCategoria))
                {
                    MessageBox.Show("El ID de la categoría debe ser un número entero...");
                    return;
                }

                string nombreCategoria = txtNombreCategoria.Text;
                string descripcionCategoria = txtDescripcionCat.Text;

                bool resultado = logicaCategoria.agregarCategoria(idCategoria, nombreCategoria, descripcionCategoria);

                if (resultado)
                {
                    MessageBox.Show("¡Categoría registrada!");
                    txtIdCategoria.Clear();
                    txtNombreCategoria.Clear();
                    txtDescripcionCat.Clear();
                }
                else
                {
                    MessageBox.Show("No pueden haber campos vacíos...");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        private void txtIdCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
