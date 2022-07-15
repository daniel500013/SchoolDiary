using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDiary.Tests.Tests
{
    public class GradeControllerTests
    {
        private HttpClient Client { get; set; }

        public GradeControllerTests()
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
        public async Task GetGrades_WithoutParams_ReturnOkRequest()
        {
            var response = await Client.GetAsync("/api/Grade");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateGrade_WithoutParams_ReturnOkRequest()
        {
            var model = new GradeViewModel()
            {
                GradeValue = 5,
                Description = "testDesc",
                Weight = 1
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Grade", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task DeleteGrade_WithoutParams_ReturnOkRequest()
        {
            var model = new GradeViewModel()
            {
                GradeValue = 5,
                Description = "testDesc",
                Weight = 1
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            await Client.PostAsync("/api/Grade", httpContext);

            var response = await Client.DeleteAsync("/api/Grade/1");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }
    }
}
