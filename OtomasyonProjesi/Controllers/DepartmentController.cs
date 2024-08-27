using OtomasyonProjesi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace OtomasyonProjesi.Controllers
{
    public class DepartmentController : Controller
    {

        TicariContext ticariContext = new TicariContext();

        // GET: Department
        public ActionResult Index()
        {
            var data = ticariContext.Departments.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult DepartmentAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DepartmentAdd(Department d) 
        {
            ticariContext.Departments.Add(d);
            ticariContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmentDelete(int id)
        {
            var delete = ticariContext.Departments.Find(id);
            ticariContext.Departments.Remove(delete);
            ticariContext.SaveChanges();
            return RedirectToAction("Index");   
        }

        // get items 
        public ActionResult GetByDepartmentID(int id)
        {
            var update = ticariContext.Departments.Find(id);

            return View("GetByDepartmentID", update);
        }
     
        public ActionResult DepartmentUpdate(Department d) 
        {
            var updateDepartment = ticariContext.Departments.Find(d.DepartmentID);
            updateDepartment.DepartmentName = d.DepartmentName;           
            ticariContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}