using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


        public bool idRepetido(int id)
        {
            //Validar que el ID no se repita
            if(datosCategoria.BuscarCatId(id) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
            
        public bool espaciosVacios(string nombre, string descripcion)
        {
            //Validar campos vacíos en categoría
            if (string.IsNullOrEmpty(nombre))
            {
                return true;
            }

            if (string.IsNullOrEmpty(descripcion))
            {
                return true;
            }

            return false;
        }
        public string agregarCategoria(int id, string nombre, string descripcion)
        {
            if (espaciosVacios(nombre, descripcion))
            {
                return "No pueden haber campos vacíos...";
            }

            if (idRepetido(id))
            {
                return "El ID ya existe...";
            }

            CategoriaVehiculo nuevaCategoria = new CategoriaVehiculo(id, nombre, descripcion);

            if (!datosCategoria.agregarCategoria(nuevaCategoria))
            {
                return "Solo se pueden añadir 20 categorías...";
            }

            return null;
        }

        public CategoriaVehiculo[] ObtenerCategorias()
        {
            return datosCategoria.obtenerCategorias();
        }

        public int ObtenerCantidad()
        {
            return datosCategoria.obtenerCantidad();
        }

        public bool hayCategorias()
        {
            CategoriaVehiculo[] categorias = datosCategoria.obtenerCategorias();

            for(int i = 0; i < categorias.Length; i++)
            {
                if (categorias[i] != null)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
