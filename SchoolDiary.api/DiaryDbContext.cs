﻿using Microsoft.AspNetCore.Identity;

namespace SchoolDiary.api
{
    public class DiaryDbContext : DbContext
    {
        public DiaryDbContext(DbContextOptions<DiaryDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
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
            new DiaryConfiguration(modelBuilder).Seed();
        }
    }
}
