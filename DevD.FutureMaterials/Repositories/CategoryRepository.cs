using DevD.FutureMaterials.Models;
using DevD.FutureMaterials.Repositories.Contexts;

namespace DevD.FutureMaterials.Repositories
{
    public class CategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public void Create(CategoryModel category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public IList<CategoryModel> ReadAll() => _context.Categories.ToList();
        public CategoryModel Read(int id) => _context.Categories.Find(id);

        public void Update(CategoryModel category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            CategoryModel category = _context.Categories.Find(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
