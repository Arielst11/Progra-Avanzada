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




    }
}
