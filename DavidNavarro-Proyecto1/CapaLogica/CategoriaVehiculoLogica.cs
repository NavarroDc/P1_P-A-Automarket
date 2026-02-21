using CapaDatos;
using CapaEntidades;
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

namespace CapaLogica
{
    public class CategoriaVehiculoLogica
    {
        private CategoriaVehiculoDatos datosCategoria;

        public CategoriaVehiculoLogica()
        {
            datosCategoria = new CategoriaVehiculoDatos();
        }

        public bool agregarCategoria(int id, string nombre, string descripcion)
        {
            //Validar que el id sea único 
            if (datosCategoria.BuscarCatId(id) != null)
            {
                return false;
            }

            //Validar campos vacíos en categoría
            if (string.IsNullOrEmpty(nombre))
            {
                return false;
            }

            if (string.IsNullOrEmpty(descripcion))
            {
                return false;
            }

            //Crea el objeto
            CategoriaVehiculo nuevaCategoria = new CategoriaVehiculo(id, nombre, descripcion);

            //Guarda el objeto en CapaDatos
            return datosCategoria.agregarCategoria(nuevaCategoria);
        }

        
    }
}
