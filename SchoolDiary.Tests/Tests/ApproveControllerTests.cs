using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDiary.Tests.Tests
{
    public class ApproveControllerTests
    {
        private HttpClient Client { get; set; }

        public ApproveControllerTests()
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
        public async Task GetApproves_WithoutParams_ReturnOkRequest()
        {
            var response = await Client.GetAsync("/api/Approve");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateApprove_WithoutParams_ReturnOkRequest()
        {
            var model = new ApproveViewModel()
            {
                Positive = true,
                Description = "desc",
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Approve", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task ChangeApprove_WithoutParams_ReturnOkRequest()
        {
            var model = new ApproveViewModel()
            {
                Positive = true,
                Description = "desc",
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            await Client.PostAsync("/api/Approve", httpContext);
            await Client.PostAsync("/api/Approve", httpContext);

            var ModelToChange = new ApproveViewModel()
            {
                Positive = false,
                Description = "desc",
            };

            var JsonToChange = JsonConvert.SerializeObject(ModelToChange);
            var HttpContextToChange = new StringContent(JsonToChange, Encoding.UTF8, "application/json");
            var response = await Client.PutAsync("/api/Approve/1", HttpContextToChange);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task RemoveApprove_WithoutParams_ReturnOkRequest()
        {
            var model = new ApproveViewModel()
            {
                Positive = true,
                Description = "desc",
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            await Client.PostAsync("/api/Approve", httpContext);

            var response = await Client.DeleteAsync("/api/Approve/1");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }
    }
}
