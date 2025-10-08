using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Socios
    {
        private int id;
        private string nombre;
        private string apellido;
        private string dni;
        private DateTime fechaNacimiento;
        private int numeroSocio;
        private bool cuotaSAlDia;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NumeroSocio { get; set; }
        public bool CuotaSAlDia { get; set; }

    }
}
 
