using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03122023_MVCFormElementleri.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        string kAd = "admin", parola = "0000";
        public ActionResult Index()
        {
            /* Kullanıcı login ekranı oluşturalım.Kullanıcının girmiş olduğu bilgiler yukarıda tanımlı olan bilgiler ile eşleşiyor ise "Kulanıcı Giriş Başarılı" değilse "Kullanıcı bilgileri hatalçı" mesajı döndürelim */
            return View();
        }
        [HttpPost]
        public ActionResult Index(string kullaniciAdi , string sifre)
        {
            if (kAd==kullaniciAdi && parola == sifre)
            {
                ViewBag.Mesaj = "<div class='success'> Kullanıcı Girişi Başarılı</div>";
            }
            else
            {
                ViewBag.Mesaj= "<div class='error'> Kullanıcı Girişi Hatalı</div>";
            }

            return View();
        }
    }
}