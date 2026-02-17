using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; } //Se utiliza "Anio" en vez de "Año" para evitar problemas de compatibilidad
        public decimal Precio { get; set; }
        public CategoriaVehiculo Categoria { get; set; }
        public char Estado { get; set; }

    }
}
