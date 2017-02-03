using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdminLTEMVC.DBContexts;
using Domain.Navigation;

namespace AdminLTEMVC.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        private MainDbContext db = new MainDbContext();
        // GET: Admin/Home
        public ActionResult Index()
        {
            List<Menu> listofmenu = db.MenuIns.ToList();
            foreach (var item in listofmenu)
            {
                List<MenuItems> mnuitems = db.MenuItemsIns.Where(m=>m.ParantMenu.Id == item.Id).ToList();
                item.MenuItemList = mnuitems;
            }
            return View(listofmenu);
        }
    }
}