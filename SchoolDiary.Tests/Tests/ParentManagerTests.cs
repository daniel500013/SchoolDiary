using FluentAssertions;
using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolDiary.api;

namespace SchoolDiary.Tests.Tests
{
    public class ParentManagerTests
    {
        private HttpClient Client { get; set; }

        public ParentManagerTests()
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
            var response = await Client.GetAsync("/api/ParentManager");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }
    }
}
