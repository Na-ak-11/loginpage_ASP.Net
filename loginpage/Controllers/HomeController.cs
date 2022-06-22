using loginpage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loginpage.Controllers
{
    public class HomeController : Controller
    {
        loginEntities db = new loginEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(user log)
        {
           var user = db.users.Where(x => x.username == log.username && x.password == log.password).Count();

            if (user > 0)
            {
                return RedirectToAction("successful");
            }
            else
            {
                return RedirectToAction("error");
            }
            
        }
        public ActionResult successful()
        {
            return View();
        }

        public ActionResult error()
        {
            return View();
        }

    }
}