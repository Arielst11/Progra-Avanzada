using Proyecto_Grupo_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Grupo_6.Controllers
{
    public class ProductoController : Controller
    {

        ProductoModel model = new ProductoModel();
        // GET: Producto
        public ActionResult Shop()
        {
            var resp = model.ConsultarCursos();

            return View(resp);
        }
    }
}