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
    public class CMSController : Controller
    {
        private CredenciallDbContext db = new CredenciallDbContext();

        // GET: CMS
        public ActionResult Index()
        {
            return View(db.CMSs.ToList());
        }

        // GET: CMS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CMS cMS = db.CMSs.Find(id);
            if (cMS == null)
            {
                return HttpNotFound();
            }
            return View(cMS);
        }

        // GET: CMS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CMS/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Slogan,SloganAppend,BigPicText,FirstFeature,SecondFeature,ThirdFeature,FirstTeamMemberText,FirstTeamMemberName,FirstTeamMemberRa,SecondTeamMemberText,SecondTeamMemberName,SecondTeamMemberRa")] CMS cMS)
        {
            if (ModelState.IsValid)
            {
                db.CMSs.Add(cMS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cMS);
        }

        // GET: CMS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CMS cMS = db.CMSs.Find(id);
            if (cMS == null)
            {
                return HttpNotFound();
            }
            return View(cMS);
        }

        // POST: CMS/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Slogan,SloganAppend,BigPicText,FirstFeature,SecondFeature,ThirdFeature,FirstTeamMemberText,FirstTeamMemberName,FirstTeamMemberRa,SecondTeamMemberText,SecondTeamMemberName,SecondTeamMemberRa")] CMS cMS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cMS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cMS);
        }

        // GET: CMS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CMS cMS = db.CMSs.Find(id);
            if (cMS == null)
            {
                return HttpNotFound();
            }
            return View(cMS);
        }

        // POST: CMS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CMS cMS = db.CMSs.Find(id);
            db.CMSs.Remove(cMS);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
