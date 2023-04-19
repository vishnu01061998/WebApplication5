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
            //var employees = db.Employees.ToList();
            //var teachers = db.Teachers.ToList();

            return View(members);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 //32.22
        }
        [HttpGet]
        public IActionResult Create()
        {
            Member member = new Member();

            return View(member);
        }
        [HttpPost]
        public IActionResult Create(Member member)
        {

            BrightmvcContext db = new BrightmvcContext();
            db.Members.Add(member);
           db.SaveChanges();

            return RedirectToAction("Index");
        }




        public IActionResult update()
        { 
            return View();
        }
    }
}
