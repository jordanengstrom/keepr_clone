using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace keepr.web.Controllers
{
    public class KeepsController : Controller
    {
        // GET: Keeps
        public ActionResult Index()
        {

            return View();
        }
    }
}