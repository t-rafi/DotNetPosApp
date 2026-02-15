using FirstWebApp.Data;
using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class ProductController : Controller
    {
        private MyDbContext _context; //DbContext er object create korlam, jeta database er sathe communication er jonno use hobe
        public ProductController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //var objList = _context.Products.ToList();
            //ViewBag.ProductList = objList;
            List<Product> objList = _context.Products.ToList();
            return View(objList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(obj);
                _context.SaveChanges();
                TempData["success"] = "Category created successfully!";
                return RedirectToAction("Index");
            }
            ;
            return View(obj);
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

    }
}
