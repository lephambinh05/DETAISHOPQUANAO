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
        private DBSportStoreEntities database = new DBSportStoreEntities();
        public ActionResult Test()
        {

            return View();
        }
        public ActionResult Trangchu()
        {

            return View();
        }
        public ActionResult Dangky()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Dangky(Customer cus)
        {
            if (ModelState.IsValid)
            {
                var check_username = database.Customers.Where(s => s.NameCus == cus.NameCus && s.PassCus == cus.PassCus).FirstOrDefault();
                if (check_username == null) //chua co user  
                {
                    database.Configuration.ValidateOnSaveEnabled = false;
                    database.Customers.Add(cus);
                    database.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.ErrorRegister = "This username is exixst";
                    return View();
                }
            }
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