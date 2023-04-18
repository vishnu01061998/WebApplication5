using Microsoft.AspNetCore.Mvc;
using WebApplication5.models;


namespace MVCPractice2.Controllers

{
    public partial class HomeController : Controller
    {
        public IActionResult Index()
        {

            BrightmvcContext db = new BrightmvcContext();  

            var members = db.Members.ToList();
            var employees = db.Employees.ToList();
            var teachers = db.Teachers.ToList();

            return View(members);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 //32.22
        }                                              

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult update()
        { 
            return View();
        }
    }
}
