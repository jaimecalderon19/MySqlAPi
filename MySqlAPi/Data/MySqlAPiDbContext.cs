using Microsoft.EntityFrameworkCore;
using MySqlAPi.Models;
using MySQL.Data.EntityFrameworkCore;

namespace MySqlAPi.Data
{
    public class MyApiDbContext : DbContext
    {
        public MyApiDbContext(DbContextOptions<MyApiDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TaskAssignment> TaskAssignments { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Task>().HasKey(t => t.Id);
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<TaskAssignment>().HasKey(ta => ta.Id);
            modelBuilder.Entity<Comment>().HasKey(c => c.Id);
        }
    }
}