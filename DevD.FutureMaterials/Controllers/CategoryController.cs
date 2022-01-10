using DevD.FutureMaterials.Controllers.Filters;
using DevD.FutureMaterials.Models;
using DevD.FutureMaterials.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevD.FutureMaterials.Controllers
{
    [LogFilter]
    public class CategoryController : Controller
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoryController(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // GET: Category
        public IActionResult Index() => View(_categoryRepository.ReadAll());

        // GET: Category/Details/5
        public ActionResult Details(int id) => View(_categoryRepository.Read(id));

        // GET: Category/Create
        public IActionResult Create()
        {
            return View(new CategoryModel());
        }

        // POST: Category/Create (Sobrescrita do método Create)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                TempData["message"] = "Success!";
                return RedirectToAction("Index", "Category");
            }
            else return View(category);
        }

        // GET: Category/Edit/5
        public IActionResult Edit(int id)
        {
            CategoryModel tipo = new()
            {
                CategoryId = id,
                Description = "Description...",
                Marketed = false
            };


            return View(tipo);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryModel category)
        {
            return RedirectToAction("Index", "Category");
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
