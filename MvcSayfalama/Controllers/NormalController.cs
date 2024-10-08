using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSayfalama.Controllers
{
    public class NormalController : Controller
    {
        // GET: Normal
        public ActionResult RenkliSayfa()
        {
            return View();
        }
        public ActionResult Anasayfa()
        {
            return View();
        }
        public ActionResult Alert()
        {
            return View();
        }
    }
}