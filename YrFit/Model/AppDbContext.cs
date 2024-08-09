using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrFit.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Action> Actions { get; set; }
        public DbSet<Training> Trainings { get; set; }
       
        public DbSet<TrainingUser> TrainingsUser { get; set; }
       public DbSet<MediaTraining> MediaTraining { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Training>()
                .HasMany(t => t.Users)
                .WithMany(u => u.Trainings)
                .UsingEntity<TrainingUser>(
                    j => j.HasOne(tu => tu.User).WithMany(),
                    j => j.HasOne(tu => tu.Training).WithMany())
                .Property(j => j.AttendanceDate)
                .HasDefaultValueSql("GETDATE()");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=YourFit;Integrated Security=True;TrustServerCertificate=true;");
        }

    }
}
