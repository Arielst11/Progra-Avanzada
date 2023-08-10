using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Proyecto_Grupo_6.Entities
{
    public class TiendaEnt
    {

        public int ProductId { get; set; }
        public String ProductName { get; set; }

        public String Description { get; set; }

        public int Price { get; set; }
    }
}