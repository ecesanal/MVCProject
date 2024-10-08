using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSayfalama.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult Anasayfa()
        {
            return View();
        }public ActionResult Hakkimizda()
        {
            return View();
        }public ActionResult BizKimiz()
        {
            return View();
        }public ActionResult Vizyonumuz()
        {
            return View();
        }
    }
}