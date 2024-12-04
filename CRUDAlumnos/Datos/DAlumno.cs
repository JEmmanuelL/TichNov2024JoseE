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
    public class DAlumno
    {
        private static string _conectString = ConfigurationManager.ConnectionStrings["TichDic1"].ConnectionString;

        public static List<Alumno> DConsultar()
        {
            List<Alumno> ListAlu = new List<Alumno>();


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
                       Alumno Alumno = new Alumno{
                                id = Convert.ToInt32(reader["id"]),
                                nombre = reader["nombre"].ToString(),
                                primerApellido = reader["primerApellido"].ToString(),
                                segundoApellido = reader["segundoApellido"].ToString(),
                                correo = reader["correo"].ToString(),
                                telefono = reader["telefono"].ToString(),
                                fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]),
                                curp = reader["curp"].ToString(),
                                sueldo = reader["sueldo"].ToString() == null?0:1,
                                idEstadoOrigen = Convert.ToInt32(reader["idEstadoOrigen"]),
                                idEstatus = Convert.ToInt32(reader["idEstatus"]),
                       };

                        ListAlu.Add(Alumno);
                    }
                    con.Close();

                }

                if (ListAlu == null)
                {
                    throw new Exception("No se ha encontrado la tabla");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }

            return ListAlu;
        }

        public static Alumno DConsultar(int id)
        {
            Alumno Alumn = new Alumno();

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
                        Alumno Alumno = new Alumno
                        {
                            id = Convert.ToInt32(reader["id"]),
                            nombre = reader["nombre"].ToString(),
                            primerApellido = reader["primerApellido"].ToString(),
                            segundoApellido = reader["segundoApellido"].ToString(),
                            correo = reader["correo"].ToString(),
                            telefono = reader["telefono"].ToString(),
                            fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]),
                            curp = reader["curp"].ToString(),
                            sueldo = reader["sueldo"].ToString() == null ? 0 : 1,
                            idEstadoOrigen = Convert.ToInt32(reader["idEstadoOrigen"]),
                            idEstatus = Convert.ToInt32(reader["idEstatus"]),
                        };

                        Alumn = Alumno;
                    }
                    con.Close();

                }

                if (Alumn == null)
                {
                    throw new Exception("No se ha encontrado la tabla");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }


            return Alumn;
        }

        public static int DAgregar(Alumno DataAlum)
        {
            int Result = 0;

            try
            {
                var query = $"agregarAlumnos";
                SqlCommand comando;

                using (SqlConnection con = new SqlConnection(_conectString))
                {

                    comando = new SqlCommand(query, con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombre", DataAlum.nombre);
                    comando.Parameters.AddWithValue("@primerApellido", DataAlum.primerApellido);
                    comando.Parameters.AddWithValue("@segundoApellido", DataAlum.segundoApellido);
                    comando.Parameters.AddWithValue("@correo", DataAlum.correo);
                    comando.Parameters.AddWithValue("@telefono", DataAlum.telefono);
                    comando.Parameters.AddWithValue("@fechaNacimiento", DataAlum.fechaNacimiento);
                    comando.Parameters.AddWithValue("@curp", DataAlum.curp);
                    comando.Parameters.AddWithValue("@sueldo", DataAlum.sueldo);
                    comando.Parameters.AddWithValue("@idEstadoOrigen", DataAlum.idEstadoOrigen);
                    comando.Parameters.AddWithValue("@idEstatus", DataAlum.idEstatus);

                    con.Open();
                    Result = comando.ExecuteNonQuery();

                    con.Close();

                }

                if (Result == 0)
                {
                    throw new Exception("No se ha encontrado la tabla");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }

            return Result;
        }

        public static int DActualizar(Alumno DataAlum)
        {
            int Result = 0;

            try
            {
                var query = $"actualizarAlumnos";
                SqlCommand comando;

                using (SqlConnection con = new SqlConnection(_conectString))
                {

                    comando = new SqlCommand(query, con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", DataAlum.id);
                    comando.Parameters.AddWithValue("@nombre", DataAlum.nombre);
                    comando.Parameters.AddWithValue("@primerApellido", DataAlum.primerApellido);
                    comando.Parameters.AddWithValue("@segundoApellido", DataAlum.segundoApellido);
                    comando.Parameters.AddWithValue("@correo", DataAlum.correo);
                    comando.Parameters.AddWithValue("@telefono", DataAlum.telefono);
                    comando.Parameters.AddWithValue("@fechaNacimiento", DataAlum.fechaNacimiento);
                    comando.Parameters.AddWithValue("@curp", DataAlum.curp);
                    comando.Parameters.AddWithValue("@sueldo", DataAlum.sueldo);
                    comando.Parameters.AddWithValue("@idEstadoOrigen", DataAlum.idEstadoOrigen);
                    comando.Parameters.AddWithValue("@idEstatus", DataAlum.idEstatus);

                    con.Open();
                    Result = comando.ExecuteNonQuery();

                    con.Close();

                }

                if (Result == 0)
                {
                    throw new Exception("No se ha encontrado la tabla");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }

            return Result;
        }

        public static int DEliminar(int id)
        {
            int Result = 0;


            try
            {
                var query = $"eliminarAlumnos";
                SqlCommand comando;

                using (SqlConnection con = new SqlConnection(_conectString))
                {

                    comando = new SqlCommand(query, con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);

                    con.Open();
                    Result = comando.ExecuteNonQuery();

                    con.Close();

                }

                if (Result == 0)
                {
                    throw new Exception("No se ha encontrado la tabla");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }

            return Result;

        }
    }
}
