using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDiary.Tests.Tests
{
    public class ApproveControllerTests
    {
        private HttpClient Client { get; }

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
            //Add lesson
            var lessonModel = new LessonDto()
            {
                Day = 1,
                Hour = 1,
                Name = "Physics"
            };

            var lessonJson = JsonConvert.SerializeObject(lessonModel);

            var lessonContext = new StringContent(lessonJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Lesson", lessonContext);

            //Add Teacher
            var teacherModel = new TeacherDto()
            {
                Email = "teacher@teacher.com",
                FirstName = "Joan",
                LastName = "Teacher",
                Gender = true,
                Phone = "123123123"
            };

            var teacherJson = JsonConvert.SerializeObject(teacherModel);

            var teacherContext = new StringContent(teacherJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Teacher", teacherContext);

            //Add subject
            var subjectModel = new SubjectDto()
            {
                Lesson = 1,
                Class = 1,
                Teacher = 1
            };

            var subjectJson = JsonConvert.SerializeObject(subjectModel);

            var subjectContext = new StringContent(subjectJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Subject", subjectContext);

            //Add approve
            var model = new ApproveDto()
            {
                Positive = true,
                Description = "desc",
                Class = 1,
                Day = 1,
                Hour = 1,
                Lesson = "Physics",
                UserUUID = Guid.NewGuid()
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Approve", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task ChangeApprove_WithoutParams_ReturnOkRequest()
        {
            //Add lesson
            var lessonModel = new LessonDto()
            {
                Day = 1,
                Hour = 1,
                Name = "Physics"
            };

            var lessonJson = JsonConvert.SerializeObject(lessonModel);

            var lessonContext = new StringContent(lessonJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Lesson", lessonContext);

            //Add Teacher
            var teacherModel = new TeacherDto()
            {
                Email = "teacher@teacher.com",
                FirstName = "Joan",
                LastName = "Teacher",
                Gender = true,
                Phone = "123123123"
            };

            var teacherJson = JsonConvert.SerializeObject(teacherModel);

            var teacherContext = new StringContent(teacherJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Teacher", teacherContext);

            //Add subject
            var subjectModel = new SubjectDto()
            {
                Lesson = 1,
                Class = 1,
                Teacher = 1
            };

            var subjectJson = JsonConvert.SerializeObject(subjectModel);

            var subjectContext = new StringContent(subjectJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Subject", subjectContext);

            //Change Approve
            var model = new ApproveDto()
            {
                Positive = true,
                Description = "desc",
                Class = 1,
                Day = 1,
                Hour = 1,
                Lesson = "Physics",
                UserUUID = Guid.NewGuid()
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            await Client.PostAsync("/api/Approve", httpContext);

            var modelToChange = new ApproveDto()
            {
                Positive = false,
                Description = "csed",
                Class = 1,
                Day = 1,
                Hour = 1,
                Lesson = "Physics",
                UserUUID = Guid.NewGuid()
            };

            var jsonToChange = JsonConvert.SerializeObject(modelToChange);
            var httpContextToChange = new StringContent(jsonToChange, Encoding.UTF8, "application/json");
            var response = await Client.PutAsync("/api/Approve/1", httpContextToChange);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task RemoveApprove_WithoutParams_ReturnOkRequest()
        {
            //Add lesson
            var lessonModel = new LessonDto()
            {
                Day = 1,
                Hour = 1,
                Name = "Physics"
            };

            var lessonJson = JsonConvert.SerializeObject(lessonModel);

            var lessonContext = new StringContent(lessonJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Lesson", lessonContext);

            //Add Teacher
            var teacherModel = new TeacherDto()
            {
                Email = "teacher@teacher.com",
                FirstName = "Joan",
                LastName = "Teacher",
                Gender = true,
                Phone = "123123123"
            };

            var teacherJson = JsonConvert.SerializeObject(teacherModel);

            var teacherContext = new StringContent(teacherJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Teacher", teacherContext);

            //Add subject
            var subjectModel = new SubjectDto()
            {
                Lesson = 1,
                Class = 1,
                Teacher = 1
            };

            var subjectJson = JsonConvert.SerializeObject(subjectModel);

            var subjectContext = new StringContent(subjectJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Subject", subjectContext);
            
            //Add Approve
            var model = new ApproveDto()
            {
                Positive = true,
                Description = "desc",
                Class = 1,
                Day = 1,
                Hour = 1,
                Lesson = "Physics",
                UserUUID = Guid.NewGuid()
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            await Client.PostAsync("/api/Approve", httpContext);

            //Remove Approve
            var response = await Client.DeleteAsync("/api/Approve/1");
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task CreateApprove_WithoutParams_ReturnFailRequest()
        {
            //Add lesson
            var lessonModel = new LessonDto()
            {
                Day = 1,
                Hour = 1,
                Name = "Physics"
            };

            var lessonJson = JsonConvert.SerializeObject(lessonModel);

            var lessonContext = new StringContent(lessonJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Lesson", lessonContext);

            //Add Teacher
            var teacherModel = new TeacherDto()
            {
                Email = "teacher@teacher.com",
                FirstName = "Joan",
                LastName = "Teacher",
                Gender = true,
                Phone = "123123123"
            };

            var teacherJson = JsonConvert.SerializeObject(teacherModel);

            var teacherContext = new StringContent(teacherJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Teacher", teacherContext);

            //Add subject
            var subjectModel = new SubjectDto()
            {
                Lesson = 1,
                Class = 1,
                Teacher = 1
            };

            var subjectJson = JsonConvert.SerializeObject(subjectModel);

            var subjectContext = new StringContent(subjectJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Subject", subjectContext);

            //Add approve
            var model = new ApproveDto()
            {
                Positive = true,
                Description = "desc"
            };

            var json = JsonConvert.SerializeObject(model);

            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync("/api/Approve", httpContext);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.InternalServerError);
        }

        [Fact]
        public async Task ChangeApprove_WithoutParams_ReturnFailRequest()
        {
            //Add lesson
            var lessonModel = new LessonDto()
            {
                Day = 1,
                Hour = 1,
                Name = "Physics"
            };

            var lessonJson = JsonConvert.SerializeObject(lessonModel);

            var lessonContext = new StringContent(lessonJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Lesson", lessonContext);

            //Add Teacher
            var teacherModel = new TeacherDto()
            {
                Email = "teacher@teacher.com",
                FirstName = "Joan",
                LastName = "Teacher",
                Gender = true,
                Phone = "123123123"
            };

            var teacherJson = JsonConvert.SerializeObject(teacherModel);

            var teacherContext = new StringContent(teacherJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Teacher", teacherContext);

            //Add subject
            var subjectModel = new SubjectDto()
            {
                Lesson = 1,
                Class = 1,
                Teacher = 1
            };

            var subjectJson = JsonConvert.SerializeObject(subjectModel);

            var subjectContext = new StringContent(subjectJson, Encoding.UTF8, "application/json");

            await Client.PostAsync("/api/Subject", subjectContext);

            //Change Approve
            var model = new ApproveDto()
            {
                Positive = true,
                Description = "desc",
                Class = 1,
                Day = 1,
                Hour = 1,
                Lesson = "Physics",
                UserUUID = Guid.NewGuid()
            };

            var json = JsonConvert.SerializeObject(model);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            await Client.PostAsync("/api/Approve", httpContext);

            var jsonToChange = JsonConvert.SerializeObject(null);
            var httpContextToChange = new StringContent(jsonToChange, Encoding.UTF8, "application/json");
            var response = await Client.PutAsync("/api/Approve/1", httpContextToChange);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
        }
    }
}
