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
    public class UserController : Controller
    {

        UserModel modeloUsuario = new UserModel();


        [HttpPost]
        public ActionResult RegistrarUsuario(UserEnt entidad)
        {
            entidad.IdRol = 2;
            entidad.Estado = true;

            var resp = modeloUsuario.RegistrarUsuario(entidad);

            if (resp > 0)
            {
                ViewBag.MsjPantalla = "Usuario " + entidad.Name + " registrado correctamente" ;
                return RedirectToAction("index", "Store");
            }

            else
            {
                ViewBag.MsjPantalla = "No se ha podido registrar su información";
                return RedirectToAction("index", "Store");
            }
        }

        [HttpPost]
        public ActionResult IniciarSesion(UserEnt entidad)
        {
            var resp = modeloUsuario.IniciarSesion(entidad);

            if (resp != null)
            {
                Session["IdUsuario"] = resp.UserID;
                Session["CorreoUsuario"] = resp.Email;
                Session["NombreUsuario"] = resp.Name;
                Session["idRolUsuario"] = resp.IdRol;
                if (resp.IdRol == 1)
                {
                    Session["NombreRolUsuario"] = "Administrador";
                } else if(resp.IdRol == 2)
                {
                    Session["NombreRolUsuario"] = "Cliente";
                }
                else
                {
                    Session["NombreRolUsuario"] = "?"; // esto no deberia suceder.
                }

                return RedirectToAction("index", "Store");
            }
            else
            {
                ViewBag.MsjPantalla = "No se ha podido validar su información";
               
                return RedirectToAction("index", "Store");
            }
        }

        


        [HttpGet]
        public ActionResult CerrarSesion()
        {
            Session.Clear();
            return RedirectToAction("index", "Store");
        }




    }
}