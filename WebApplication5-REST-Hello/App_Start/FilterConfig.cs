﻿using System.Web;
using System.Web.Mvc;

namespace WebApplication5_REST_Hello
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
