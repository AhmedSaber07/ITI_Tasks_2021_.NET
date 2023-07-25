using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskMVC_D4.Areas.Finance.Controllers
{
    [HandleError(View = "FinanceErrorPage")]
    public class FinanceController : Controller
    {
        // GET: Finance/Finacne
        public ActionResult Index()
        {
            int x = Convert.ToInt32("Hello World!");
            return View();
        }
    }
}