using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADOWebForms.Entidades
{
    public class ADOEstatusAlumno : ICRUD
    {
        public List<EstatusAlumno> _listaEstatus = new List<EstatusAlumno>();

        private string _conectString = ConfigurationManager.ConnectionStrings["TichDic1"].ConnectionString;

        public List<EstatusAlumno> Consultar()
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

                    _listaEstatus = new List<EstatusAlumno>();

                    while (reader.Read())
                    {
                        _listaEstatus.Add(
                            new EstatusAlumno()
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
            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }

            return _listaEstatus;

        }

        public EstatusAlumno Consultar(int id)
        {
            EstatusAlumno resu = new EstatusAlumno();

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

                    EstatusAlumno SelectUNO = (
                        new EstatusAlumno()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            clave = reader["clave"].ToString(),
                            nombre = reader["nombre"].ToString(),
                        }
                        );

                    resu = SelectUNO;
                    con.Close();

                }

                if (_listaEstatus == null)
                {
                    throw new Exception("No se ha encontrado la tabla");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }
            return resu;

        }

        public int Agregar(EstatusAlumno DataEstatus)
        {
            int resu = 0;
            try
            {
                int result = 0;
                var query = $"INSERT INTO EstatusAlumnos (clave, nombre) VALUES ('{DataEstatus.clave}','{DataEstatus.nombre}')";

                SqlCommand comando;

                using (SqlConnection con = new SqlConnection(_conectString))
                {
                    comando = new SqlCommand(query, con);
                    comando.CommandType = System.Data.CommandType.Text;
                    con.Open();
                    resu = comando.ExecuteNonQuery();
                    con.Close();
                }

                if (result == 0)
                {
                    throw new Exception("Hubo un error en la insercción");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }
            return resu;
        }


        public void Actualizar(EstatusAlumno DataEstatus)
        {
            try
            {
                int result = 0;
                var query = $"UPDATE EstatusAlumnos SET clave = '{DataEstatus.clave}', nombre = '{DataEstatus.nombre}' FROM EstatusAlumnos WHERE id = {DataEstatus.id}";

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

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }
        }
    }
}