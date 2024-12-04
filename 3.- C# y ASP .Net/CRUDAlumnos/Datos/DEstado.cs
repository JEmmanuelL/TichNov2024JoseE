using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEstado
    {
        private static string _conectString = ConfigurationManager.ConnectionStrings["TichDic1"].ConnectionString;

        public static List<Estado> DConsultar()
        {
            List<Estado> ListEstado = new List<Estado>();

            try
            {
                var query = $"consultarEAlumnos";
                SqlCommand comando;

                using (SqlConnection con = new SqlConnection(_conectString))
                {

                    comando = new SqlCommand(query, con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", -1);
                    con.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Estado EstadoUno = new Estado
                        {
                            id = Convert.ToInt32(reader["id"]),
                            nombre = reader["nombre"].ToString(),
                        };

                        ListEstado.Add(EstadoUno);
                    }
                    con.Close();

                }

                if (ListEstado == null)
                {
                    throw new Exception("No se ha encontrado la tabla");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }

            return ListEstado;
        }

        public static Estado DConsultar(int id)
        {
            Estado EstadUn = new Estado();

            try
            {
                var query = $"consultarEAlumnos";
                SqlCommand comando;

                using (SqlConnection con = new SqlConnection(_conectString))
                {

                    comando = new SqlCommand(query, con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Estado EstadoUno = new Estado
                        {
                            id = Convert.ToInt32(reader["id"]),
                            nombre = reader["nombre"].ToString(),
                        };

                    }
                    con.Close();

                }

                if (EstadUn == null)
                {
                    throw new Exception("No se ha encontrado la tabla");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }

            return EstadUn;
        }

        public static int DAgregar(Estado DataEstatus)
        {
            int Result = 0;

            return Result;
        }

        public static int DActualizar(Estado DataEstatus)
        {
            int Result = 0;

            return Result;
        }

        public static int DEliminar(int id)
        {
            int Result = 0;

            return Result;

        }
    }
}
