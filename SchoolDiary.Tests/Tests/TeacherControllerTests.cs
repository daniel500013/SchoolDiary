using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDiary.Tests.Tests
{
    public class TeacherControllerTests
    {
        private HttpClient Client { get; set; }

        public TeacherControllerTests()
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
        public async Task GetTeachers_WithoutParams_ReturnOkRequest()
        {
            var response = await Client.GetAsync("/api/Teacher");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateTeacher_WithoutParams_ReturnOkRequest()
        {
            var model = new TeacherDto()
            {
                FirstName = "Jon",
                LastName = "Testman",
                Gender = true,
                Email = "jon.testman@gmail.com",
                Phone = "123456789"
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Teacher", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task ChangeTeacher_WithoutParams_ReturnOkRequest()
        {
            var ModelToAdd = new TeacherDto()
            {
                FirstName = "Jon",
                LastName = "Testman",
                Gender = true,
                Email = "jon.testman@gmail.com",
                Phone = "123456789"
            };

            var jsonToAdd = JsonConvert.SerializeObject(ModelToAdd);
            var httpContextToAdd = new StringContent(jsonToAdd, Encoding.UTF8, "application/json");
            await Client.PostAsync("/api/Teacher", httpContextToAdd);

            var model = new TeacherDto()
            {
                FirstName = "Henry",
                LastName = "NoTestman",
                Gender = false,
                Email = "jon.notestman@gmail.com",
                Phone = "987654321"
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await Client.PutAsync("/api/Teacher/1", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task DeleteTeacher_WithoutParams_ReturnOkRequest()
        {
            var model = new TeacherDto()
            {
                FirstName = "Jon",
                LastName = "Testman",
                Gender = true,
                Email = "jon.testman@gmail.com",
                Phone = "123456789"
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            await Client.PostAsync("/api/Teacher", httpContext);
            await Client.PostAsync("/api/Teacher", httpContext);

            var response = await Client.DeleteAsync("/api/Teacher/2");

            await response.Content.ReadAsStringAsync();

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateTeacher_WithoutParams_ReturnFailRequest()
        {
            var model = new TeacherDto()
            {
                FirstName = "Jon",
                LastName = "Testman",
                Gender = true,
                Email = "jon.testman.gmail.com",
                Phone = "123456789"
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Teacher", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.InternalServerError);
        }
    }
}
