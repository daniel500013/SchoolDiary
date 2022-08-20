namespace SchoolDiary.Tests.Tests
{
    public class ClassManagerControllerTests
    {
        private HttpClient Client { get; set; }

        public ClassManagerControllerTests()
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
        public async Task GetPersonClass_WithoutParams_ReturnOkRequest()
        {
            var response = await Client.GetAsync("/api/ClassManager");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }
    }
}
