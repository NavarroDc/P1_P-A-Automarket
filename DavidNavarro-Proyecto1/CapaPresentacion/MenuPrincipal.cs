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
    public partial class MenuPrincipal : Form
    {
        private CategoriaVehiculoLogica logicaCategoria;
        public MenuPrincipal()
        {
            InitializeComponent();
            logicaCategoria = new CategoriaVehiculoLogica();
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

        private void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            formRegistrarCategoria formRegistrarCat = new formRegistrarCategoria(logicaCategoria);
            formRegistrarCat.ShowDialog();
        }

        private void btnConsultarCategoria_Click(object sender, EventArgs e)
        {
            formConsultarCategoria formConsultarCat = new formConsultarCategoria();
            formConsultarCat.ShowDialog();
        }

        
    }
}
