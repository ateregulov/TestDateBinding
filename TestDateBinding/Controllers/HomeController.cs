using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestDateBinding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(DateTime? date )
        {
            return View(date ?? DateTime.Parse("01/01/0001"));
        }

        [HttpPost]
        public ActionResult Index(DateTime? date, int? id)
        {
            return View(date ?? DateTime.Parse("01/01/0001"));
        }

        
    }
}
