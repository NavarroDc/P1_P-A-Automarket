using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VehiculoDatos
    {
        private Vehiculo[] vehiculos;
        private int contador;

        //Constructor
        public VehiculoDatos()
        {
            vehiculos = new Vehiculo[50];
            contador = 0;
        }

        //Método para agregar un vehículo al arreglo
        public bool agregarVehiculo(Vehiculo nuevoVehiculo)
        {
            if(contador >= vehiculos.Length)
            {
                return false;//Falso porque el arreglo está lleno
            }

            vehiculos[contador] = nuevoVehiculo;
            contador++;
            return true;
        }

        //Buscar vehículo por el ID
        public Vehiculo buscarVehiculoId(int id)
        {
            for(int i = 0; i < contador;  i++)
            {
                if (vehiculos[i].IdVehiculo == id)
                {
                    return vehiculos[i];
                }
            }
            return null;
        }

        //Obtener todos los vehiculos
        public Vehiculo[] obtenerVehiculos()
        {
            return vehiculos;
        }

        public bool estaLleno()
        {
            //Si retorna true, significa que el arreglo está lleno
            return contador >= vehiculos.Length;
        }
       
    }
}
