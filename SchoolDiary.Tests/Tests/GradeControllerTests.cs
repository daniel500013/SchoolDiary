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
            //Add lesson
            var LessonModel = new LessonDto()
            {
                Day = 1,
                Hour = 1,
                Name = "Physics"
            };

            var LessonJson = JsonConvert.SerializeObject(LessonModel);

            var LessonContext = new StringContent(LessonJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Lesson", LessonContext);

            //Add Teacher
            var TeacherModel = new TeacherDto()
            {
                Email = "teacher@teacher.com",
                FirstName = "Joan",
                LastName = "Teacher",
                Gender = true,
                Phone = "123123123"
            };

            var TeacherJson = JsonConvert.SerializeObject(TeacherModel);

            var TeacherContext = new StringContent(TeacherJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Teacher", TeacherContext);

            //Add subject
            var SubjectModel = new SubjectDto()
            {
                Lesson = 1,
                Class = 1,
                Teacher = 1
            };

            var SubjectJson = JsonConvert.SerializeObject(SubjectModel);

            var SubjectContext = new StringContent(SubjectJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Subject", SubjectContext);
            
            //Create Grade
            var model = new GradeDto()
            {
                GradeValue = 5,
                Description = "testDesc",
                Weight = 1,
                Class = 1,
                Day = 1,
                Hour = 1,
                Lesson = "Physics",
                UserUUID = Guid.NewGuid()
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Grade", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task DeleteGrade_WithoutParams_ReturnOkRequest()
        {
            //Add lesson
            var LessonModel = new LessonDto()
            {
                Day = 1,
                Hour = 1,
                Name = "Physics"
            };

            var LessonJson = JsonConvert.SerializeObject(LessonModel);

            var LessonContext = new StringContent(LessonJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Lesson", LessonContext);

            //Add Teacher
            var TeacherModel = new TeacherDto()
            {
                Email = "teacher@teacher.com",
                FirstName = "Joan",
                LastName = "Teacher",
                Gender = true,
                Phone = "123123123"
            };

            var TeacherJson = JsonConvert.SerializeObject(TeacherModel);

            var TeacherContext = new StringContent(TeacherJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Teacher", TeacherContext);

            //Add subject
            var SubjectModel = new SubjectDto()
            {
                Lesson = 1,
                Class = 1,
                Teacher = 1
            };

            var SubjectJson = JsonConvert.SerializeObject(SubjectModel);

            var SubjectContext = new StringContent(SubjectJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Subject", SubjectContext);

            //Create Grade
            var model = new GradeDto()
            {
                GradeValue = 5,
                Description = "testDesc",
                Weight = 1,
                Class = 1,
                Day = 1,
                Hour = 1,
                Lesson = "Physics",
                UserUUID = Guid.NewGuid()
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            await Client.PostAsync("/api/Grade", httpContext);

            var response = await Client.DeleteAsync("/api/Grade/1");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateGrade_WithoutParams_ReturnFailRequest()
        {
            //Add lesson
            var LessonModel = new LessonDto()
            {
                Day = 1,
                Hour = 1,
                Name = "Physics"
            };

            var LessonJson = JsonConvert.SerializeObject(LessonModel);

            var LessonContext = new StringContent(LessonJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Lesson", LessonContext);

            //Add Teacher
            var TeacherModel = new TeacherDto()
            {
                Email = "teacher@teacher.com",
                FirstName = "Joan",
                LastName = "Teacher",
                Gender = true,
                Phone = "123123123"
            };

            var TeacherJson = JsonConvert.SerializeObject(TeacherModel);

            var TeacherContext = new StringContent(TeacherJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Teacher", TeacherContext);

            //Add subject
            var SubjectModel = new SubjectDto()
            {
                Lesson = 1,
                Class = 1,
                Teacher = 1
            };

            var SubjectJson = JsonConvert.SerializeObject(SubjectModel);

            var SubjectContext = new StringContent(SubjectJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Subject", SubjectContext);

            //Create Grade
            var model = new GradeDto()
            {
                
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Grade", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.InternalServerError);
        }
    }
}
