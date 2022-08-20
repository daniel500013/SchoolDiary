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
