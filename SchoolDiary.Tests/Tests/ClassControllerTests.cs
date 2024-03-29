﻿namespace SchoolDiary.Tests.Tests
{
    public class ClassControllerTests
    {
        private HttpClient Client { get; set; }

        public ClassControllerTests()
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
        public async Task GetClasses_WithoutParams_ReturnOkRequest()
        {
            var response = await Client.GetAsync("/api/Class");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateClass_WithoutParams_ReturnOkRequest()
        {
            var model = new ClassDto()
            {
                ClassNumber = 1,
                Profile = "PZ",
                Description = "Sample description of class"
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Class", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task ChangeClass_WithoutParams_ReturnOkRequest()
        {
            var model = new ClassDto()
            {
                ClassNumber = 1,
                Profile = "PZ",
                Description = "Sample description of class"
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            await Client.PostAsync("/api/Class", httpContext);

            var NewModel = new ClassDto()
            {
                ClassNumber = 1,
                Profile = "PZ",
                Description = "Sample description of class"
            };

            var newJson = JsonConvert.SerializeObject(NewModel);
            var newHttpContext = new StringContent(newJson, Encoding.UTF8, "application/json");
            var newResponse = await Client.PutAsync("/api/Class/1", newHttpContext);

            newResponse.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task RemoveClass_WithoutParams_ReturnOkRequest()
        {
            var response = await Client.DeleteAsync("/api/Class/1");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateClass_WithoutParams_ReturnFailRequest()
        {
            var model = new ClassDto()
            {
                
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Class", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.InternalServerError);
        }
    }
}
