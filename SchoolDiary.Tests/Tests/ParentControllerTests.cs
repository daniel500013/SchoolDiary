using FluentAssertions;
using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolDiary.api;

namespace SchoolDiary.Tests.Tests
{
    public class ParentControllerTests
    {
        private HttpClient Client { get; set; }

        public ParentControllerTests()
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
        public async Task GetParent_WithoutParams_ReturnOkRequest()
        {
            var response = await Client.GetAsync("/api/Parent");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateParent_WithoutParams_ReturnOkRequest()
        {
            var model = new ParentDto()
            {
                FirstName = "Jon",
                LastName = "Testman",
                Email = "jon.testman@gmail.com",
                Phone = "123456789"
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Parent", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task ChangeParent_WithoutParams_ReturnOkRequest()
        {
            var model = new ParentDto()
            {
                FirstName = "Andrew",
                LastName = "Gorgeman",
                Email = "an.gorgeman@gmail.com",
                Phone = "987654321"
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PutAsync("/api/Parent/1", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task DeleteParent_WithoutParams_ReturnOkRequest()
        {
            var response = await Client.DeleteAsync("/api/Parent/1");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateParent_WithoutParams_ReturnFailRequest()
        {
            var model = new ParentDto()
            {
                FirstName = "Jon",
                LastName = "Testman",
                Email = "jon.testman.gmail.com",
                Phone = "123456789"
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Parent", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.InternalServerError);
        }
    }
}
