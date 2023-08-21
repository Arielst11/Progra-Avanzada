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
    public class ArticuloCarritoModel
    {

        public int AgregarArticuloCarrito(ArticuloCarritoEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string url = ConfigurationManager.AppSettings["urlApiAriel"].ToString() + "api/AgregarArticuloCarrito";
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
        public List<ArticuloCarritoEnt> ConsultaArticulosCarrito()
        {
            using (var client = new HttpClient())
            {
                
                string url = ConfigurationManager.AppSettings["urlApiAriel"].ToString() + "api/ConsultaArticulosCarrito";
        
                HttpResponseMessage resp = client.GetAsync(url).Result;

                if (resp.IsSuccessStatusCode)
                {
                    return resp.Content.ReadFromJsonAsync<List<ArticuloCarritoEnt>>().Result;
                }
                return new List<ArticuloCarritoEnt>();
            }
        }


        public int BorrarArticuloCarrito(long q)
        {
            using (var client = new HttpClient())
            {
                
                string url = ConfigurationManager.AppSettings["urlApiAriel"].ToString() + "api/RemoverArticuloCarrito?q=" + q;
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