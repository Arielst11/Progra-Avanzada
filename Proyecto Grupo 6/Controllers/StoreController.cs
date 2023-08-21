using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_Grupo_6.Models;
using Proyecto_Grupo_6.Entities;
namespace Proyecto_Grupo_6.Controllers
{
    public class StoreController : Controller
    {
        ArticuloModel modeloArticulo = new ArticuloModel();

        public ActionResult index()
        {
            ViewBag.Message = "Your contact page.";

            return View("index");
        }


        
        public ActionResult contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact");
        }


        [HttpGet]
        public ActionResult shop()
        {
           
            var articulosLista = modeloArticulo.ConsultaArticulos();

            ViewBag.Message = "Your contact page.";

          return View("Shop" , articulosLista);
            
        }

        public ActionResult blog()
        {
            ViewBag.Message = "Your blog page.";

            return View("Blog");
        }

        public ActionResult shopDetails()
        {
            ViewBag.Message = "Your shop details.";

            return View("shopDetails");
        }

        public ActionResult shopingCart()
        {
            ViewBag.Message = "Your shoping cart.";

            return View("shopingCart");
        }

        public ActionResult checkout()
        {
            ViewBag.Message = "Your checkout.";

            return View("checkout");
        }

        public ActionResult Registro()
        {

            return View("Registro");
        }


        public ActionResult IniciarSesion()
        {

            return View("IniciarSesion");
        }


        public ActionResult menuAdmin()
        {
            return View("MenuAdmin");
        }


        public ActionResult AgregarArticulo()
        {
            return View("AgregarArticulo");
        }



        [HttpGet]
        public ActionResult BorrarArticulo()
        {
            var articulosLista = modeloArticulo.ConsultaArticulos();
            return View("BorrarArticulo", articulosLista);
        }


        [HttpGet]
        public ActionResult ActualizarArticulo()
        {
            var articulosLista = modeloArticulo.ConsultaArticulos();
            return View("ActualizarArticulo" , articulosLista);
        }

        [HttpGet]
        public ActionResult ActualizarArticuloConId(long q)
        {
            var articuloEntidad = modeloArticulo.ActualizarArticulo(q);

            if(articuloEntidad.ProductId == null)
            {
                return RedirectToAction("ActualizarArticulo", "Store"); // esto no deberia pasar....
            }

            return View ("FormularioArticuloActualizar", articuloEntidad);
        }



        // mismo metodo que el articulocontroller para retornar un articulo ent de la base de datos
        // se puede usar el mismo metodo de actualizar articulo, en realidad este metodo solo retornar el articulo de la base de datos con id = q
        [HttpGet]
        public ActionResult AgregarArticuloCarrito(long q)
        {
            var articuloEntidad = modeloArticulo.ActualizarArticulo(q);

            if (articuloEntidad.ProductId == null)
            {
                return RedirectToAction("shop", "Store"); // esto no deberia pasar....
            }

            return View("FormularioConfirmarAgregarAlCarrito", articuloEntidad);
        }






    }
}