using Webshop_Candy.Models;

namespace Webshop_Candy.Service
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> GetAllCandy {  get; }
        IEnumerable<Candy> GetCandyOnSale { get; }
        Candy GetCandyById(int candyId);
    }
}
