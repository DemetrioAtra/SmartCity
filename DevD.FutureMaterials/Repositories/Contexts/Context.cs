using DevD.FutureMaterials.Models;
using Microsoft.EntityFrameworkCore;

namespace DevD.FutureMaterials.Repositories.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductModel>? Products { get; set; }
        public DbSet<CategoryModel>? Categories { get; set; }
    }
}
