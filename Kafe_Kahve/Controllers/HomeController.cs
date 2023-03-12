using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kafe_Kahve.Models;

namespace Kafe_Kahve.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [Route("hakkimizda")]
        public ActionResult hakkimizda()
        {
            using(kafe_kahveEntities db=new kafe_kahveEntities())
            {
                var model = db.hakkimizda.Find(1);
                return View(model);
            }
            
        }
        [Route("urunler")]
        public ActionResult urunler()
        {
            using (kafe_kahveEntities db = new kafe_kahveEntities())
            {
                var model = db.urunler.Where(x=>x.aktif==1).OrderBy(x=>x.sira).ToList();
                return View(model);
            }
        }

        [Route("urun/{id}")]

        public ActionResult urunDetay( int id)
        {
            using (kafe_kahveEntities db = new kafe_kahveEntities())
            {
                var model = db.urunler.Where(x => x.aktif==1 && x.id == id).FirstOrDefault();
                if (model == null)
                {
                    return HttpNotFound();
                }
                return View(model);
            }
        }



        [Route("magaza")]
        public ActionResult magaza()
        {
            return View();
        }
        [Route("iletisim")]
        public ActionResult iletisim()
        {
            return View();
        }
    }
}