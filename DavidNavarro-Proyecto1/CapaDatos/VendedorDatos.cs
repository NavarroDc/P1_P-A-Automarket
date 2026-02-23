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
    public class VendedorDatos
    {
        private Vendedor[] vendedores;
        private int contador;

        //Constructor
        public VendedorDatos()
        {
            vendedores = new Vendedor[20];
            contador = 0;
        }

        public bool agregarVendedor(Vendedor nuevoVendedor)
        {
            if(contador >= vendedores.Length)
            {
                return false;
            }

            vendedores[contador] = nuevoVendedor;
            contador++;
            return true;
        }

        public Vendedor buscarVendedorId(int id)
        {
            for(int i = 0; i < contador; i++)
            {
                if (vendedores[i].IdVendedor == id)
                {
                    return vendedores[i];
                }
            }
            return null;
        }

        public Vendedor buscarVendedorIdentificacion(string identificacion)
        {
            for(int i = 0; i < contador; i++)
            {
                if (vendedores[i].Identificacion == identificacion)
                {
                    return vendedores[i];
                }
            }
            return null;
        }

        public Vendedor[] obtenerVendedores()
        {
            return vendedores;
        }

        public bool estaLleno()
        {
            return contador >= vendedores.Length;
        }
    }
}
