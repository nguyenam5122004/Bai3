using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Project1.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> Students = new List<Student>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Student model)
        {
            if (ModelState.IsValid)
            {
                Students.Add(model);

                TempData["MSSV"] = model.MSSV;
                TempData["HoTen"] = model.HoTen;
                TempData["ChuyenNganh"] = model.ChuyenNganh;

                TempData["SoLuongCungNganh"] = Students.FindAll(s => s.ChuyenNganh == model.ChuyenNganh).Count;

                return RedirectToAction("ShowKQ");
            }

            return View("Index");
        }
        public IActionResult ShowKQ()
        {
            return View();
        }
    }

    public class Student
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }
        public string ChuyenNganh { get; set; }
    }
}
