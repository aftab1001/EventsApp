using System.Threading.Tasks;
using EventsApp.Models.TokenAuth;
using EventsApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace EventsApp.Web.Tests.Controllers
{
    public class HomeController_Tests: EventsAppWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}