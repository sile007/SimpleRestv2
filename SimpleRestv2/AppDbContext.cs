﻿using Microsoft.EntityFrameworkCore;

namespace SimpleRestv2
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
