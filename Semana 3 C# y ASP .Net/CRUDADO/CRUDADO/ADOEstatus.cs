using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUDADO
{
    internal class ADOEstatus : ICRUDEstatus
    {
        private List<Estatus> _listaEstatus = new List<Estatus>();

        private string _conectString = ConfigurationManager.ConnectionStrings["TichDic"].ConnectionString;

        public void ConsultarTodos()
        {
            try
            {
                var query = $"select * from EstatusAlumnos";

                SqlCommand comando;

                using (SqlConnection con = new SqlConnection(_conectString))
                {
                    comando = new SqlCommand(query, con);
                    comando.CommandType = System.Data.CommandType.Text;
                    con.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    _listaEstatus = new List<Estatus>();

                    while (reader.Read())
                    {
                        _listaEstatus.Add(
                            new Estatus()
                            {
                                id = Convert.ToInt32(reader["id"]),
                                clave = reader["clave"].ToString(),
                                nombre = reader["nombre"].ToString(),
                            }
                            );
                    }
                    con.Close();

                }

                if (_listaEstatus == null)
                {
                    throw new Exception("No se ha encontrado la tabla");
                }
                else
                {
                    foreach (var item in _listaEstatus)
                    {
                        Console.WriteLine($"ID: {item.id} Clave: {item.clave} Nombre: {item.nombre}");
                    }
                }

                Console.ReadKey();

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }

        }

        public void ConsultarUno(int id)
        {
            try
            {
                var query = $"ConsultarUNO";

                SqlCommand comando;

                using (SqlConnection con = new SqlConnection(_conectString))
                {
                    comando = new SqlCommand(query, con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    reader.Read();
                    _listaEstatus = new List<Estatus>();

                    Estatus SelectUNO = (
                        new Estatus()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            clave = reader["clave"].ToString(),
                            nombre = reader["nombre"].ToString(),
                        }
                        );

                    _listaEstatus.Add(SelectUNO);
                    con.Close();

                }

                if (_listaEstatus == null)
                {
                    throw new Exception("No se ha encontrado la tabla");
                }
                else
                {
                    foreach (var item in _listaEstatus)
                    {
                        Console.WriteLine($"ID: {item.id} Clave: {item.clave} Nombre: {item.nombre}");
                    }
                }

                Console.ReadKey();

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }
        }

        public void Agregar(string clave, string nombre)
        {
            try
            {
                int result = 0;
                var query = $"INSERT INTO EstatusAlumnos (clave, nombre) VALUES ('{clave}','{nombre}')";

                SqlCommand comando;

                using (SqlConnection con = new SqlConnection(_conectString))
                {
                    comando = new SqlCommand(query, con);
                    comando.CommandType = System.Data.CommandType.Text;
                    con.Open();
                    result = comando.ExecuteNonQuery();
                    con.Close();
                }

                if (result == 0)
                {
                    throw new Exception("Hubo un error en la insercción");
                }
                else
                {
                   
                   Console.WriteLine($"Cantidad de filas agregadas {result}");
                    
                }

                Console.ReadKey();

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }

        }

        public void Actualizar(int id, string clave, string nombre)
        {
            try
            {
                int result = 0;
                var query = $"UPDATE EstatusAlumnos SET clave = '{clave}', nombre = '{nombre}' FROM EstatusAlumnos WHERE id = {id})";

                SqlCommand comando;

                using (SqlConnection con = new SqlConnection(_conectString))
                {
                    comando = new SqlCommand(query, con);
                    comando.CommandType = System.Data.CommandType.Text;
                    con.Open();
                    result = comando.ExecuteNonQuery();
                    con.Close();
                }

                if (result == 0)
                {
                    throw new Exception("Hubo un error en la insercción");
                }
                else
                {

                    Console.WriteLine($"Cantidad de filas actualizadas {result}");

                }

                Console.ReadKey();

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }

        }

        public void Eliminar(int id)
        {
            try
            {
                int result = 0;
                var query = $"DELETE FROM EstatusAlumnos WHERE id = {id}";

                SqlCommand comando;

                using (SqlConnection con = new SqlConnection(_conectString))
                {
                    comando = new SqlCommand(query, con);
                    comando.CommandType = System.Data.CommandType.Text;
                    con.Open();
                    result = comando.ExecuteNonQuery();
                    con.Close();
                }

                if (result == 0)
                {
                    throw new Exception("Hubo un error en la insercción");
                }
                else
                {

                    Console.WriteLine($"Cantidad de filas eliminadas {result}");

                }

                Console.ReadKey();

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }
        }
    }
}
