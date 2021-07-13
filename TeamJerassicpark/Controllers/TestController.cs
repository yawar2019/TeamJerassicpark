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

        [Authorize(Roles="Admin,Manager")]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="Admin")]
        public ActionResult ContactUS()
        {
            return View();
        }
        [Authorize(Roles = "Manager")]
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

        public ActionResult ConSumeWebService()
        {
            ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();

            return View(obj.GetEmployeeData().ToList());
        }

        public ActionResult ConSumeWCFService()
        {
            ServiceReference2.Service1Client obj = new ServiceReference2.Service1Client("NetTcpBinding_IService1");

            return Content(obj.Add(10,20).ToString());
        }
    }
}