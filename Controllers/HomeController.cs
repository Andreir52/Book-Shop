using Proiect_DAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proiect_DAW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UnitOfWork u = new UnitOfWork();
            //var carte = new Table();
            //carte.nume = "da";
            //u.entities.Table.Add(carte);
            //u.SaveChanges();
            
            return View(u);
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