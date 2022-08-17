namespace SchoolDiary.Tests.Tests
{
    public class AccountControllerTests
    {
        private HttpClient Client { get; set; }

        public AccountControllerTests()
        {
            var factory = new WebApplicationFactory<Program>();
            Client = factory
                .WithWebHostBuilder(builder =>
                {
                    builder.ConfigureServices(services =>
                    {
                        var dbContext = services
                            .SingleOrDefault(x => x.ServiceType == typeof(DbContextOptions<DiaryDbContext>));
                        services.Remove(dbContext);

                        services.AddSingleton<IPolicyEvaluator, FakePolicy>();

                        services.AddDbContext<DiaryDbContext>(options => options.UseInMemoryDatabase("DiaryDb"));
                    });
                })
                .CreateClient();
        }

        [Fact]
        public async Task GetAllUsers_WithoutParams_ReturnOkRequest()
        {
            var response = await Client.GetAsync("/api/Account");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task Register_WithoutParams_ReturnOkRequest()
        {
            var model = new LoginDto()
            {
                Email = "test@test.com",
                Password = "test"
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Account/Register", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task Login_WithoutParams_NotEmptyResult()
        {
            var model = new LoginDto()
            {
                Email = "user@user.com",
                Password = "user"
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Account/Register", httpContext);

            var response = await Client.PostAsync("/api/Account/Login", httpContext);

            var token = await response.Content.ReadAsStringAsync();

            Assert.NotEmpty(token);
        }

        [Fact]
        public async Task Register_WithoutParams_ReturnFailRequest()
        {
            var model = new LoginDto()
            {
                Email = "test.test.com",
                Password = "test"
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Account/Register", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.InternalServerError);
        }

        [Fact]
        public async Task Login_WithoutParams_ReturnFailRequest()
        {
            var model = new LoginDto()
            {
                Email = "user.user.com",
                Password = "user"
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Account/Register", httpContext);

            var response = await Client.PostAsync("/api/Account/Login", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.InternalServerError);
        }
    }
}