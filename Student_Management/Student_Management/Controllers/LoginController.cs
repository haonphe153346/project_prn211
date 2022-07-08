using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Student_Management.Models;

using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Student_Management.Controllers
{
    public class LoginController : Controller
    {
        student_managementContext db = new student_managementContext();


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string pass)
        {
            int countStudent = 0;
            var liststudent = db.Students.ToList();
            var student = new Student();
            foreach (var s in liststudent)
            {
                if(s.StudentEmail.ToString().Equals(email) && s.StudentPass.ToString().Equals(pass))
                {
                    countStudent++;
                    student = s;
                }
            }
            
            int countLecturer = 0;
            var listlecture = db.Lecturers.ToList();
            var lecturer = new Lecturer();
            foreach (var l in listlecture)
            {
                if(l.LecturerEmail.ToString().Equals(email) && l.LecturerPass.ToString().Equals(pass))
                {
                    countLecturer++;
                    lecturer = l;
                }
            }

            if (countStudent!=0)
            {
                HttpContext.Session.SetInt32("ID",student.StudentId);
                HttpContext.Session.SetString("Name", student.StudentName);
                HttpContext.Session.SetString("Email", student.StudentEmail);
                HttpContext.Session.SetString("Pass", student.StudentPass);
                return RedirectToAction("Student");
            }

            if (countLecturer != 0)
            {
                HttpContext.Session.SetInt32("ID", lecturer.LecturerId);
                HttpContext.Session.SetString("Name", lecturer.LecturerName);
                HttpContext.Session.SetString("Email", lecturer.LecturerEmail);
                HttpContext.Session.SetString("Pass", lecturer.LecturerPass);
                return RedirectToAction("Lecturer");
            }
            else
            {
                ViewBag.Message = "Login Fail";
                return RedirectToAction("Login");
            }

        }

        public IActionResult Student()
        {
            ViewBag.ID = HttpContext.Session.GetInt32("ID");
            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.Email = HttpContext.Session.GetString("Email");
            ViewBag.Pass = HttpContext.Session.GetString("Pass");
            return View();
        }
         public IActionResult Lecturer()
        {
            ViewBag.ID = HttpContext.Session.GetInt32("ID");
            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.Email = HttpContext.Session.GetString("Email");
            ViewBag.Pass = HttpContext.Session.GetString("Pass");
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
