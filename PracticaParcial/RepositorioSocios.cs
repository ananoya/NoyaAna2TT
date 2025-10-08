using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;


namespace PracticaParcial
{
    public class RepositorioSocios
    {
        private string conexion = "Data Source=ANA_NOYA\\SQLEXPRESS;Initial Catalog=club2;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False";

        public List<Socios> listaSocios;

        //constructor del repositorio
        public RepositorioSocios()
        {
            listaSocios = new List<Socios>();
        }

        public List<Socios> Listar()
        {
            string query = "SELECT * FROM Socios";

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {

                    con.Open();

                    SqlCommand comando = new SqlCommand(query, con); //hago el comando a sql con la query y conexion
                    SqlDataReader lector = comando.ExecuteReader(); //leo eso 

                    while (lector.Read()) //hago un while para leer todo y que corte  
                    {
                        Socios socio = new Socios();
                        socio.Id = int.Parse(lector["id"].ToString());
                        socio.Nombre = lector["nombre"].ToString();
                        socio.Apellido = lector["apellido"].ToString();
                        socio.Dni = lector["dni"].ToString();
                        socio.FechaNacimiento = DateTime.Parse(lector["fecha_nacimiento"].ToString());
                        socio.NumeroSocio = int.Parse(lector["numero_socio"].ToString());
                        socio.CuotaSAlDia = bool.Parse(lector["cuota_al_dia"].ToString());

                        listaSocios.Add(socio);
                    }
                    con.Close();
                    return listaSocios;

                }
            }
            catch (Exception ex) {
                throw new Exception("Error al listar los socios: " + ex.Message);
            }

        }

        public void Agregar(Socios socio)
        {
            string query = "INSERT INTO Socios (nombre, apellido, dni, fecha_nacimiento, numero_socio, cuota_al_dia) " +
                           "VALUES (@Nombre, @Apellido, @Dni, @FechaNacimiento, @NumeroSocio, @CuotaAlDia)";
        
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    SqlCommand comando = new SqlCommand(query, con);

                    comando.Parameters.AddWithValue("@Nombre", socio.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", socio.Apellido);   
                    comando.Parameters.AddWithValue("@Dni", socio.Dni);
                    comando.Parameters.AddWithValue("@FechaNacimiento", socio.FechaNacimiento);
                    comando.Parameters.AddWithValue("@NumeroSocio", socio.NumeroSocio);
                    comando.Parameters.AddWithValue("@CuotaAlDia", socio.CuotaSAlDia);
                    
                    comando.ExecuteNonQuery(); //ejecuto el comando

                    con.Close();

                }
            } 
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el socio: " + ex.Message);
            }
        }

        public Socios Modificar(Socios socio)
        {
            string query = "UPDATE Socios SET nombre = @Nombre, apellido = @Apellido, dni = @Dni, fecha_nacimiento = @FechaNacimiento, numero_socio = @NumeroSocio, cuota_al_dia = @CuotaAlDia WHERE id = @Id";


            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    SqlCommand comando = new SqlCommand(query, con);

                    comando.Parameters.AddWithValue("@Nombre", socio.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", socio.Apellido);
                    comando.Parameters.AddWithValue("@Dni", socio.Dni);
                    comando.Parameters.AddWithValue("@FechaNacimiento", socio.FechaNacimiento);
                    comando.Parameters.AddWithValue("@NumeroSocio", socio.NumeroSocio);
                    comando.Parameters.AddWithValue("@CuotaAlDia", socio.CuotaSAlDia);
                    comando.Parameters.AddWithValue("@Id", socio.Id);

                    comando.ExecuteNonQuery(); //ejecuto el comando

                    con.Close();
                    return socio; 
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el socio: " + ex.Message);
            }

        }

        public void Eliminar (int id)
        {
            string query = "DELETE FROM Socios WHERE id = @id ";

            
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {

                    con.Open();
                    SqlCommand comando = new SqlCommand(query, con);
                    
                    comando.Parameters.AddWithValue("@Id",id);
                    comando.ExecuteNonQuery(); // <- faltaba esto
                    con.Close();
                }
            }
            catch (Exception ex) 
            { 
                throw new Exception("Error al eliminar el socio: " + ex.Message);
            
            }  

        }
        public Socios ObtenerPorId(int id)
        {
            string query = "SELECT id, nombre, apellido, dni, fecha_nacimiento, numero_socio, cuota_al_dia FROM Socios WHERE Id = @Id";
            try
            {
                Socios socios = null;// lo inicializo en null para que no me de error
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    SqlCommand comando = new SqlCommand(query, con); //hago el comando a sql con la query y conexion
                    
                    comando.Parameters.AddWithValue("@Id", id);
                    
                    SqlDataReader lector = comando.ExecuteReader(); //leo eso 
                    
                    if (lector.Read()) //hago un while para leer todo y que corte  
                    {
                         socios = new Socios() //instancio el objeto creado
                         {
                            Id = int.Parse(lector["id"].ToString()),
                            Nombre = lector["nombre"].ToString(),
                            Apellido = lector["apellido"].ToString(),
                            Dni = lector["dni"].ToString(),
                            FechaNacimiento = DateTime.Parse(lector["fecha_nacimiento"].ToString()),
                            NumeroSocio = int.Parse(lector["numero_socio"].ToString()),
                            CuotaSAlDia = bool.Parse(lector["cuota_al_dia"].ToString())
                        };
                        
                    }

                    con.Close();
                    return socios; //retorno el objeto
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el socio por ID: " + ex.Message);
            }
        }

        public List<Socios> ListarCuotaAlDia () //parecido al listar pero con un filtro
        {
            string query= "SELECT * FROM Socios WHERE cuota_al_dia = 1"; //1 es true

            
            try
            {
                List<Socios> listaSociosCuotaAlDia;
                listaSociosCuotaAlDia = new List<Socios>();

                using (SqlConnection con = new SqlConnection(conexion)) 
                {
                    using SqlCommand comando = new SqlCommand(query, con);
                    con.Open();

                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        Socios socio = new Socios()
                        {
                            Id = int.Parse(lector["id"].ToString()),
                            Nombre = lector["nombre"].ToString(),
                            Apellido = lector["apellido"].ToString(),
                            Dni = lector["dni"].ToString(),
                            FechaNacimiento = DateTime.Parse(lector["fecha_nacimiento"].ToString()),
                            NumeroSocio = int.Parse(lector["numero_socio"].ToString()),
                            CuotaSAlDia = bool.Parse(lector["cuota_al_dia"].ToString())

                        };
                        
                        listaSociosCuotaAlDia.Add(socio);
                    }
                    con.Close();
                }
                return listaSociosCuotaAlDia;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los socios con cuota al dia: " + ex.Message);
            }
        }


        public int CantidadSociosCuotaAlDia()
        {
            string query = "SELECT COUNT(*) FROM Socios WHERE cuota_al_dia = 1";

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    con.Open();
                    int cantidad = (int)comando.ExecuteScalar(); // Devuelve el primer valor de la primera fila
                    return cantidad;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al calcular la cantidad de socios con cuota al día: " + ex.Message);
            }
        }


        /*
        public List<Socios> FiltrarEdad(int edad)
        {
            string query = "SELECT * FROM Socios WHERE DATEDIFF(year, fecha_nacimiento, GETDATE()) = @Edad";
            try
            {
                List<Socios> listaEdad = new List<Socios>();

                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    SqlCommand comando = new SqlCommand(query, con);
                    SqlDataReader lector = comando.ExecuteReader();


                    comando.Parameters.AddWithValue("@Edad", edad);

                    while (lector.Read("@Edad") == edad)
                    {
                        Socios socio = new Socios()
                        {
                            Id = int.Parse(lector["id"].ToString()),
                            Nombre = lector["nombre"].ToString(),
                            Apellido = lector["apellido"].ToString(),
                            Dni = lector["dni"].ToString(),
                            FechaNacimiento = DateTime.Parse(lector["fecha_nacimiento"].ToString()),
                            NumeroSocio = int.Parse(lector["numero_socio"].ToString()),
                            CuotaSAlDia = bool.Parse(lector["cuota_al_dia"].ToString())
                        };
                        listaEdad.Add(socio);
                    }
                    con.Close();
                }
                return listaEdad;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar por edad: " + ex.Message);

            }
        }*/
    }
}
