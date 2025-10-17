using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Controladora
{
    public class Controladora
    {
        private static Controladora instancia;
        public static Controladora Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora();
                }

                return instancia;
            }

        }

        public IReadOnlyList<Partida> ListarJugadores()
        {
            return Modelo.Repositorio.Instancia.ListarJugadores();
        }

        public string AsignarJugador(Partida partida, Jugador jugador)
        {
            var existeJugador = partida.Jugadores.FirstOrdefault(x => x== jugador);
            var maximoJugadores = partida.Jugadores.Count();

           if(existeJugador == null && maximoJugadores < 2)
            {
                partida.Jugadores.Add(jugador);
                return Modelo.Repositorio.Instancia.AsignarJugador(partida, jugador);
            }
            else if (existeJugador != null)
            {
                return "El jugador ya está asignado a la partida.";
            }

                return "No se puede asignar a la partida";

        }
    }
}
