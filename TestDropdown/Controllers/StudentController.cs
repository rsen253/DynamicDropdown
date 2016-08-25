using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDropdown.Models;

namespace TestDropdown.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student obj = new Student();
            List<Student> model = new List<Student>();
            obj = new Student { StudentId = 1 , StudentName = "Batman" };
            model.Add(obj);
            obj = new Student { StudentId = 2 , StudentName = "Spiderman" };
            model.Add(obj);
            obj = new Student { StudentId = 3 , StudentName = "Superman" };
            model.Add(obj);

            var allStudent = (from m in model select m).ToList();
            ViewBag.Student = new SelectList(allStudent, "StudentId" , "StudentName");

            return View();
        }
    }
}