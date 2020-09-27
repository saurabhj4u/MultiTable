using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiTable.Models;

namespace MultiTable.Controllers
{
    public class EmpController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        
        public ActionResult Index()
        {
            var res = from d in db.Depts
                      from e in db.Emps
                      where d.DNo == e.DNo
                      select new
                      {
                         d.DName,
                         e.ECode,
                         e.EName,
                         e.ESal,
                         e.DNo
                      };
            List<DeptEmpModel> mylist = new List<DeptEmpModel>();
            foreach (var r in res)
            {
                DeptEmpModel dm = new DeptEmpModel();
                dm.ECode = r.ECode;
                dm.EName = r.EName;
                dm.ESal = (int)r.ESal;
                dm.DNo = (int)r.DNo;
                dm.DName = r.DName;
                mylist.Add(dm);
            }
            return View(mylist);
        }
        public ActionResult Details(int id)
        {
            var res = from d in db.Depts
                      from e in db.Emps
                      where d.DNo == e.DNo && e.ECode == id
                      select new
                      {
                          d.DName,
                          e.ECode,
                          e.EName,
                          e.ESal,
                          e.DNo
                      };
            DeptEmpModel dm = new DeptEmpModel();
            foreach(var r in res)
            {
                dm.ECode = r.ECode;
                dm.EName = r.EName;
                dm.ESal = (int)r.ESal;
                dm.DNo = (int)r.DNo;
                dm.DName = r.DName;
            }
            return View(dm);
        }
        public ActionResult Create()
        {
            DeptEmpModel dm = new DeptEmpModel();
            var res = from k in db.Emps
                      select k;
            ViewData["DNo"] = new SelectList(res, "DNo","DName");
            return View(dm);
        }
        [HttpPost]
        public ActionResult Create(DeptEmpModel dm)
        {
            try
            {
                Emp t = new Emp();
                t.ECode = dm.ECode;
                t.EName = dm.EName;
                t.ESal = dm.ESal;
                t.DNo = dm.DNo;
                db.Emps.InsertOnSubmit(t);
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
            var res = from d in db.Depts
                      from e in db.Emps
                      where d.DNo == e.DNo && e.ECode == id
                      select new
                      {
                          d.DName,
                          e.ECode,
                          e.EName,
                          e.ESal,
                          e.DNo
                      };
            DeptEmpModel dm = new DeptEmpModel();
            foreach (var r in res)
            {
                dm.ECode = r.ECode;
                dm.EName = r.EName;
                dm.ESal = (int)r.ESal;
                dm.DNo = (int)r.DNo;
                dm.DName = r.DName;
            }
            return View(dm);
        }
        [HttpPost]
        public ActionResult Edit(int id, DeptEmpModel dm)
        {
            try
            {
                var res = from k in db.Emps
                          where k.ECode == id
                          select k;
                Emp t = (Emp)res.FirstOrDefault();
                t.EName = dm.EName;
                t.ESal = dm.ESal;
                t.DNo = dm.DNo;
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete (int id)
        {
            var res = from k in db.Emps
                      where k.ECode == id
                      select k;
            Emp t = (Emp)res.FirstOrDefault();
            return View(t);
        }

        [HttpPost]

        public ActionResult Delete(int id, Emp t)
        {
            try
            {
                var res = from e in db.Emps
                          where e.ECode == id
                          select e;
                Emp b = (Emp)res.FirstOrDefault();
                db.Emps.DeleteOnSubmit(b);
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