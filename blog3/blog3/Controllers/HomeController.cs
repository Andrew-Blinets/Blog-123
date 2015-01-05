using blog3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blog3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new ArticleModel();
            return View(model);
        }
        public ActionResult Index1()
        {
            var model = new ArticleModel();
            return View(model);
        }

    }
}
