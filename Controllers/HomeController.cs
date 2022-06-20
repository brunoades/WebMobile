using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMobile.DAL;
using WebMobile.Models;

namespace WebMobile.Controllers
{
    public class HomeController : Controller
    {
        private CredenciallDbContext db = new CredenciallDbContext();
        public ActionResult Index()
        {
            //return View(db.CMSs.ToList());
            return View(db.CMSs.FirstOrDefault());
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