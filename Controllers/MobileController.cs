using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebMobile.DAL;
using System.Web.Mvc;

namespace WebMobile.Controllers
{
    public class MobileController : Controller
    {
        private CredenciallDbContext db = new CredenciallDbContext();
        // GET: Mobile
        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }
    }
}