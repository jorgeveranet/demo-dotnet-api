using System.Collections.Generic;
using Reviews.Api.Models;

namespace Reviews.Api.Services
{
  public class LendersRepository : ILendersRepository
  {
    public IEnumerable<Lender> GeLenders()
    {
        return new List<Lender>()
        {
            new Lender() { Id = 1, Name = "Wells Fargo", Phone = "1 (800) 869-3557" },
            new Lender() { Id = 2, Name = "Sebonic Financial", Phone = "(855) 561-4944" }
        };
    }
  }
}
