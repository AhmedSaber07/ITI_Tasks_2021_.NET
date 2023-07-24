using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskMVC_D2.Models;
namespace TaskMVC_D2.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeEntities _Context = new EmployeeEntities();
        // GET: Employee
        public ActionResult Index(int DepartID=1)
        {
            var Emps = _Context.Emps.Where(e => e.DepartID == DepartID).ToList();
            SelectList departments = new SelectList(_Context.Departs, "DepartID", "DepartName") ;
            ViewBag.DepartID = departments;
            return View(Emps);
        }
        public ActionResult Details(int id)
        {
            return View(_Context.Emps.Find(id));
        }
        [HttpPost]
        public ActionResult Filter(int DepartID)
        {
            return RedirectToAction("Index",new {DepartID = DepartID });
        }
        public ActionResult Create()
        {
            SelectList departments = new SelectList(_Context.Departs, "DepartID", "DepartName");
            ViewBag.DepartID = departments; 
            return View();
        }
        [HttpPost]
        public ActionResult Create(Emp emp)
        {
            _Context.Emps.Add(emp);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var emp = _Context.Emps.Find(id);
            SelectList departments = new SelectList(_Context.Departs, "DepartID", "DepartName",emp.DepartID);
            ViewBag.DepartID = departments;
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(int id , Emp emp)
        {
            var editEmp = _Context.Emps.Find(id);
            editEmp.EmployeeName = emp.EmployeeName;
            editEmp.DepartID = emp.DepartID;
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            return View(_Context.Emps.Find(id));
        }
        [HttpPost]
        public ActionResult Delete(int id, Emp emp)
        {
            _Context.Emps.Remove(_Context.Emps.Find(id));
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}