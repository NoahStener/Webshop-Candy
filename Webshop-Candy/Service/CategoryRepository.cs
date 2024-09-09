using Webshop_Candy.Data;
using Webshop_Candy.Models;

namespace Webshop_Candy.Service
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetAllCategories => _context.Categories;
    }
}
