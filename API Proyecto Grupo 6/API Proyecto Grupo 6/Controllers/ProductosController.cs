using API_Proyecto_Grupo_6.Entities;
using API_Proyecto_Grupo_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Web.Http;

namespace API_Proyecto_Grupo_6.Controllers
{
    public class ProductosController : ApiController
    {
        
        //Ver todos los productos

        [HttpGet]
        [Route("api/Productos")]
        public List<ProductosEnt> ConsultarCursos()

        {
            using (var bd = new ProyectoPrograEntities())
            {
                var datos = (from x in bd.Products select x).ToList();

                if (datos.Count > 0 )
                {
                    var resp = new List<ProductosEnt>();
                    foreach (var item in datos)
                    {
                        resp.Add(new ProductosEnt()
                        {
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
                    return new List<ProductosEnt>();
                }
            }   
        }


        //Consultar un producto especifico

        [HttpGet]
        [Route("api/Productos")]
        public List<ProductosEnt> ConsultarCursos()

        {
            using (var bd = new ProyectoPrograEntities())
            {
                var datos = (from x in bd.Products select x).ToList();

                if (datos.Count > 0)
                {
                    var resp = new List<ProductosEnt>();
                    foreach (var item in datos)
                    {
                        resp.Add(new ProductosEnt()
                        {
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
                    return new List<ProductosEnt>();
                }
            }
        }

        //Eliminar un producto
        [HttpGet]
        [Route("api/Productos")]
        public List<ProductosEnt> ConsultarCursos()

        {
            using (var bd = new ProyectoPrograEntities())
            {
                var datos = (from x in bd.Products select x).ToList();

                if (datos.Count > 0)
                {
                    var resp = new List<ProductosEnt>();
                    foreach (var item in datos)
                    {
                        resp.Add(new ProductosEnt()
                        {
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
                    return new List<ProductosEnt>();
                }
            }
        }

        //Crear un Producto
        [HttpGet]
        [Route("api/Productos")]
        public List<ProductosEnt> ConsultarCursos()

        {
            using (var bd = new ProyectoPrograEntities())
            {
                var datos = (from x in bd.Products select x).ToList();

                if (datos.Count > 0)
                {
                    var resp = new List<ProductosEnt>();
                    foreach (var item in datos)
                    {
                        resp.Add(new ProductosEnt()
                        {
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
                    return new List<ProductosEnt>();
                }
            }
        }

        //Modificar un producto
        [HttpGet]
        [Route("api/Productos")]
        public List<ProductosEnt> ConsultarCursos()

        {
            using (var bd = new ProyectoPrograEntities())
            {
                var datos = (from x in bd.Products select x).ToList();

                if (datos.Count > 0)
                {
                    var resp = new List<ProductosEnt>();
                    foreach (var item in datos)
                    {
                        resp.Add(new ProductosEnt()
                        {
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
                    return new List<ProductosEnt>();
                }
            }
        }
    }
}
