﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Proyecto_Grupo_6.Models;
using API_Proyecto_Grupo_6.Entities;

namespace API_Proyecto_Grupo_6.Controllers
{
    public class ArticuloController : ApiController
    {

        [HttpPost]
        [Route("api/AgregarArticulo")]
        public int AgregarArticulo(ArticuloEnt entidad)
        {
            using (var bd = new ProyectoPrograEntities())
            {
                Products tabla = new Products();
                tabla.ProductName = entidad.ProductName;
                tabla.Description = entidad.Description;
                tabla.Price = entidad.Price;
                tabla.Image = entidad.Image;

                bd.Products.Add(tabla);
                return bd.SaveChanges();
            }

        }

    

    [HttpGet]
    [Route("api/ConsultaArticulos")]
    public List<ArticuloEnt> ConsultaArticulos()
    {
        using (var bd = new ProyectoPrograEntities())
        {
            var datos = (from x in bd.Products
                         select x).ToList();

            if (datos.Count > 0)
            {
                var resp = new List<ArticuloEnt>();
                foreach (var item in datos)
                {
                    resp.Add(new ArticuloEnt
                    {
                        ProductId = item.ProductId,
                        ProductName = item.ProductName,
                        Description = item.Description,
                        Price = item.Price,
                        Image = item.Image,
                        
                    });
                }
                return resp;
            }
            else
            {
                return new List<ArticuloEnt>();
            }
        }
    }


        [HttpDelete]
        [Route("api/RemoverArticulo")]
        public int RemoverArticulo(long q)
        {
            using (var bd = new ProyectoPrograEntities())
            {
                var ArticuloParaBorrar = (from x in bd.Products
                                       where x.ProductId == q
                                       select x).FirstOrDefault();

                if (ArticuloParaBorrar != null)
                {
                    bd.Products.Remove(ArticuloParaBorrar);
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
