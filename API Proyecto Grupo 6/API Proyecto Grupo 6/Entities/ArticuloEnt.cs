using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Proyecto_Grupo_6.Entities
{
    public class ArticuloEnt
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}