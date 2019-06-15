using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ACMECarInsuranceMVCApp;

namespace ACMECarInsuranceMVCApp.Controllers
{
    public class InsuranceQuoteController : Controller
    {
        private ACMECarInsuranceEntities db = new ACMECarInsuranceEntities();

        // GET: InsuranceQuote
        public ActionResult Index()
        {
            return View(db.InsuranceCustomers.ToList());
        }

        // GET: InsuranceQuote/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InsuranceCustomer insuranceCustomer = db.InsuranceCustomers.Find(id);
            if (insuranceCustomer == null)
            {
                return HttpNotFound();
            }
            return View(insuranceCustomer);
        }

        // GET: InsuranceQuote/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InsuranceQuote/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,BirthDate,CurrentAge,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CarInsuranceType")] InsuranceCustomer insuranceCustomer)
        {
            if (ModelState.IsValid)
            {
                db.InsuranceCustomers.Add(insuranceCustomer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuranceCustomer);
        }

        // GET: InsuranceQuote/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InsuranceCustomer insuranceCustomer = db.InsuranceCustomers.Find(id);
            if (insuranceCustomer == null)
            {
                return HttpNotFound();
            }
            return View(insuranceCustomer);
        }

        // POST: InsuranceQuote/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,BirthDate,CurrentAge,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CarInsuranceType")] InsuranceCustomer insuranceCustomer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuranceCustomer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuranceCustomer);
        }

        // GET: InsuranceQuote/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InsuranceCustomer insuranceCustomer = db.InsuranceCustomers.Find(id);
            if (insuranceCustomer == null)
            {
                return HttpNotFound();
            }
            return View(insuranceCustomer);
        }

        // POST: InsuranceQuote/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InsuranceCustomer insuranceCustomer = db.InsuranceCustomers.Find(id);
            db.InsuranceCustomers.Remove(insuranceCustomer);
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
