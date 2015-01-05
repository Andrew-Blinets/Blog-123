using blog3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blog3.Controllers
{
    public class CommentController : Controller
    {
        //
        // GET: /Cimment/

        public ActionResult Recent()
        {
            var model = new RecentDateModel();
            return View(model);
        }

    }
}
