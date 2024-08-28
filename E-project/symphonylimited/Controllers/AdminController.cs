using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using symphonylimited.Models;

namespace symphonylimited.Controllers
{ [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
       

        private readonly SymphonyContext db;

        public AdminController(SymphonyContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            //if(HttpContext.Session.GetString("role") == "admin")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("adminEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
            return View();
        }

		public IActionResult Login()
		{
			return View();
		}

        
        [HttpPost]

        [ValidateAntiForgeryToken]

        public IActionResult Login(string email, string pass)
        {
            //if (email == "admin@gmail.com" && pass == "123")
            //{
            //    HttpContext.Session.SetString("adminEmail", email);
            //    HttpContext.Session.SetString("role", "admin");
            //    return RedirectToAction("Index");
            //}
            //else if (email == "user@gmail.com" && pass == "123")
            //{
            //    HttpContext.Session.SetString("userEmail", email);
            //    HttpContext.Session.SetString("role", "user");
            //    return RedirectToAction("Index", "Home");
            //}
            //else
            //{
            //    ViewBag.msg = "Invalid Credentials";
            //    return View();
            //}
            return View();
        }

      

        public IActionResult Aboutus()
        {
            //if (HttpContext.Session.GetString("role") == "admin")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("adminEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
            return View();
        }


        public IActionResult Contactus()
        {
            //if (HttpContext.Session.GetString("role") == "admin")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("adminEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
            return View();
        }


        public IActionResult academicdepartment()
        {
            var regStudentsList=db.RegisteredStudents.ToList();
            ViewBag.RegisterStd = regStudentsList;

            var entranceStdList = db.EntranceStudents.ToList();
            return View(entranceStdList);
        }


        public IActionResult Accountdepartment()
        {
            //if (HttpContext.Session.GetString("role") == "admin")
            //{
            //    ViewBag.email = HttpContext.Session.GetString("adminEmail");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
            return View();
        }


        public IActionResult LogoutAdmin()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("role");
            HttpContext.Session.Remove("adminEmail");

            return RedirectToAction("Login");

        }





    }
}
