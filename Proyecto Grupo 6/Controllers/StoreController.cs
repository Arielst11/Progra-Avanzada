using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Grupo_6.Controllers
{
    public class StoreController : Controller
    {


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

        public ActionResult shop()
        {
            ViewBag.Message = "Your contact page.";

            return View("Shop");
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

        public ActionResult ViewBlog()
        {

            return View("ViewBlog");
        }

    }
}