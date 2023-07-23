using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Grupo_6.Entities
{
    public class UserEnt
    {
        public long UserID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Boolean Estado { get; set; }
        public int IdRol { get; set; }
        public string newPassword { get; set; }
        public string newPasswordConfirmed { get; set; }



    }
}