using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        private DBSportStoreEntities database = new DBSportStoreEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new Category());
        }

        [HttpPost]
        public ActionResult Create(Category cate)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    database.Categories.Add(cate);
                    database.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(cate);
            }
            catch
            {
                return Content("ERROR!!! CAN NOT CREATE NEW");
            }
        }
    }
}