using FluentAssertions;

namespace SchoolDiary.Tests
{
    public class AccountControllerTests
    {
        private HttpClient Client { get; set; }

        public AccountControllerTests()
        {
            var factory = new WebApplicationFactory<Program>();
            Client = factory.CreateClient();
        }

        [Fact]
        public async Task Register_WithParams_ReturnOkRequest()
        {
            var model = new LoginViewModel()
            {
                Email = "user@user.com",
                Password = "user"
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Account/Register", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task Login_WithParams_ReturnOkRequest()
        {
            var model = new LoginViewModel()
            {
                Email = "admin@admin.com",
                Password = "admin"
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Account/Login", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }
    }
}