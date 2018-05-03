using Reviews.Api.Controllers;
using Xunit;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace Reviews.Api.Tests.Controllers
{
    public class LendersControllerTest
    {
        [Fact]
        public async void Get()
        {
            var controller = new LendersController();
            var response = await controller.Get();

            var okResult = Assert.IsType<OkResult>(response);
            Assert.Equal(200, okResult.StatusCode);
        }
    }
}
