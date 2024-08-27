using OtomasyonProjesi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtomasyonProjesi.Controllers
{
    public class CategoryController : Controller
    {

        TicariContext ticariContext = new TicariContext();

        // GET: Category
        public ActionResult Index()
        {
            var data = ticariContext.Categories.ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CategoryAdd(Category c)
        {
            ticariContext.Categories.Add(c);   
            ticariContext.SaveChanges();
            return RedirectToAction("Index");
        }
     
        public ActionResult CategoryDelete(int id) 
        {
            var delete = ticariContext.Categories.Find(id);
            ticariContext.Categories.Remove(delete);
            ticariContext.SaveChanges();
            return RedirectToAction("Index");
        }
            
        //getirdik
        public ActionResult GetByCategoryID(int id) 
        {
            var update = ticariContext.Categories.Find(
                id);
            return View("GetByCategoryID", update);
        }

        public ActionResult CategoryUpdate(Category c) 
        {
            var updateCategory = ticariContext.Categories.Find(c.CategoryID);
            updateCategory.CategoryName = c.CategoryName;
            ticariContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}