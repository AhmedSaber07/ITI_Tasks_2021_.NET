using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskMVC_D4.Areas.HR.Controllers
{
    [HandleError(View ="HRErrorPage")]
    public class HRController : Controller
    {
        // GET: HR/HR
        public ActionResult Index()
        {
            int x = 6,y=0,z;
            z = x / y;
            return View();
        }
    }
}