using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OfflineWebapi.Context;

namespace OfflineWebapi.Controllers
{

    public class HomeController : Controller
    {
        private InventoryContext db = new InventoryContext();

        public ActionResult Index()
        {
            var foo = db.Items.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}