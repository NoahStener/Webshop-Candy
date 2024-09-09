using Microsoft.EntityFrameworkCore;
using Webshop_Candy.Data;
using Webshop_Candy.Models;

namespace Webshop_Candy.Service
{
    public class CandyRepository : ICandyRepository
    {
        private readonly AppDbContext _appDbContext;
        public CandyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Candy> GetAllCandy
        {
            get
            {
                return _appDbContext.Candies.Include(c => c.Category);
            }
        }

        public IEnumerable<Candy> GetCandyOnSale
        {
            get
            {
                return _appDbContext.Candies.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Candy GetCandyById(int candyId)
        {
            return _appDbContext.Candies.FirstOrDefault(c => c.CandyID == candyId);
        }
    }
}
