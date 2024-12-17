using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using BulkyBookWeb.NewFolder1;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)      
        {
            _db = db;


        }
        public IActionResult Index()
        {
            IEnumerable<category> objCategoryList = _db.Categories.ToList();
            ;
            return View(objCategoryList); 
             
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(category obj)
        {

            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomerError", "The display order cannot match the name ");
            }
            if (ModelState.IsValid) { }
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(obj);
    
}
