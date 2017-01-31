using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AdminLTEMVC.Models;

namespace AdminLTEMVC.Controllers
{
    public class RunController : Controller
    {
        public ActionResult Runner()
        {
            List<SetPasswordViewModel> model = new List<SetPasswordViewModel>();
            return View(model);
        }
    }
}
