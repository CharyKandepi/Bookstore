using Bookstore.Data;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly EFCoreDbContext _db;
        public CategoryController(EFCoreDbContext db)
        {
            _db = db;
         

        }
        public IActionResult Index()
        {
            List<Category> obj = _db.Categories.ToList();
            return View(obj);
        }
        public IActionResult Index2()
        {
            List<Category> obj = _db.Categories.ToList();
            return View(obj);
        }
    }
}
