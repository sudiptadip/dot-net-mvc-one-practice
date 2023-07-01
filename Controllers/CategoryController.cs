using connect_to_database.Data;
using connect_to_database.Models;
using Microsoft.AspNetCore.Mvc;

namespace connect_to_database.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AplicationDbContext _db;
        public CategoryController(AplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Student> students = _db.students.ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student obj)
        {
            if(obj.name == obj.clas)
            {
                ModelState.AddModelError("clas", "Name and class not be same");
            }
            if (ModelState.IsValid)
            {
                _db.students.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
    }
}
