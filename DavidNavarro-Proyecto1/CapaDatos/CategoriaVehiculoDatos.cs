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

namespace CapaDatos
{
    public class CategoriaVehiculoDatos
    {
        private CategoriaVehiculo[] categorias;
        private int contador;

        public CategoriaVehiculoDatos()
        {
            categorias = new CategoriaVehiculo[20];
            contador = 0;
        }

        public bool agregarCategoria(CategoriaVehiculo nuevaCategoria)
        {
            if(contador >= categorias.Length)
            {
                return false;
            }

            categorias[contador] = nuevaCategoria;
            contador++;
            return true;
        }
    }
}
