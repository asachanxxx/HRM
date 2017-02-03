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
using Domain.System;

namespace AdminLTEMVC.Controllers
{
    public class MenusController : Controller
    {
        private MainDbContext db = new MainDbContext();

        // GET: Menus
        public ActionResult Index()
        {
            List<Menu> passingMenues = db.MenuIns.OrderByDescending(m => m.Name).ToList();
            AutoGenerateInfo info = db.AutoGenerateInfoIns.First();
            ViewBag.AutoInfo = info;
            return View(passingMenues);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Menu menu)
        {
            if (ModelState.IsValid)
            {
                db.MenuIns.Add(menu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menu);
        
        }

        //public ActionResult AddMenuItems(int id) {

        //    return View();
        //}

        public ActionResult AddMenuItems(int Parantid)
        {
            Menu mnu = db.MenuIns.SingleOrDefault(m => m.Id == Parantid);
            return View(new MenuItems { ParantMenu = mnu});

        }

        // POST: MenuItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMenuItems([Bind(Include = "Id,Name,Action,Controller,URL")] MenuItems menuItems,int parantid)
        {

            if (ModelState.IsValid)
            {
                Menu mnu = db.MenuIns.SingleOrDefault(m => m.Id == parantid);
                menuItems.ParantMenu = mnu;
                db.MenuItemsIns.Add(menuItems);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menuItems);
        }

    }
}