using DevD.FutureMaterials.Controllers.Filters;
using DevD.FutureMaterials.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevD.FutureMaterials.Controllers
{
    [LogFilter]
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            IList<ProductModel> list = new List<ProductModel>
            {
                new ProductModel()
                {
                    Id = 1,
                    Name = "Tinta Azul",
                    Caracteristica = "Sustentável, smart",
                    PrecoMedio = 1000,
                    Logotipo = "Biomass",
                    Ativo = true,
                    TipoProduto = null
                },
                new ProductModel()
                {
                    Id = 2,
                    Name = "Tinta Vermelha",
                    Caracteristica = "Sustentável, smart",
                    PrecoMedio = 1000,
                    Logotipo = "Biomass",
                    Ativo = true,
                    TipoProduto = null
                },
                new ProductModel()
                {
                    Id = 3,
                    Name = "Tinta Rosa",
                    Caracteristica = "Sustentável",
                    PrecoMedio = 800,
                    Logotipo = "Biomass",
                    Ativo = false,
                    TipoProduto = null
                },
                new ProductModel()
                {
                    Id = 4,
                    Name = "",
                    Caracteristica = "Smart",
                    PrecoMedio = 4000,
                    Logotipo = "Empresa 1",
                    Ativo = false,
                    TipoProduto = null
                },
                new ProductModel()
                {
                    Id = 5,
                    Name = "",
                    Caracteristica = "Sustentável, smart",
                    PrecoMedio = 5000,
                    Logotipo = "Empresa 2",
                    Ativo = true,
                    TipoProduto = null
                }
            };
            return View(list);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
