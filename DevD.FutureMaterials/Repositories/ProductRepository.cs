using DevD.FutureMaterials.Models;
using DevD.FutureMaterials.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DevD.FutureMaterials.Repositories
{
    public class ProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }

        public void Create(ProductModel product)
        {
        }

        public IList<ProductModel> ReadAll()
        {
            return null;
        }

        public ProductModel Read(int id) => _context.Products
                                                .Include(c => c.Category)
                                                .FirstOrDefault(p => p.ProductId == id);

        public void Update(ProductModel product)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
