using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reviews.Api.Services;

namespace Reviews.Api.Controllers
{
    [Route("api/lenders")]
    public class LendersController : Controller
    {
        ILendersRepository repository;

        public LendersController(ILendersRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(repository.GeLenders());
        }
    }
}
