using Microsoft.AspNetCore.Mvc;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {

        void mesajlar()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "Merhaba proje çok iyi duruyor";
            ViewBag.m3 = "Selamlar, hi, hello, bonjour";
        }

        public IActionResult Index()
        {
            mesajlar();
            return View();
        }

        public IActionResult Urunler()
        {
            mesajlar();
            return View();
        }
    }
}
