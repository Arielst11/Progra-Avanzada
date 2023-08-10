using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API_Proyecto_Grupo_6.Entities
{
    public class ProductosEnt
    {

        public int ProductId { get; set; }
        public string ProductName { get; set;}

        public string Description { get; set;}

        public int Price { get; set;}
    }
}