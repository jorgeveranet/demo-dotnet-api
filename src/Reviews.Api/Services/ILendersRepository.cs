using System.Collections.Generic;
using Reviews.Api.Models;

namespace Reviews.Api.Services
{
    public interface ILendersRepository
    {
        IEnumerable<Lender> GeLenders();
    }
}
