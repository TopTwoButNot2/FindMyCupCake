using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FindMyCupCake.Models;

namespace FindMyCupCake.Controllers
{
    public class MyCupCakesController : Controller
    {
        private FindCupCakeContext db = new FindCupCakeContext();

        // GET: MyCupCakes
        public ActionResult Index()
        {
            return View(db.MyCupCakes.ToList());
        }

        // GET: MyCupCakes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyCupCake myCupCake = db.MyCupCakes.Find(id);
            if (myCupCake == null)
            {
                return HttpNotFound();
            }
            return View(myCupCake);
        }

        // GET: MyCupCakes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyCupCakes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MyCupCakeId,travelto,travelfrom,TypeOfTransport,PricePerKm,PricePerhr,Distance,Duration")] MyCupCake myCupCake)
        {
            if (ModelState.IsValid)
            {

                db.MyCupCakes.Add(myCupCake);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(myCupCake);
        }

        // GET: MyCupCakes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyCupCake myCupCake = db.MyCupCakes.Find(id);
            if (myCupCake == null)
            {
                return HttpNotFound();
            }
            return View(myCupCake);
        }

        // POST: MyCupCakes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MyCupCakeId,travelto,travelfrom,TypeOfTransport,PricePerKm,PricePerhr,Distance,Duration")] MyCupCake myCupCake)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myCupCake).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myCupCake);
        }

        // GET: MyCupCakes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyCupCake myCupCake = db.MyCupCakes.Find(id);
            if (myCupCake == null)
            {
                return HttpNotFound();
            }
            return View(myCupCake);
        }

        // POST: MyCupCakes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyCupCake myCupCake = db.MyCupCakes.Find(id);
            db.MyCupCakes.Remove(myCupCake);
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
