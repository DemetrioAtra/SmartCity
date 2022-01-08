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
                    Characteristics = "Sustentável, smart",
                    MidPrice = 1000,
                    Logo = "Biomass",
                    Active = true,
                },
                new ProductModel()
                {
                    Id = 2,
                    Name = "Tinta Vermelha",
                    Characteristics = "Sustentável, smart",
                    MidPrice = 1000,
                    Logo = "Biomass",
                    Active = true,
                },
                new ProductModel()
                {
                    Id = 3,
                    Name = "Tinta Rosa",
                    Characteristics = "Sustentável",
                    MidPrice = 800,
                    Logo = "Biomass",
                    Active = false,
                },
                new ProductModel()
                {
                    Id = 4,
                    Name = "",
                    Characteristics = "Smart",
                    MidPrice = 4000,
                    Logo = "Empresa 1",
                    Active = false,
                },
                new ProductModel()
                {
                    Id = 5,
                    Name = "",
                    Characteristics = "Sustentável, smart",
                    MidPrice = 5000,
                    Logo = "Empresa 2",
                    Active = true,
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
