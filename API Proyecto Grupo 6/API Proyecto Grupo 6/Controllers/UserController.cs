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
    public class UserController : ApiController
    {

        [HttpPost]
        [Route("api/RegistrarUsuario")]
        public int RegistrarUsuario(UserEnt entidad)
        {
            using (var bd = new ProyectoPrograEntities())
            {
                User tabla = new User();
                tabla.Name = entidad.Name;
                tabla.Password = entidad.Password;
                tabla.Email = entidad.Email;
                tabla.Estado = entidad.Estado;
                tabla.IdRol = entidad.IdRol;

                bd.User.Add(tabla);
                return bd.SaveChanges();
            }

        }


        [HttpPost]
        [Route("api/IniciarSesion")]
        public UserEnt IniciarSesion(UserEnt entidad)
        {
            using (var bd = new ProyectoPrograEntities())
            {
                var datos = (from x in bd.User
                             where x.Email == entidad.Email
                                && x.Password == entidad.Password
                             select x).FirstOrDefault();


                if (datos != null)
                {
                    /*
                    if (datos.ClaveTemporal.Value && datos.Caducidad < DateTime.Now)
                    {
                        return null;
                    }
                    */
                    UserEnt resp = new UserEnt();
                    resp.UserID = datos.UserID;
                    resp.Name = datos.Name;
                    resp.Email = datos.Email;
                    resp.Estado = datos.Estado;
                    resp.IdRol = datos.IdRol;
                    return resp;
                }
                else
                {
                    return null;
                }
            }
        }

        [HttpPost]
        [Route("api/RecuperarClave")]
        [AllowAnonymous]
        public bool RecuperarClave(UserEnt entidad)
        {
            UtilitariosModel util = new UtilitariosModel();

            using (var bd = new ProyectoPrograEntities())
            {
                var datos = (from x in bd.User
                             where x.Email == entidad.Email
                                           && x.Estado == true
                             select x).FirstOrDefault();

                if (datos != null)
                {
                    string pass = util.CreatePassword();
                    string mensaje = "Estimado(a): " + datos.Name + ". Se ha generado la siguiente contraseña temporal: " + pass + " valida por los siguientes 15 minutos";
                    util.SendEmail(datos.Email, "Recuperar Contraseña", mensaje);

                    //Update de LiQ
                    datos.Password = pass;
                    datos.ClaveTemporal = true;
                    datos.Caducidad = DateTime.Now.AddMinutes(15);
                    bd.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}

