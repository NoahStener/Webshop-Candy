using Webshop_Candy.Models;

namespace Webshop_Candy.ViewModels
{
    public class CandyListViewModel
    {
        public IEnumerable<Candy> Candies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
