using DevD.FutureMaterials.Controllers.Filters;
using DevD.FutureMaterials.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevD.FutureMaterials.Controllers
{
    [LogFilter]
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            IList<ProdutoModel> lista = new List<ProdutoModel>
            {
                new ProdutoModel()
                {
                    Id = 1,
                    Nome = "Tinta Azul",
                    Caracteristica = "Sustentável, smart",
                    PrecoMedio = 1000,
                    Logotipo = "Biomass",
                    Ativo = true,
                    TipoProduto = null
                },
                new ProdutoModel()
                {
                    Id = 2,
                    Nome = "Tinta Vermelha",
                    Caracteristica = "Sustentável, smart",
                    PrecoMedio = 1000,
                    Logotipo = "Biomass",
                    Ativo = true,
                    TipoProduto = null
                },
                new ProdutoModel()
                {
                    Id = 3,
                    Nome = "Tinta Rosa",
                    Caracteristica = "Sustentável",
                    PrecoMedio = 800,
                    Logotipo = "Biomass",
                    Ativo = false,
                    TipoProduto = null
                },
                new ProdutoModel()
                {
                    Id = 4,
                    Nome = "",
                    Caracteristica = "Smart",
                    PrecoMedio = 4000,
                    Logotipo = "Empresa 1",
                    Ativo = false,
                    TipoProduto = null
                },
                new ProdutoModel()
                {
                    Id = 5,
                    Nome = "",
                    Caracteristica = "Sustentável, smart",
                    PrecoMedio = 5000,
                    Logotipo = "Empresa 2",
                    Ativo = true,
                    TipoProduto = null
                }
            };
            return View(lista);
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
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

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produto/Edit/5
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

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
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
