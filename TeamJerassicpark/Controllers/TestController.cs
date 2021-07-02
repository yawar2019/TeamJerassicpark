using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TeamJerassicpark.Models;

namespace TeamJerassicpark.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult ContactUS()
        {
            return View();
        }
        [Authorize]
        public ActionResult AboutUS()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserDetail user)
        {
            EmployeeEntities db = new EmployeeEntities();
            var userinfo = db.UserDetails.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
            if (userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Index");
            }

            return View(user);
        }
    }
}