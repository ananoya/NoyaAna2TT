using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace CrudADO
{

    //esta clase vendria a ser el repositorio
    public class PersonaDB
    {

        //declaro lista donde voy a guardar a todas las personas

        private List<Persona> listaPersonas = new List<Persona>();

        //conexion con la base de datos
        private string connectionString = "Data Source=ANA_NOYA\\SQLEXPRESS;Initial Catalog=CrudADOWindowsForm;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";



        //repositorio
        public PersonaDB()
        {
            /*el constructor public PersonaDB() se ejecuta
            automáticamente cada vez que instanciás la clase PersonaDB*/

            listaPersonas = new List<Persona>();
        }





        //metodo AGREGAR----------------------------------------------------------------------------

        //Este metodo me va a agregar a un persona la tabla personas respetando las columnas de los atributos
        public string Agregar(Persona persona)
        {
            string query = "INSERT INTO Personas(nombre, edad) VALUES" + "(@Nombre, @Edad)";

            try
            {
                //constructor de la clase SqlConnection predetermnado
                //Instancio la clase llamada comdando y le paso como parametro la conexion 

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open(); //abro la conexion con la bdd

                    //crea un sqlcomann de la clase esa.
                    //es la instruccion de SQL a ejecutar

                    SqlCommand instruccion = new SqlCommand(query, conexion); //le paso al query y conexion como parametro
                    instruccion.Parameters.AddWithValue("@Nombre", persona.Nombre);
                    instruccion.Parameters.AddWithValue("@Edad", persona.Edad);

                    //calcula cuantas filas modifica (siempre es una)
                    instruccion.ExecuteNonQuery();
            
                    conexion.Close(); //cierro la conexion

                    return "La persona se agrego con éxito";
                }

            }

            //tiro una excepcion en caso de error entra en el catch
            catch (Exception ex)
            {
                throw new Exception("Error al agregar persona" + ex.Message);

            }
        }



        //metodo LISTAR----------------------------------------------------------------------------

        public List<Persona> Listar()
        {
            string query = "SELECT *  from Personas";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {

                    conexion.Open(); //abro la conexion con la bdd
                    SqlCommand instruccion = new SqlCommand(query, conexion);
                    SqlDataReader lector = instruccion.ExecuteReader(); //leer lo que trae esa consulta/isntruccion

                    while (lector.Read())
                    {
                        Persona personaListada = new Persona(); //instancio un objeto de tipo persona

                        personaListada.Id = int.Parse(lector["id"].ToString()); //el id que pase lo convierto en strin y luego parse
                        personaListada.Nombre = lector["nombre"].ToString();//el nombre que pase lo convierto en string
                        personaListada.Edad = int.Parse(lector["edad"].ToString());//|el edad que pase lo convierto en string y luego parse

                        listaPersonas.Add(personaListada); //agrego a la lista la persona que acabo de listar
                    }


                    return listaPersonas; //retorno la lista con todas las personas que tengo en la bdd
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar personas" + ex.Message);
            }

        }



        //METODO modificar---------------------------------------------------------------------------------

        public Persona Modificar(Persona persona)
        {
            string query = "UPDATE Personas SET Nombre = @Nombre, Edad = @Edad WHERE Id = @Id";

            try
            {
                //constructor de la clase SqlConnection predetermnado
                //Instancio la clase llamada comdando y le paso como parametro la conexion 

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open(); //abro la conexion con la bdd

                    //crea un sqlcomann de la clase esa.
                    //es la instruccion de SQL a ejecutar

                    SqlCommand instruccion = new SqlCommand(query, conexion); //le paso al query y conexion como parametro
                    instruccion.Parameters.AddWithValue("@Nombre", persona.Nombre);
                    instruccion.Parameters.AddWithValue("@Edad", persona.Edad);
                    instruccion.Parameters.AddWithValue("@Id", persona.Id); // <- ESTA ES LA QUE FALTA


                    //calcula cuantas filas modifica (siempre es una)
                    instruccion.ExecuteNonQuery();
                    conexion.Close(); //cierro la conexion
       
                    return persona;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar a la persona" + ex.Message);

            }               

        }

        public Persona GetById(int id)
        {
            Persona persona = null;
            string query = "SELECT Id, Nombre, Edad FROM Personas WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Id", id);

                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    persona = new Persona()
                    {
                        Id = Convert.ToInt32(lector["id"]),
                        Nombre = lector["nombre"].ToString(),
                        Edad = int.Parse(lector["edad"].ToString())
                    };
                }
                conexion.Close();
            }

            return persona; // devuelve la persona encontrada o null si no existe
        }


        //METODO Eliminar---------------------------------------------------------------------------------
        public string Eliminar(Persona persona)
        {
            string query = "DELETE FROM Personas WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open(); //abro la conexion con la bdd
                   
                    SqlCommand instruccion = new SqlCommand(query, conexion);
                    instruccion.Parameters.AddWithValue("@Id", persona.Id);
                    instruccion.ExecuteNonQuery();
                    conexion.Close(); //cierro la conexion
                }

                return "La persona se elimino con éxito";
            }
            catch(Exception ex)
            {
                throw new Exception("Error al eliminar: " + ex.Message);

            }
        }


    }
}
