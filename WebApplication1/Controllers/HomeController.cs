using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private DBFashionStoreEntities database = new DBFashionStoreEntities();
        public ActionResult Test()
        {

            return View();
        }
        public ActionResult Trangchu()
        {

            return View();
        }
        
        public ActionResult Chitietsanpham()
        {
            return View();
        }
        public ActionResult DestopComputer()
        {

            return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }
   
    }
}