using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSayfalama.Controllers
{
    public class MVCNedirController : Controller
    {
        // GET: MVCNedir
        public ActionResult Nedir()
        {
            return View();
        }
        public ActionResult Faydalari()
        {
            return View();
        }
        public ActionResult OrnekSiteler()
        {
            return View();
        }
    }
}