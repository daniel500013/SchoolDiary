using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDiary.Tests.Tests
{
    public class MarkControllerTests
    {
        private HttpClient Client { get; set; }

        public MarkControllerTests()
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
        public async Task GetMark_WithoutParams_ReturnOkRequest()
        {
            var response = await Client.GetAsync("/api/Mark");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateMark_WithoutParams_ReturnOkRequest()
        {
            var model = new MarkViewModel()
            {
                Present = false
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Mark", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task ChangeMark_WithoutParams_ReturnOkRequest()
        {
            var model = new MarkViewModel()
            {
                Present = false
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            await Client.PostAsync("/api/Mark", httpContext);

            var ChangeModel = new MarkViewModel()
            {
                Present = true
            };

            var JsonToChange = JsonConvert.SerializeObject(model);
            var HttpContextToChange = new StringContent(JsonToChange, Encoding.UTF8, "application/json");
            var response = await Client.PutAsync("/api/Mark/1", HttpContextToChange);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task DeleteMark_WithoutParams_ReturnOkRequest()
        {
            var model = new MarkViewModel()
            {
                Present = false
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            await Client.PostAsync("/api/Mark", httpContext);

            var ChangeModel = new MarkViewModel()
            {
                Present = true
            };

            var response = await Client.DeleteAsync("/api/Mark/1");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }
    }
}
