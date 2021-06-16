using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdonetExample.Models;
namespace AdonetExample.Controllers
{
    public class HomeController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.GetAllEmployee());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
           int i= db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //[HttpPost]
        //public ActionResult Create(FormCollection frm)
        //{

        //    return View();
        //}


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp= db.getEmployeeById(id);

            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.UpdateEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.getEmployeeById(id);

            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            EmployeeModel emp = db.getEmployeeById(id);

            return View(emp);
        }
      
        public ActionResult ViewDataExample()
        {
            ViewData["Username"] = "ritu";
            ViewBag.Lastname = "Menal";
            TempData["FirstName"]="Vaishali";


            return View();
        }
        public ActionResult ViewDataExample2()
        {
            string Name =(string) ViewData["Username"];
            string Lastname = ViewBag.LastName;
            //string FirstName =(string)TempData["FirstName"];
            //TempData.Keep();
            string FirstName = TempData.Peek("FirstName").ToString();//valueread and retain
            return View();
        }

    }
}