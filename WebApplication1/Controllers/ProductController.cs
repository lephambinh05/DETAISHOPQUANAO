using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        DBFashionStoreEntities database = new DBFashionStoreEntities();

        // GET: Product
        public ActionResult Index()
        {
            return View(database.Products.ToList());
        }
        public ActionResult Creat()
        {
            Product pro = new Product();
            return View(pro);
        }
        
    }
}