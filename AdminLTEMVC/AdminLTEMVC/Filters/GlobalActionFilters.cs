using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Navigation;

namespace AdminLTEMVC.Filters
{
 
    public class GlobalActionFilters : ActionFilterAttribute
    {

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //filterContext.Controller.ViewBag.IsAuthenticated = MembershipService.IsAuthenticated;
            //filterContext.Controller.ViewBag.IsAdmin = MembershipService.IsAdmin;

            //var userProfile = MembershipService.GetCurrentUserProfile();
            //if (userProfile != null)
            //{
            //    filterContext.Controller.ViewBag.Avatar = userProfile.Picture;
            //}

            //This is the clobal Configuration to be loaded to enviroment 
            string path = HttpContext.Current.Server.MapPath("/Menues/SiteMap.xml");
            filterContext.Controller.ViewBag.SoftwareName = "Info-IHRM";
            filterContext.Controller.ViewBag.CompanyName = "Infocraft Limited";
            filterContext.Controller.ViewBag.MenuList = MenuManager.LoadMenu(path);
            
        }

    }
}