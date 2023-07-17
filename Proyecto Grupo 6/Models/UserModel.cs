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
    public class UserModel
    {

        public int RegistrarUsuario(UserEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string url = ConfigurationManager.AppSettings["urlApiAriel"].ToString() + "api/RegistrarUsuario";
                JsonContent body = JsonContent.Create(entidad); //Serializar
                HttpResponseMessage resp = client.PostAsync(url, body).Result;

                if (resp.IsSuccessStatusCode)
                {
                    return resp.Content.ReadFromJsonAsync<int>().Result;
                }

                return 0;
            }
        }

    }
}