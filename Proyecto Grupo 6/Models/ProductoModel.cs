using Proyecto_Grupo_6.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Web;

namespace Proyecto_Grupo_6.Models
{
    public class ProductoModel
    {
        public List<ProductoEnt> ConsultarCursos()
        {
            using (var client = new HttpClient())
            {
                string url = ConfigurationManager.AppSettings["urlApiAriel"].ToString() + "api/Productos";
                                HttpResponseMessage resp = client.GetAsync(url).Result;

                if (resp.IsSuccessStatusCode)
                {
                    return resp.Content.ReadFromJsonAsync<List<ProductoEnt>>().Result;
                }

                return new List<ProductoEnt>();
            }
        }
    }
}