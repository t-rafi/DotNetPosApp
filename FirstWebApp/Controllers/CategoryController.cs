using FirstWebApp.Data;
using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FirstWebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyDbContext _context;

        public CategoryController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var objList = _context.Categories.ToList();
            ViewBag.CategoryList = objList;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            Category obj = new Category { CategoryName = model.CategoryName}; 
            _context.Categories.Add(obj);
            _context.SaveChanges();
            TempData["success"] = "Category created successfully!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var obj = _context.Categories.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Category model)
        {
            Category obj = new Category { CategoryId = model.CategoryId, CategoryName = model.CategoryName };
            _context.Categories.Update(model);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int DltId, string DltNm)
        {
            var obj = _context.Categories.Find(DltId);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(Category obj)
        {
            _context.Categories.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var obj = _context.Categories.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }
}
