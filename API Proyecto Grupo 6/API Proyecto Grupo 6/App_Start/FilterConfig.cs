﻿using System.Web;
using System.Web.Mvc;

namespace API_Proyecto_Grupo_6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
