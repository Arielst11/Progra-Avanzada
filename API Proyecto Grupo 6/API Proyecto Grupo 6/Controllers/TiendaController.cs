using API_Proyecto_Grupo_6.Entities;
using API_Proyecto_Grupo_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Proyecto_Grupo_6.Controllers
{
    public class TiendaController : ApiController
    {

        //Metodo para consultar todos los productos en la base de datos
        [HttpGet]
        [Route("api/ConsultarTodos")]
        public List<TiendaEnt> ConsultarTodos()
        {
            using (var bd = new ProyectoPrograEntities1())
            {
                var datos = (from x in bd.Products select x).ToList();

                if (datos.Count > 0 )
                {
                    var resp = new List<TiendaEnt>();
                    foreach (var item in datos)
                    {
                        resp.Add(new TiendaEnt {

                            ProductId = item.ProductId,

                            ProductName = item.ProductName,

                            Description = item.Description,

                            Price = item.Price


                        });
                     
                    }
                    return resp;
                }
                else
                {
                    return new List<TiendaEnt>();
                }
            }
        }
    }
}
