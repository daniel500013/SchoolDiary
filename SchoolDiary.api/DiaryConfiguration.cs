using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SchoolDiary.api
{
    public class DiaryConfiguration
    {
        private readonly ModelBuilder modelBuilder;

        public DiaryConfiguration(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            var faker = new Bogus.Faker();

            Guid uuid;

            //Normal Guid List
            List<Guid> UUIDList = new List<Guid>();

            //5X Guid List
            List<Guid> UUIDList5X = new List<Guid>();

            //Person
            for (int i = 1; i < 101; i++)
            {
                faker = new Bogus.Faker();
                uuid = Guid.NewGuid();
                UUIDList.Add(uuid);

                for (int j = 0; j < 5; j++)
                {
                    UUIDList5X.Add(uuid);
                }

                modelBuilder.Entity<Person>().HasData
                (
                    new Person()
                    {
                        UserUUID = uuid,
                        Email = faker.Person.Email,
                        FirstName = faker.Person.FirstName,
                        LastName = faker.Person.LastName,
                        ZipCode = faker.Person.Address.ZipCode,
                        City = faker.Person.Address.City,
                        Address = faker.Person.Address.State,
                        Phone = faker.Person.Phone,
                        PasswordHash = ""
                    }
                );
            }

            //Role
            modelBuilder.Entity<Role>()
                .HasData(new Role()
                {
                    RoleID = 1,
                    Name = "Student"
                },
                new Role()
                {
                    RoleID = 2,
                    Name = "Parent"
                },
                new Role()
                {
                    RoleID = 3,
                    Name = "Teacher"
                },
                new Role()
                {
                    RoleID = 4,
                    Name = "Tutor"
                },
                new Role()
                {
                    RoleID = 5,
                    Name = "LocalAdmin"
                },
                new Role()
                {
                    RoleID = 6,
                    Name = "Admin"
                });

            //PersonRole
            for (int i = 1; i < 101; i++)
            {
                modelBuilder.Entity < PersonRole>().HasData
                (
                    new PersonRole()
                    {
                        PersonRoleID = i,
                        FK_RoleID = 1,
                        FK_UserUUID = UUIDList[i - 1]
                    }
                );
            }

            //Parent
            for (int i = 1; i < 101; i++)
            {
                faker = new Bogus.Faker();

                modelBuilder.Entity<Parent>().HasData
                (
                    new Parent()
                    {
                        ParentID = i,
                        Email = faker.Person.Email,
                        FirstName = faker.Person.FirstName,
                        LastName = faker.Person.LastName,
                        Phone = faker.Person.Phone
                    }
                );
            }

            //PersonParent
            for (int i = 1; i < 101; i++)
            {
                modelBuilder.Entity<PersonParent>().HasData
                (
                    new PersonParent()
                    {
                        PersonParentID = i,
                        FK_UserUUID = UUIDList[i - 1],
                        FK_ParentID = i
                    }
                );
            }

            //PersonClass
            for (int i = 1; i < 101; i++)
            {
                Random rnd = new Random();
                int RandomClass = rnd.Next(1, 10);

                modelBuilder.Entity<PersonClass>().HasData
                (
                    new PersonClass()
                    {
                        UserClassID = i,
                        FK_UserUUID = UUIDList[i - 1],
                        FK_ClassID = RandomClass
                    }
                );
            }


            //Class
            char[] ClassProfiles = "QWERTYUIOP".ToCharArray();
            
            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<Class>().HasData
                (
                    new Class()
                    {
                        ClassID = i,
                        ClassNumber = i,
                        Profile = ClassProfiles[i - 1].ToString(),
                    }
                );
            }

            //Teacher
            for (int i = 1; i < 20; i++)
            {
                faker = new Bogus.Faker();

                modelBuilder.Entity<Teacher>().HasData
                (
                    new Teacher()
                    {
                        TeacherID = i,
                        Email = faker.Person.Email,
                        FirstName = faker.Person.FirstName,
                        LastName = faker.Person.LastName,
                        Phone = faker.Person.Phone
                    }
                );
            }

            //Lesson
            List<string> lessosn = new List<string>
            {
                "Polish",
                "Math",
                "English",
                "Physics",
                "Geography",
                "PE",
                "Chemistry",
                "History"
            };

            int TwiceIteration = 0;

            for (int z = 0; z < 10; z++)
            {
                for (int i = 1; i < 6; i++)
                {
                    for (int j = 1; j < 9; j++)
                    {
                        TwiceIteration++;

                        Random rnd = new Random();

                        modelBuilder.Entity<Lesson>().HasData
                        (
                            new Lesson()
                            {
                                LessonID = TwiceIteration,
                                Day = i,
                                Hour = j,
                                Name = lessosn[rnd.Next(0, 8)]
                            }
                        );
                    }
                }
            }

            //Marks
            var MarkUUIDShuffle = UUIDList5X.OrderBy(item => new Random().Next()).ToList();
            for (int i = 1; i < 501; i++)
            {
                faker = new Bogus.Faker();

                bool present = false;

                Random rnd = new Random();
                int isPresent = rnd.Next(0, 2);
                
                if (isPresent == 1)
                {
                    present = true;
                }

                modelBuilder.Entity<Mark>().HasData
                    (
                        new Mark()
                        {
                            MarkID = i,
                            Date = DateTime.Now.Date,
                            Present = present,
                            FK_UserUUID = MarkUUIDShuffle[i-1]
                        }
                    );
            }

            //Grade
            var GradeUUIDShuffle = UUIDList5X.OrderBy(item => new Random().Next()).ToList();
            for (int i = 1; i < 501; i++)
            {
                Random rnd = new Random();
                int RandomGrade = rnd.Next(1, 7);
                int RandomWeight = rnd.Next(1, 4);

                modelBuilder.Entity<Grade>().HasData
                    (
                        new Grade()
                        {
                            GradeID = i,
                            GradeValue = RandomGrade,
                            Weight = RandomWeight,
                            Description = "",
                            FK_UserUUID = GradeUUIDShuffle[i-1]
                        }
                    );
            }

            //Approve
            var ApproveUUIDShuffle = UUIDList5X.OrderBy(item => new Random().Next()).ToList();
            for (int i = 1; i < 31; i++)
            {
                bool positive = false;

                Random rnd = new Random();
                int IsPositive = rnd.Next(0, 2);

                if (IsPositive == 1)
                {
                    positive = true;
                }

                modelBuilder.Entity<Approve>().HasData
                    (
                        new Approve()
                        {
                            ApproveID = i,
                            Positive = positive,
                            Description = "",
                            FK_UserUUID = ApproveUUIDShuffle[i - 1]
                        }
                    );
            }


            //Subject
            int ClassAssign = 1;
            for (int i = 1; i < 401; i++)
            {
                Random rnd = new Random();
                int RandomTeacher = rnd.Next(1, 19);

                if (i % 40 == 0 && ClassAssign < 10)
                {
                    ClassAssign++;
                }

                modelBuilder.Entity<Subject>().HasData
                    (
                        new Subject()
                        {
                            SubjectID = i,
                            FK_LessonID = i,
                            FK_Class = ClassAssign,
                            FK_TeacherID = RandomTeacher,
                        }
                    );
            }

            //LessonMark
            List<int> ints_lm = Enumerable.Range(1, 500).ToList();
            var lm_rnd = new Random();
            var randomized_lm = ints_lm.OrderBy(item => lm_rnd.Next()).ToList();
            for (int i = 1; i < 401; i++)
            {
                modelBuilder.Entity<LessonMark>().HasData
                    (
                        new LessonMark()
                        {
                            LessonMarkID = i,
                            FK_LessonID = i,
                            FK_MarkID = randomized_lm[i - 1]
                        }
                    );
            }

            //LessonGrade
            List<int> ints_lg = Enumerable.Range(1, 500).ToList();
            var lg_rnd = new Random();
            var randomized_lg = ints_lg.OrderBy(item => lg_rnd.Next()).ToList();
            for (int i = 1; i < 401; i++)
            {
                modelBuilder.Entity<LessonGrade>().HasData
                    (
                        new LessonGrade()
                        {
                            GradeLessonID = i,
                            FK_LessonID = i,
                            FK_GradeID = randomized_lg[i - 1],
                        }
                    );
            }

            //LessonApprove
            List<int> ints_la = Enumerable.Range(1, 30).ToList();
            var la_rnd = new Random();
            var randomized_la = ints_la.OrderBy(item => la_rnd.Next()).ToList();
            for (int i = 1; i < 31; i++)
            {
                modelBuilder.Entity<LessonApprove>().HasData
                    (
                        new LessonApprove()
                        {
                            LessonApproveID = i,
                            FK_LessonID = i,
                            FK_ApproveID = randomized_la[i - 1],
                        }
                    );
            }
        }
    }
}
