using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSayfalama.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        public string Sayfa1()
        {
            return "Sayfa 1";
        }
        public JsonResult Sayfa2()
        {
            return Json(new { anahtar = "deger" },JsonRequestBehavior.AllowGet);
        }
        public string Parametre(string q)
        {
            return q;
        }
        public int Parametre2(int q)
        {
            return q;
        }

    }
}