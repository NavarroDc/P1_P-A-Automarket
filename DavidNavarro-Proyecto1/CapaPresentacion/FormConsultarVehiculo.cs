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

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
