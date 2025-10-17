using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        public int JugadorId { get; set; }
        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Partida Partida { get; set; } // para q en la vista me devuelva la partida completa no solo el id
        public int PartidaId { get; set; } //quede referenciado en la bdd
    }
}
