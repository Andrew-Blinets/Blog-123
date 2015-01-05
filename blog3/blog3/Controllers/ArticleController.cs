using blog3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blog3.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/

        public ActionResult Recent()
        {
            var model = new RecentDateModel();
            return View(model);
        }

        public ContentResult Index()
        {
            return new ContentResult() { Content = "Hell world" };
        }
        public ContentResult GetByUrl(string seoUrl)
        {
            return new ContentResult() { Content = "#"+seoUrl+"#"};
        }
    }
}
