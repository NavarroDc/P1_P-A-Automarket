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

        //Constructor
        public CategoriaVehiculoDatos()
        {
            categorias = new CategoriaVehiculo[20];
            contador = 0;
        }
        
        //Método para verificar si el arreglo de categorías está lleno
        public bool estaLleno()
        {
            return contador >= categorias.Length;
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

        //Buscar la categoría de acuerdo al ID del objeto
        public CategoriaVehiculo BuscarCatId(int id)
        {
            for(int i = 0; i < contador; i++)
            {
                if (categorias[i].IdCategoria == id)
                {
                    return categorias[i];   
                }
            }

            return null;
        }
    }
}
