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
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }

        public Cliente (int idCliente, string identificacion, string nombreCompleto, DateTime fechaNacimiento, DateTime fechaRegistro, bool activo)
        {
            IdCliente = idCliente;
            Identificacion = identificacion;
            NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }
    }
}
