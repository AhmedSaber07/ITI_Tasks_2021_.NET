using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskMVC_D4.Areas.Admin.Controllers
{
    [HandleError(View ="AdminErrorPage")]
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            string s = null;
            ViewBag.t = s.Length;
            return View();
        }
    }
}