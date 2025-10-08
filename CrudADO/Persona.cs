using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudADO
{
    public class Persona
    {
        private int id;
        private string nombre;
        private int edad;

        public int Id { get; set; } 
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
