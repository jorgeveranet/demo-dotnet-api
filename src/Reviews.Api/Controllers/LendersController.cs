using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Reviews.Api.Controllers
{
    public class LendersController : Controller
    {
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
