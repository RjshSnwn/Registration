using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration1.Models;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
        RegMVCEntities db = new RegMVCEntities();
        public ActionResult Index()
        {
            var list = db.tblDistricts.ToList();
            ViewBag.data = new SelectList(list, "DistrictName", "DistrictName");

            var list1 = db.tblTaluka1.ToList();
            ViewBag.data1 = new SelectList(list1, "TalukaName", "TalukaName");

            var list2 = db.tblVillages.ToList();
            ViewBag.data2 = new SelectList(list2, "VillageName", "VillageName");
            return View();
        }

        [HttpPost]
        public ActionResult Index(tblRegistration obj)

        {
            if (ModelState.IsValid)
            {
                db.tblRegistrations.Add(obj);
                db.SaveChanges();
            }

            var list = db.tblDistricts.ToList();
            ViewBag.data = new SelectList(list, "DistrictName", "DistrictName");

            var list1 = db.tblTaluka1.ToList();
            ViewBag.data1 = new SelectList(list1, "TalukaName", "TalukaName");


            var list2 = db.tblVillages.ToList();
            ViewBag.data2 = new SelectList(list2, "VillageName", "VillageName");
            return View(obj);
        }
    }
}