﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAppMultiUserMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults: new { controller = "SelectAllUsers", action = "DisplayAll_SP_Load", id = UrlParameter.Optional }
                //defaults: new { controller = "UserInsert", action = "User_Pageload", id = UrlParameter.Optional }
                defaults: new { controller = "SelectUser", action = "User_Load", id = UrlParameter.Optional }
            );
        }
    }
}
