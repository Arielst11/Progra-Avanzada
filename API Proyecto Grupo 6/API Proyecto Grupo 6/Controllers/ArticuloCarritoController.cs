using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Proyecto_Grupo_6.Models;
using API_Proyecto_Grupo_6.Entities;

namespace API_Proyecto_Grupo_6.Controllers
{
    public class ArticuloCarritoController : ApiController
    {

        [HttpPost]
        [Route("api/AgregarArticuloCarrito")]
        public int AgregarArticuloCarrito(ArticuloCarritoEnt entidad)
        {
            using (var bd = new ProyectoPrograEntities())
            {
                Carrito tabla = new Carrito();
                tabla.ProductId = (int)entidad.ProductId;
                tabla.ProductName = entidad.ProductName;            
                tabla.Price = entidad.Price;
                tabla.Image = entidad.Image;

                bd.Carrito.Add(tabla);
                return bd.SaveChanges();
            }

        }

    

    [HttpGet]
    [Route("api/ConsultaArticulosCarrito")]
    public List<ArticuloCarritoEnt> ConsultaArticulosCarrito()
    {
        using (var bd = new ProyectoPrograEntities())
        {
            var datos = (from x in bd.Carrito
                         select x).ToList();

            if (datos.Count > 0)
            {
                var resp = new List<ArticuloCarritoEnt>();
                foreach (var item in datos)
                {
                    resp.Add(new ArticuloCarritoEnt
                    {

                        CarritoId = item.carritoId,
                        ProductId = item.ProductId,
                        ProductName = item.ProductName,
                        Price = item.Price,
                        Image = item.Image,
                        
                    });
                }
                return resp;
            }
            else
            {
                return new List<ArticuloCarritoEnt>();
            }
        }
    }


        [HttpDelete]
        [Route("api/RemoverArticuloCarrito")]
        public int RemoverArticuloCarrito(long q)
        {
            using (var bd = new ProyectoPrograEntities())
            {
                var ArticuloParaBorrarcarrito = (from x in bd.Carrito
                                       where x.carritoId == q
                                       select x).FirstOrDefault();

                if (ArticuloParaBorrarcarrito != null)
                {
                    bd.Carrito.Remove(ArticuloParaBorrarcarrito);
                    return bd.SaveChanges();
                }

                return 0;
            }
        }



        [HttpGet]
        [Route("api/RetornarArticulo")]
        public ArticuloEnt RetornarArticulo(long q)
        {
            using (var bd = new ProyectoPrograEntities())
            {
                var datos = (from x in bd.Products
                             where x.ProductId == q
                             select x ).FirstOrDefault();

                if (datos != null)
                {
                    ArticuloEnt resp = new ArticuloEnt();

                    resp.ProductId = datos.ProductId;
                    resp.ProductName = datos.ProductName;
                    resp.Description = datos.Description;
                    resp.Price = datos.Price;
                    resp.Image = datos.Image;


                    return resp;
                }
                else
                {
                    return new ArticuloEnt();
                }
            }
        }


        [HttpPut]
        [Route("api/ActualizarArticulo")]
        public void ActualizarCurso(ArticuloEnt entidad)
        {
            using (var bd = new ProyectoPrograEntities())
            {
                var ArticuloEncontrado = (from x in bd.Products
                                       where x.ProductId == entidad.ProductId
                                          select x).FirstOrDefault();

                if (ArticuloEncontrado != null)
                {
                    ArticuloEncontrado.ProductName = entidad.ProductName;
                    ArticuloEncontrado.Description = entidad.Description;
                    ArticuloEncontrado.Price = entidad.Price;
                    ArticuloEncontrado.Image = entidad.Image;                  
                    bd.SaveChanges();
                }

            }
        }




    }


}

