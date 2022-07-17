using Bogus;
using Microsoft.AspNetCore.Identity;

namespace SchoolDiary.api
{
    public class DiaryDbContext : DbContext
    {
        public DiaryDbContext(DbContextOptions<DiaryDbContext> options) : base(options)
        {

        }

        public DbSet<SchoolDiary.api.Model.Person> Person { get; set; }
        public DbSet<PersonRole> PersonRole { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Parent> Parent { get; set; }
        public DbSet<PersonParent> PersonParent { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<PersonClass> PersonClass { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Mark> Mark { get; set; }
        public DbSet<LessonMark> LessonMark { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<LessonGrade> LessonGrade { get; set; }
        public DbSet<Approve> Approve { get; set; }
        public DbSet<LessonApprove> LessonApprove { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolDiary.api.Model.Person>();
            
            modelBuilder.Entity<Role>()
                .Property(x => x.Name)
                .IsRequired();

            modelBuilder.Entity<PersonRole>();

            modelBuilder.Entity<Class>();

            modelBuilder.Entity<PersonClass>();
            
            modelBuilder.Entity<Subject>();
            
            modelBuilder.Entity<Teacher>();
            
            modelBuilder.Entity<Lesson>();

            modelBuilder.Entity<Mark>();

            modelBuilder.Entity<LessonMark>();
            
            modelBuilder.Entity<Grade>();
            
            modelBuilder.Entity<LessonGrade>();

            modelBuilder.Entity<Approve>();

            modelBuilder.Entity<LessonApprove>();

            var faker = new Faker();

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
        }
    }
}
