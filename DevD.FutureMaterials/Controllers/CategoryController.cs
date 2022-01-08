using DevD.FutureMaterials.Controllers.Filters;
using DevD.FutureMaterials.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevD.FutureMaterials.Controllers
{
    [LogFilter]
    public class CategoryController : Controller
    {
        // GET: Category
        public IActionResult Index()
        {
            IList<CategoryModel> list = new List<CategoryModel>
            {
                new CategoryModel()
                {
                    Id = 1,
                    Description = "Tinta",
                    Marketed = true
                },
                new CategoryModel()
                {
                    Id = 2,
                    Description = "Filtro de Água",
                    Marketed = true
                },
                new CategoryModel()
                {
                    Id = 3,
                    Description = "Captador de Energia",
                    Marketed = false
                }
            };
            return View(list);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

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
                TempData["mensagem"] = "Tipo de Produto cadastrado com sucesso!";
                return RedirectToAction("Index", "TipoProduto");
            }
            else return View(category);
        }

        // GET: Category/Edit/5
        public IActionResult Edit(int id)
        {
            CategoryModel tipo = new()
            {
                Id = id,
                Description = "Descrição do Tipo",
                Marketed = false
            };


            return View(tipo);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryModel category)
        {
            return RedirectToAction("Index", "TipoProduto");
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
