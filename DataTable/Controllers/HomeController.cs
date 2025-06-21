using System.Collections.Generic;
using System.Diagnostics;
using DataTable.Models;
using DataTable.Models.Classes;
using DataTable.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace DataTable.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDBContext _app;

        public HomeController(ILogger<HomeController> logger,AppDBContext app)
        {
            _logger = logger;
            _app = app;
        }

        public IActionResult Index()
        {
            //List<Student> students = _app.Student.ToList();
            TempData["message"] = "Add Student Coming Soon....";
            return View();
        }
        public IActionResult GetStudentList()
        {
            var students = _app.Student.ToList();
            return new JsonResult(students);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
