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
    public partial class formConsultarCategoria : Form
    {
        private CategoriaVehiculoLogica logicaCategoria;
        public formConsultarCategoria(CategoriaVehiculoLogica logica)
        {
            InitializeComponent();
            logicaCategoria = logica;   
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formConsultarCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
