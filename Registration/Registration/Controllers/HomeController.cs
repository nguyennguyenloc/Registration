using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
       /* public IActionResult Index()
        {
            return View();
        }*/
        /*public ViewResult index()
        {
            return View("myView");
        }*/
        public IActionResult Index()
        {
            ViewBag.loc = "My name is Loc";
            return View("myView");
        }
        public String Index2()
        {
            return "Hello Lộc, you can do it";
        }
        public IActionResult Register()
        {
            return View();
        } 
        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                Reponsitory.AddStudent(student);
                return View("Thanks",student);
            }
            else
            {
                return View();
            }
        }
        public IActionResult listStudent()
        {
            return View(Reponsitory.GetStudents());
        }
    }
}
