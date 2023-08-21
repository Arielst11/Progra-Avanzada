using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Proyecto_Grupo_6.Models;
using Proyecto_Grupo_6.Entities;



namespace Proyecto_Grupo_6.Controllers
{
    public class ArticuloCarritoController : Controller
    {

        ArticuloModel modeloArticulo = new ArticuloModel();
        ArticuloCarritoModel modeloArticuloCarrito = new ArticuloCarritoModel();





        [HttpPost]
        public ActionResult AgregarArticuloAlCarrito(ArticuloEnt entidad)
        {
            ArticuloCarritoEnt articuloCarrito = new ArticuloCarritoEnt();
            articuloCarrito.ProductId = entidad.ProductId;
            articuloCarrito.ProductName = entidad.ProductName;
            articuloCarrito.Description = entidad.Description;
            articuloCarrito.Price = entidad.Price;
            articuloCarrito.Image = entidad.Image;


            var resp = modeloArticuloCarrito.AgregarArticuloCarrito(articuloCarrito);

            if (resp > 0)
            {
                ViewBag.MsjPantallaArticuloAgregado = "Artículo " + articuloCarrito.ProductName + " Agregado correctamente";
                return RedirectToAction("shop", "Store");
            }

            else
            {
                ViewBag.MsjPantallaArticuloAgregado = "No se ha podido registrar el Artículo";
                return RedirectToAction("shop", "Store");
            }
        }









    }
}