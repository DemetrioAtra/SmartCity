using DevD.FutureMaterials.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevD.FutureMaterials.Controllers
{
    public class TipoProdutoController : Controller
    {
        // GET: TipoProduto
        public IActionResult Index()
        {
            IList<TipoProduto> lista = new List<TipoProduto>
            {
                new TipoProduto()
                {
                    Id = 1,
                    Descricao = "Tinta",
                    Comercializado = true
                },
                new TipoProduto()
                {
                    Id = 2,
                    Descricao = "Filtro de Água",
                    Comercializado = true
                },
                new TipoProduto()
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
            return View(new TipoProduto());
        }

        // POST: TipoProduto/Create/? (Sobrescrita do método Create)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TipoProduto tipo)
        {
            if (!ModelState.IsValid) return View(tipo);
            else return RedirectToAction("Index", "TipoProduto");
        }

        // GET: TipoProduto/Edit/5
        public IActionResult Edit(int id)
        {
            TipoProduto tipo = new()
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
        public IActionResult Edit(TipoProduto tipo)
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
