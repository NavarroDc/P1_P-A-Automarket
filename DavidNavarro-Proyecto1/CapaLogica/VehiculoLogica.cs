using CapaEntidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class VehiculoLogica
    {
        private VehiculoDatos datosVehiculo;

        public VehiculoLogica()
        {
            datosVehiculo = new VehiculoDatos();
        }

        //Valida que el ID sea único
        public bool idRepetido(int id)
        {
            if(datosVehiculo.buscarVehiculoId(id) != null)
            {
                return true;
            }
            return false;
        }

        //
    }
}
