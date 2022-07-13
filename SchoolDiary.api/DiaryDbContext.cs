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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>();
            
            modelBuilder.Entity<Role>()
                .Property(x => x.Name)
                .IsRequired();

            modelBuilder.Entity<PersonRole>();

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
