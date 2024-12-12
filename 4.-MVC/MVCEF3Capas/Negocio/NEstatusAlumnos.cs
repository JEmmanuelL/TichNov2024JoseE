using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Entidades;
using System.Data.Entity;
using System.Configuration;
using Newtonsoft.Json;

namespace Negocio
{
    public class NEstatusAlumnos
    {
        string urlWebAPI = ConfigurationManager.AppSettings["urlWebAPI"];

        private List<EstatusAlumnos> _lstEstatusAlu;
        public List<EstatusAlumnos> WAPINConsultar()
        {
            try
            {
                using(var client = new HttpClient())
                {
                    Task<HttpResponseMessage> responseTask = client.GetAsync(urlWebAPI);
                    responseTask.Wait();
                    HttpResponseMessage result = responseTask.Result;

                    if (result.IsSuccessStatusCode)
                    {
                        Task<string> readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();
                        string json = readTask.Result;
                        _lstEstatusAlu = JsonConvert.DeserializeObject<List<EstatusAlumnos>>(json);

                    }
                    else
                    {
                        throw new Exception($"WebAPI. Respondio con error.{result.StatusCode}");

                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception($"WebAPI. Respondio con error.{ex.Message}");

            }


            return _lstEstatusAlu;
        }
        public EstatusAlumnos WAPINConsultar(int id)
        {
            EstatusAlumnos unEstatus = new EstatusAlumnos();

            try
            {

                using (var client = new HttpClient())
                {
                    Task<HttpResponseMessage> responseTask = client.GetAsync(urlWebAPI + $"/{id}");
                    responseTask.Wait();
                    HttpResponseMessage result = responseTask.Result;

                    if (result.IsSuccessStatusCode)
                    {
                        Task<string> readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();
                        string json = readTask.Result;
                        unEstatus = JsonConvert.DeserializeObject<EstatusAlumnos>(json);

                    }
                    else
                    {
                        throw new Exception($"WebAPI. Respondio con error.{result.StatusCode}");

                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception($"WebAPI. Respondio con error.{ex.Message}");
            }

            return unEstatus;
        }
        public EstatusAlumnos WAPINAgregar(EstatusAlumnos DataEstatus)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(DataEstatus), Encoding.UTF8);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    Task<HttpResponseMessage> postTask = client.PostAsync(urlWebAPI, httpContent);
                    postTask.Wait();
                    HttpResponseMessage result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();
                        string json = readTask.Result;
                        DataEstatus = JsonConvert.DeserializeObject<EstatusAlumnos>(json);

                    }
                    else
                    {
                        throw new Exception($"WebAPI. Respondio con error.{result.StatusCode}");
                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception($"WebAPI. Respondio con error.{ex.Message}");

            }

            return DataEstatus;
        }
        public void WAPINActualizar(EstatusAlumnos DataEstatus)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(DataEstatus), Encoding.UTF8);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    Task<HttpResponseMessage> putTask = client.PutAsync(urlWebAPI + $"/{DataEstatus.id}", httpContent);

                    putTask.Wait();
                    HttpResponseMessage result = putTask.Result;
                    if (!result.IsSuccessStatusCode)
                    {
                        throw new Exception($"WebAPI. Respondio con error.{result.StatusCode}");

                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception($"WebAPI. Respondio con error.{ex.Message}");

            }
        }

        public void WAPINEliminar(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    Task<HttpResponseMessage> deleteTask = client.DeleteAsync(urlWebAPI + $"/{id}");

                    deleteTask.Wait();
                    HttpResponseMessage result = deleteTask.Result;
                    if (!result.IsSuccessStatusCode)
                    {
                        throw new Exception($"WebAPI. Respondio con error.{result.StatusCode}");

                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception($"WebAPI. Respondio con error.{ex.Message}");
            }
        }
    }
}
