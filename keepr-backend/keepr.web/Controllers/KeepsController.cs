using Keepr.Data.Models;
using Keepr.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace keepr.web.Controllers
{
    public class KeepsController : Controller
    {
        private readonly IKeepData db;

        public KeepsController(IKeepData db)
        {
            this.db = db;
        }
        // GET: Keeps
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Keep keep)
        {
            if(ModelState.IsValid)
            {
                db.Add(keep);
                //return RedirectToAction("Details", new { id = keep.Id})
            }
            return View();
        }
    }
}