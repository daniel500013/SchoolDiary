﻿using Microsoft.EntityFrameworkCore;

namespace SchoolDiary.api
{
    public class DiaryDbContext : DbContext
    {
        public DiaryDbContext(DbContextOptions<DiaryDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
