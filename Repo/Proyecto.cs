using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class Proyecto
    {
        private string nombre;
        private List<Tarea> listTarea;
        public string Nombre { get; set; }
        public List<Tarea> ListTarea { get; set; }
    }
}
