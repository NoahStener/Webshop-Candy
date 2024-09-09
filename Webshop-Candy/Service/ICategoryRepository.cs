using Webshop_Candy.Models;

namespace Webshop_Candy.Service
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories {  get; }

    }
}
