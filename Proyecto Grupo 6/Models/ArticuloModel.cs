using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;
using Proyecto_Grupo_6.Entities;

namespace Proyecto_Grupo_6.Models
{
    public class ArticuloModel
    {

        public int AgregarArticulo(ArticuloEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string url = ConfigurationManager.AppSettings["urlApiAriel"].ToString() + "api/AgregarArticulo";
                JsonContent body = JsonContent.Create(entidad); //Serializar
                HttpResponseMessage resp = client.PostAsync(url, body).Result;

                if (resp.IsSuccessStatusCode)
                {
                    return resp.Content.ReadFromJsonAsync<int>().Result;
                }

                return 0;
            }
        }


        // retorna la lista de los articulos en la base de datos.
        public List<ArticuloEnt> ConsultaArticulos()
        {
            using (var client = new HttpClient())
            {
                
                string url = ConfigurationManager.AppSettings["urlApiAriel"].ToString() + "api/ConsultaArticulos";
        
                HttpResponseMessage resp = client.GetAsync(url).Result;

                if (resp.IsSuccessStatusCode)
                {
                    return resp.Content.ReadFromJsonAsync<List<ArticuloEnt>>().Result;
                }
                return new List<ArticuloEnt>();
            }
        }


        public int BorrarArticulo(long q)
        {
            using (var client = new HttpClient())
            {
                
                string url = ConfigurationManager.AppSettings["urlApiAriel"].ToString() + "api/RemoverArticulo?q=" + q;
                HttpResponseMessage resp = client.DeleteAsync(url).Result;

                if (resp.IsSuccessStatusCode)
                {
                    return resp.Content.ReadFromJsonAsync<int>().Result;
                }

                return 0;
            }
        }

    }
}