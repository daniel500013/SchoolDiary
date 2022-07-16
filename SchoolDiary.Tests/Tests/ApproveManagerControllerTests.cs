﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDiary.Tests.Tests
{
    public class ApproveManagerControllerTests
    {
        private HttpClient Client { get; set; }

        public ApproveManagerControllerTests()
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
        public async Task GetLessonApproves_WithoutParams_ReturnOkRequest()
        {
            var response = await Client.GetAsync("/api/ApproveManager");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }
    }
}
