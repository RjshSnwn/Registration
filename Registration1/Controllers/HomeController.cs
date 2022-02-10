using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration1.Models;
using Google.Authenticator;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var list = new List<string>() { "Pune", "Mumbai", "Nagpur", "Dhule", "Nashik", "Jalgaon" };
            var list1 = new List<string>() { "Khed", "Kurla", "Kamptee", "Sakri", "Peth", "Bhusawal" };
            var list2 = new List<string>() { "Kheshivapur", "Jainpur", "Ajani", "Chorwad", "Abheti", "Fekari" };
            ViewBag.list = list;
            ViewBag.list1 = list1;
            ViewBag.list2 = list2;
            return View();
        }

        [HttpPost]
        public ActionResult Index(tblRegistration obj)

        {
            if (ModelState.IsValid)
            {
                RegMVCEntities db = new RegMVCEntities();
                db.tblRegistrations.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}