using System.Collections.Generic;
using Reviews.Api.Models;

namespace Reviews.Api.Services
{
    public class LendersRepository : ILendersRepository
    {
        // TODO: please avoid this state, using it just to simulate in memory persistence
        List<Lender> lenders;

        public LendersRepository()
        {
            lenders = new List<Lender>()
            {
                new Lender() { Id = 1, Name = "Wells Fargo", Phone = "1 (800) 869-3557" },
                new Lender() { Id = 2, Name = "Sebonic Financial", Phone = "(855) 561-4944" }
            };
        }

        public IEnumerable<Lender> GetAll()
        {
            return lenders;
        }

        public int Save(Lender lender)
        {
            lender.Id = lenders.Count + 1;
            lenders.Add(lender);

            return lender.Id;
        }
    }
}
