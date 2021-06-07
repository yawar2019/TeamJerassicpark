using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamJerassicpark.Models;

namespace TeamJerassicpark.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        [Route("Hotel/Biryani")]
        [Route("Hotel/Mandi")]
        [Route("Hotel/Veg")]

        public string Index()
        {
            return "Hello World";
        }

        public int Index2()
        {
            return 1;
        }

        public string Index3(int? id)
        {
            return "My Employee Id is " + id;
        }

        public ActionResult GetMeView()
        {

            return View("Tesla");
        }

        public ActionResult GetMeView2()
        {
            return View("~/Views/Test/Index.cshtml");
        }

        public ActionResult GetMeView3()
        {
            ViewBag.info = "Wipro";

            return View();
        }

        public ActionResult GetMeView4()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 12345;


            ViewBag.info = emp;

            return View();
        }

        public ActionResult GetMeView5()
        {
            List<EmployeeModel> listEmpinfo = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 12345;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "SHARATH";
            emp1.EmpSalary = 17445;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Balakrishna";
            emp2.EmpSalary = 23456;

            listEmpinfo.Add(emp);
            listEmpinfo.Add(emp1);
            listEmpinfo.Add(emp2);

            int patientid = Convert.ToInt32("1");

            ViewBag.info = listEmpinfo;

            return View();
        }

        public ActionResult GetMeView6()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 12345;
            //object model = emp;

            return View(emp);
        }

        public ActionResult GetMeView7()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 12345;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 1;
            emp1.EmpName = "Hitesh";
            emp1.EmpSalary = 450000;

            listObj.Add(emp);
            listObj.Add(emp1);

            return View(listObj);
        }
        //hitesh
        public ActionResult GetMeView8(EmployeeModel emp123)
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 12345;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 1;
            emp1.EmpName = "Hitesh";
            emp1.EmpSalary = 450000;

            listObj.Add(emp);
            listObj.Add(emp1);

            Department dept = new Department();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            EmpDept obj = new EmpDept();
            obj.emp = listObj;
            obj.Dept = dept;

            return View(obj);
        }

        public ViewResult GetMeView9(int? id) {

            return View();
        }
        public RedirectResult RedirectToGoogle()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectResult RedirectToGoogle2()
        {
            return Redirect("~/New/GetMeView9?id=1");
        }

        public FileResult getMeFile()
        {
            return File("~/Web.config","text/plain");
        }

        public FileResult getMeFile2()
        {
            return File("~/Web.config", "application/xml");
        }

        public FileResult getMeFile3()
        {
            return File("~/ActionResult.pdf", "application/pdf", "ActionResult.pdf");
        }

        public ActionResult getmepartialView()
        {
            return View();
        }

        public ActionResult getmepartialView2()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 12345;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 1;
            emp1.EmpName = "Hitesh";
            emp1.EmpSalary = 450000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Bala";
            emp2.EmpSalary = 650000;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            return View(listEmp);
        }

        public PartialViewResult getmepartialView3()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 12345;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 1;
            emp1.EmpName = "Hitesh";
            emp1.EmpSalary = 450000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Bala";
            emp2.EmpSalary = 650000;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            return PartialView("_myListPartialView", listEmp);
        }

        public JsonResult getmejsoninfo()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 12345;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 1;
            emp1.EmpName = "Hitesh";
            emp1.EmpSalary = 450000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Bala";
            emp2.EmpSalary = 650000;

            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            return Json(listEmp,JsonRequestBehavior.AllowGet);
        }

        public ContentResult getmeContent(int? id)
        {
            if (id == 1)
            {
                return Content("Hello Ritu");
            }
            else if (id == 2)
            {
                return Content("<p style=color:red>Hello Ritu</p>");
            }
            else {
                return Content("<script>alert('Hello Ritu')</script>");
            }
        }

        public RedirectToRouteResult getmetoOtherAction()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 12345;

            return RedirectToAction("GetMeView8", emp);
        }
    }
}