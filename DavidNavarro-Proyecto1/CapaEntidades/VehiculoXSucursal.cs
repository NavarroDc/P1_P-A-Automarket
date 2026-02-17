using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class VehiculoXSucursal
    {
        public Sucursal Sucursal { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int Cantidad { get; set; }

        public VehiculoXSucursal(Sucursal sucursal, Vehiculo vehiculo, int cantidad)
        {
            Sucursal = sucursal;
            Vehiculo = vehiculo;
            Cantidad = cantidad;
        }
    }
}
