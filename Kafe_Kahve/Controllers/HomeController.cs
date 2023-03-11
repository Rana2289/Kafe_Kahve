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
            return View();
        }
        [Route("urunler")]
        public ActionResult urunler()
        {
            return View();
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