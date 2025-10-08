using Repo;

namespace Controladora
{
    public class ControladoraProyecto
    {
        //aca se hacen todas las operaciones del crud pero adaptadas a una controladora. 
        private Context context;        
        public ControladoraProyecto()
        {
            context = new Context();
        }
        

        
        //metodos 
        public string Agregar(Proyecto proyecto)
        {
            //hacemso una validacion para q el nombre del proyectoi no este duplicado
            try
            {
                var existeProyecto = context.Proyectos.FirstOrDefault(x => x.Nombre == proyecto.Nombre);

                if (existeProyecto == null)
                {
                    context.Proyectos.Add(proyecto); //pára hacer referencia a cada tabla 
                    context.SaveChanges();
                    return "El proyecto agregado";
                }

                return "Proyecto Agregado";
            } 
            catch (Exception ex)
            {
                    throw new Exception("Error al agregar" + ex.Message); //asi se cierra el programa. Otra forma para q no se cierre el pro
            }
            
        }


        public IReadOnlyCollection<Proyecto> Listar()
        {

            return context.Proyectos.ToList().AsReadOnly();  //solo en esta linea es el listar xd
        }

    }
}
