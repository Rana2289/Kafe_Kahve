using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kafe_Kahve.Areas.admin.Controllers
{
    [Authorize]
    public class hakkimizdaController : Controller
    {
        // GET: admin/hakkimizda
        public ActionResult Index()
        {
            return View();
        }
    }
}