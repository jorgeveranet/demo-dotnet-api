using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reviews.Api.Models;
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
            return Ok(repository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Lender lender)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            int id = repository.Save(lender);

            return Ok(new { Id = id });
        }
    }
}
