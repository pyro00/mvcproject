using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;
namespace geos_mvc.Controllers
{
    public class SecurityController : Controller
    {
        

        // GET: Security
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Kullanici personel)
        {
            if (true)
            {

            }
            return View();
        }
    }
}