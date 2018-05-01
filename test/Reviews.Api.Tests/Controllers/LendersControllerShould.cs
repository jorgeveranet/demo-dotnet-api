using Reviews.Api.Controllers;
using Xunit;
using System.Net.Http;

namespace Reviews.Api.Tests
{
    public class LendersControllerShould
    {
        [Fact]
        public async void Get()
        {
            var controller = new LendersController();

            var response = await controller.Get();
        }
    }
}
