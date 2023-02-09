using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Örnekler;

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

        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();

            sehirler.Id = 1;
            sehirler.Ulke = "Ukrayna";
            sehirler.Sehir = "Kiev";
            sehirler.Nufus = 1000000;
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Sarı";

            ViewBag.v1 = sehirler.Id;
            ViewBag.v2 = sehirler.Ulke;
            ViewBag.v3 = sehirler.Sehir;
            ViewBag.v4 = sehirler.Nufus;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.v7 = sehirler.Renk3;


            sehirler.Id = 2;
            sehirler.Ulke = "Makedeonya";
            sehirler.Sehir = "Üsküp";
            sehirler.Nufus = 5000000;
            sehirler.Renk1 = "Sarı";
            sehirler.Renk2 = "Kırmızı";

            ViewBag.z1 = sehirler.Id;
            ViewBag.z2 = sehirler.Ulke;
            ViewBag.z3 = sehirler.Sehir;
            ViewBag.z4 = sehirler.Nufus;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;
            ViewBag.z7 = sehirler.Renk3;

            return View();
        }
    }
}
