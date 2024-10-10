using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSayfalama.Controllers
{
    public class MatematikController : Controller
    {
        // GET: Matematik
        public string Topla(int? sayi1 , int? sayi2)
        {
            if (sayi1.HasValue && sayi2 != null)
                return (sayi1.Value + sayi2.Value).ToString();
            else
                return "İki sayı giriniz!";
        }
        public int TEksekareCiftseKup(int sayi)
        {
            if (sayi % 2 == 0)
                return sayi * sayi * sayi;
            else
                return sayi * sayi;
        }
    }
}