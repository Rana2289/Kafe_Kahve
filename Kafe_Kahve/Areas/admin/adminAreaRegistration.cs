﻿using System.Web.Mvc;

namespace Kafe_Kahve.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { controller="Login", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}