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
       
    }
}