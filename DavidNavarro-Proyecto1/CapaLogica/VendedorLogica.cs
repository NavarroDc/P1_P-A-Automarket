using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class VendedorLogica
    {
        private VendedorDatos datosVendedor;

        public VendedorLogica()
        {
            datosVendedor = new VendedorDatos();
        }

        public string agregarVendedor(int id, string identificacion, string nombreCompleto, 
                                      DateTime fechaNacimiento, DateTime fechaIngreso, string telefono)
        {
            //Valida que el ID sea único
            if(datosVendedor.buscarVendedorId(id) != null)
            {
                return "El ID ya existe...";
            }
            
            //Valida que la identificación sea única
            if(datosVendedor.buscarVendedorIdentificacion(identificacion) != null)
            {
                return "La identificación ya existe...";
            }

            //Validaciones de espacios vacíos
            if (string.IsNullOrWhiteSpace(nombreCompleto))
            {
                return "El nombre no puede estar vacío...";
            }

            if (string.IsNullOrWhiteSpace(identificacion))
            {
                return "La identificación no puede estar vacía...";
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                return "El teléfono no puede estar vacío...";
            }

            //Validación de fechas
            if(fechaNacimiento >= DateTime.Now)
            {
                return "La fecha de nacimiento no es válida...";
            }

            if(fechaIngreso >= fechaNacimiento)
            {
                return "La fecha de ingreso no puede ser menor a la fecha de nacimiento...";
            }

            if (datosVendedor.estaLleno())
            {
                return "No se pueden registrar más vendedores...";
            }

            Vendedor nuevoVendedor = new Vendedor(id, identificacion, nombreCompleto,
                                                  fechaNacimiento, fechaIngreso, telefono);

            datosVendedor.agregarVendedor(nuevoVendedor);
            return null;
        }

        public Vendedor[] ObtenerVendedores()
        {
            return datosVendedor.obtenerVendedores();
        }
    }
}
