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
    public class DEstatusAlumno
    {
        private static string _conectString = ConfigurationManager.ConnectionStrings["TichDic1"].ConnectionString;

        public static List<EstatusAlumno> DConsultar()
        {
            List < EstatusAlumno > ListEstatu = new List<EstatusAlumno>();

            try
            {
                var query = $"consultarEstatusAlumnos";
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
                        EstatusAlumno unEstatus = new EstatusAlumno
                        {
                            id = Convert.ToInt32(reader["id"]),
                            nombre = reader["nombre"].ToString(),
                            clave = reader["nombre"].ToString(),
                        };

                        ListEstatu.Add(unEstatus);
                    }
                    con.Close();

                }

                if (ListEstatu == null)
                {
                    throw new Exception("No se ha encontrado la tabla");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }

            return ListEstatu;
        }

        public static EstatusAlumno DConsultar(int id)
        {
            EstatusAlumno UnEstatus = new EstatusAlumno();

            try
            {
                var query = $"consultarEstatusAlumnos";
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
                        EstatusAlumno EstatusUno = new EstatusAlumno
                        {
                            id = Convert.ToInt32(reader["id"]),
                            nombre = reader["nombre"].ToString(),
                            clave = reader["nombre"].ToString(),
                        };

                        UnEstatus = EstatusUno;
                    }
                    con.Close();

                }

                if (UnEstatus == null)
                {
                    throw new Exception("No se ha encontrado la tabla");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }

            return UnEstatus;
        }

        public static int DAgregar(EstatusAlumno DataEstatus)
        {
            int Result = 0;

            return Result;
        }

        public static int DActualizar(EstatusAlumno DataEstatus)
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
