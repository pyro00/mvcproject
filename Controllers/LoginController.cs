using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using geos_mvc.Models;

namespace geos_mvc.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorise(personel personel)
        {
            using (geosEntities db = new geosEntities())
            {
                var userDetail = db.personel.Where(x => x.KullanıcıAdı == personel.KullanıcıAdı && x.Sifre == personel.Sifre).FirstOrDefault();
                if (userDetail == null)
                {
                    personel.LoginErrorMsg = "Geçersiz Kullanıcı Adı veya Şifre";
                    return View("Index", personel); 
                }
                else
                {
                    Session["pers_id"] = personel.pers_id;
                    return RedirectToAction("Index", "personel");
                }
            }
            
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}