﻿using System.Web;
using System.Web.Mvc;

namespace _DuongCongHau_5951071023_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
