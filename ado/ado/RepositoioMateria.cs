using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace ado
{
    public class RepositoioMateria
    {
        private List<Materia> listaMaterias;
        private string conexion = "Data Source=RCAL1306P13-111;Initial Catalog=Universidad;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False";

        public RepositoioMateria()
        {
            listaMaterias = new List<Materia>();
        }




        public List<Materia> Listar()
        {
            string query = "select * from Materia";
            try
            {
                using (SqlConnection conn= new SqlConnection(conexion))
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand (query,conn);
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read()) //como si fuese un booleano
                    {
                        Materia unaMateria = new Materia();
                        unaMateria.Nombre = reader["Nombre"].ToString();
                        unaMateria.Id = int.Parse(reader["Id"].ToString()); //priemro a string y desp lo paso a un int
                        unaMateria.CantidadHoras = int.Parse(reader["cantidadHoras"].ToString());

                        listaMaterias.Add(unaMateria);
                    }
                    conn.Close();

                    return listaMaterias; //corta el meotodo, lo de abajo no lo ejecuta
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Ocurrio algo relacionado a la base de datos    ");
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex);
            }
            return listaMaterias;
        }


        public void Agregar(Materia materia)
        {
          string query = "INSERT INTO Materias (Nombre, cantidadHoras) VALUES" + "(@Nombre, @CantidadHoras)";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@Nombre", materia.Nombre);
                    comando.Parameters.AddWithValue("@CantidadHoras", materia.CantidadHoras);

                    comando.ExecuteNonQuery(); //manda las listas afectadas

                    conn.Close();

                }
            }


            catch (Exception ex) {
                throw new Exception("Error" + ex);

            }
        }



    }
}