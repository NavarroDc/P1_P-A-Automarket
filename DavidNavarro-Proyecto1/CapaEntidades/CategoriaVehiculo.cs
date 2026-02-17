using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* UNED I Cuatrimestre
 * Programación avanzada
 * Profesor: Johan Figueroa Guevara
 * Proyecto 1: Automarket
 * Estudiante: David Navarro Camacho
 * Fecha: 22/2/2026
 */

namespace CapaEntidades
{
    public class CategoriaVehiculo
    {
        public int IdCategoria {  get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        public CategoriaVehiculo(int idCategoria, string nombreCategoria, string descripcion)
        {
            IdCategoria = idCategoria;
            NombreCategoria = nombreCategoria;
            Descripcion = descripcion;
        }
    }
}
