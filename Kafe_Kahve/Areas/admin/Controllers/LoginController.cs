using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kafe_Kahve.Models;
using System.Web.Security;
using Kafe_Kahve.contect.admin;

namespace Kafe_Kahve.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: admin/Login
        public ActionResult Index()
        {
            return View();
        }

        // güvenlik için
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alogin(kullanicilar kullaniciFormu)
        {
            if (!ModelState.IsValid)
            {
                return View("index" ,kullaniciFormu);
            }

            string yeniSifre = Sifrele.MD5Olustur(kullaniciFormu.sifre);
            using( kafe_kahveEntities db= new kafe_kahveEntities())
            {
                var kullaniciVarmi = db.kullanicilar.FirstOrDefault(
                    x=>x.k_adi==kullaniciFormu.k_adi && x.sifre==yeniSifre);

                if (kullaniciVarmi != null)
                {
                    FormsAuthentication.SetAuthCookie(kullaniciVarmi.k_adi, kullaniciFormu.beniHatirla);
                    return RedirectToAction("/index", "urunler");
                }
                ViewBag.Hata = "kullanıcı adı veya şifre hatalı";
                return View("index");
            }
            
        }
    }
}