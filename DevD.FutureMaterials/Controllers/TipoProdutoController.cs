using DevD.FutureMaterials.Controllers.Filters;
using DevD.FutureMaterials.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevD.FutureMaterials.Controllers
{
    [LogFilter]
    public class TipoProdutoController : Controller
    {
        // GET: TipoProduto
        public IActionResult Index()
        {
            IList<TipoProdutoModel> lista = new List<TipoProdutoModel>
            {
                new TipoProdutoModel()
                {
                    Id = 1,
                    Descricao = "Tinta",
                    Comercializado = true
                },
                new TipoProdutoModel()
                {
                    Id = 2,
                    Descricao = "Filtro de Água",
                    Comercializado = true
                },
                new TipoProdutoModel()
                {
                    Id = 3,
                    Descricao = "Captador de Energia",
                    Comercializado = false
                }
            };
            return View(lista);
        }

        // GET: TipoProduto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoProduto/Create
        public IActionResult Create()
        {
            return View(new TipoProdutoModel());
        }

        // POST: TipoProduto/Create/? (Sobrescrita do método Create)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TipoProdutoModel tipo)
        {
            if (ModelState.IsValid)
            {
                TempData["mensagem"] = "Tipo de Produto cadastrado com sucesso!";
                return RedirectToAction("Index", "TipoProduto");
            }
            else return View(tipo);
        }

        // GET: TipoProduto/Edit/5
        public IActionResult Edit(int id)
        {
            TipoProdutoModel tipo = new()
            {
                Id = id,
                Descricao = "Descrição do Tipo",
                Comercializado = false
            };


            return View(tipo);
        }

        // POST: TipoProduto/Edit/?
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TipoProdutoModel tipo)
        {
            return RedirectToAction("Index", "TipoProduto");
        }

        // GET: TipoProduto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoProduto/Delete/5
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
