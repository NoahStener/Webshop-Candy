using Webshop_Candy.Models;

namespace Webshop_Candy.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Candy> CandyOnSale { get; set; }
    }
}
