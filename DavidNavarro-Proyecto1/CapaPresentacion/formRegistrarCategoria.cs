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

        private void limpiarCampos()
        {
            txtIdCategoria.Clear();
            txtNombreCategoria.Clear();
            txtDescripcionCat.Clear();
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

                if(int.TryParse(txtIdCategoria.Text, out idCategoria) == false)
                {
                    MessageBox.Show("El ID debe ser un número entero...");
                    return;
                }
                else
                {
                    string nombreCategoria = txtNombreCategoria.Text;
                    string descripcionCategoria = txtDescripcionCat.Text;

                    string mensaje = logicaCategoria.agregarCategoria(idCategoria, nombreCategoria, descripcionCategoria);

                    if(mensaje == null)
                    {
                        MessageBox.Show("¡Categoría registrada correctamente!");
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
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

        private void formRegistrarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
