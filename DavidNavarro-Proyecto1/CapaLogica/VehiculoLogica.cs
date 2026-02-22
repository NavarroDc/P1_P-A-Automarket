using CapaEntidades;
using CapaDatos;
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

        //Método para verificar que los textos son válidos
        public bool textoValido(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return false;
            }
            return true;
        }

        //Método para verificar que el año sea válido
        public bool anioValido(int anio)
        {
            if(anio < 1900)
            {
                return false;
            }

            if(anio > DateTime.Now.Year + 1)
            {
                return false;
            }

            return true;
        }

        //Método para verificar que el precio es válido
        public bool precioValido(decimal precio)
        {
            if(precio < 0)
            {
                return false;
            }
            return true;
        }

        //Método para verificar que el estado sea válido
        public bool estadoValido(char estado)
        {
            if(estado.Equals("N"))
            {
                if(estado.Equals("U"))
                {
                    return true;
                }
            }
            return false;
        }

        //Método que agrega un vehículo
        public string agregarVehiculo(int id, string marca, string modelo, 
                                      int anio, decimal precio, CategoriaVehiculo categoria, char estado)
        {
            if (idRepetido(id))
            {
                return "El ID ya existe...";
            }

            if (!textoValido(marca))
            {
                return "No puede haber espacios vacíos...";
            }

            if (!textoValido(modelo))
            {
                return "No puede haber espacios vacíos...";
            }

            if (!anioValido(anio))
            {
                return "El año ingresado no es válido...";
            }

            if (!precioValido(precio))
            {
                return "El precio debe ser mayor a cero...";
            }

            if(categoria != null)
            {
                return "Debe seleccionar una categoría...";
            }

            if (!estadoValido(estado))
            {
                return "Debe escribir 'N' o 'U'...";
            }

            return null;
        }

        public Vehiculo[] ObtenerVehiculos()
        {
            return datosVehiculo.obtenerVehiculos();
        }
    }
}
