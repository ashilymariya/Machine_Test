using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Machine_Test.Models;
using Microsoft.Win32;

namespace Machine_Test.Controllers
{

    public class EmployeeController : Controller
    {
        Model1 db = new Model1();
        // GET: Employee
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        [HttpGet]
        public ActionResult Details(int id)
        {

            Employee emp = db.Employees.Find(id);
            if (emp != null)
            {
                return View(emp);
            }
            else
            {
                return HttpNotFound("Employee Not found !!!");
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }


        [HttpGet]
        public ActionResult Edit(int id) 
        {
            Employee emp = db.Employees.Find(id);
            if (emp != null)
            {
                return View(emp);
            }
            else
            {
                return HttpNotFound("Employee Not found !!!");
            }
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            if(ModelState.IsValid) 
            {
                db.Entry(emp).State=EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);

        }
        [HttpGet]

        public ActionResult Delete(int id)
        {
            Employee employee = db.Employees.Find(id);
            return View(employee);
        }
        [HttpPost, ActionName("Delete")]

        public ActionResult DeleteConfirm(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}