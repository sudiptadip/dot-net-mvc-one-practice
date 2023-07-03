using connect_to_database.Data;
using Microsoft.AspNetCore.Mvc;
using Models;

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
                TempData["success"] = "Category Created Successfuly";
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }


        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            Student? studentFromDb = _db.students.Find(id);
            Student? studentFromDb1 = _db.students.FirstOrDefault(u => u.id == id);
            Student? studentFromDb2 = _db.students.Where(u => u.id == id).FirstOrDefault();

            if (studentFromDb == null)
            {
                return NotFound();
            }
            return View(studentFromDb); 
        }

        [HttpPost]
        public IActionResult Edit(Student obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.students.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Student Edit Successfuly";
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Student? studentFromDb = _db.students.Find(id);
            Student? studentFromDb1 = _db.students.FirstOrDefault(u => u.id == id);
            Student? studentFromDb2 = _db.students.Where(u => u.id == id).FirstOrDefault();

            if (studentFromDb == null)
            {
                return NotFound();
            }
            return View(studentFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Student? obj = _db.students.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.students.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Student Deleted Successfuly";
            return RedirectToAction("index");            
        }
    }
}
