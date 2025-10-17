using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Entidades;

namespace Modelo
{
    public class Context : DbContext
    {
        public string conexion = "mariadb://ana:anitalove@152.53.190.85:18980/Ajedrez";

        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Partida> Partidas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(conexion);
        



    }
}
