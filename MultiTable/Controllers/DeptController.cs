using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiTable.Models;

namespace MultiTable.Controllers
{
    public class DeptController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public ActionResult Index()
        {
            var res = from k in db.Depts
                      select k;
            return View(res.ToList());
        }

        public ActionResult Details(int id)
        {
            var res = from k in db.Depts
                      where k.DNo == id
                      select k;
            Dept t = (Dept)res.FirstOrDefault();
            return View(t);
        }
        public ActionResult Create()
        {
            Dept d = new Dept();
            return View(d);
        }
        [HttpPost]
        public ActionResult Create(Dept d)
        {
            try
            {
                db.Depts.InsertOnSubmit(d);
                db.SubmitChanges();
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var res = from k in db.Depts
                      where k.DNo == id
                      select k;
            Dept t = (Dept)res.FirstOrDefault();
            return View(t);
        }
        [HttpPost]
        public ActionResult Edit(int id, Dept t)
        {
            try
            {
                var res = from k in db.Depts
                          where k.DNo == id
                          select k;
                Dept b = (Dept)res.FirstOrDefault();
                b.DName = t.DName;
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            var res = from k in db.Depts
                      where k.DNo == id
                      select k;
            Dept t = (Dept)res.FirstOrDefault();
            return View(t);
        }
        [HttpPost]
        public ActionResult Delete(int id, Dept t)
        {
            try
            {
                var res = from k in db.Depts
                          where k.DNo == id
                          select k;
                Dept d = (Dept)res.FirstOrDefault();
                db.Depts.DeleteOnSubmit(d);
                db.SubmitChanges();
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }
    }
}