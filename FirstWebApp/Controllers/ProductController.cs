using FirstWebApp.Data;
using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class ProductController : Controller
    {
        MyDbContext _context;
        public ProductController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //var objList = _context.Products.ToList();
            //ViewBag.ProductList = objList;
            List<Products> objList = _context.Products.ToList();
            return View(objList);
        }
    }
}
