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
    public class ArticuloController : Controller
    {

        ArticuloModel modeloArticulo = new ArticuloModel();


        [HttpPost]
        public ActionResult AgregarArticulo (ArticuloEnt entidad)
        {
          
            var resp = modeloArticulo.AgregarArticulo(entidad);

            if (resp > 0)
            {
                ViewBag.MsjPantallaArticuloAgregado = "Artículo " + entidad.ProductName + " registrado correctamente" ;
                return RedirectToAction("shop", "Store");
            }

            else
            {
                ViewBag.MsjPantallaArticuloAgregado = "No se ha podido registrar el Artículo";
                return RedirectToAction("shop", "Store");
            }
        }


   

        
         [HttpGet]
         public ActionResult BorrarArticulo(long q)
         {
             var resp = modeloArticulo.BorrarArticulo(q);

             return RedirectToAction("BorrarArticulo", "Store");
         }

/* 
          esto lo hace el controlador de shop cuando se carga la view.
         [HttpGet]
         public ActionResult ConsultarArticulosYviewArticulos()
         {
             var articulosLista = modeloArticulo.ConsultaCursos();

             return View("../Views/Store/Shop", articulosLista);
         }

         */





    }
}