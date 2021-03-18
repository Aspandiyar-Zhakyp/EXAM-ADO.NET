using EXAM_ADO.NET.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_ADO.NET.Data
{
    public class DoctorsSchedulesContext : DbContext
    {
        public class DishesContext : DbContext
        {
            public DishesContext()
            {
                Database.Migrate();
            }
            public DbSet<Doctors> Doctors { get; set; }
            public DbSet<Direction> Directions { get; set; }
            public DbSet<Schedules> Schedules { get; set; }
            public DbSet<DoctorsSchedule> DoctorsSchedules { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=ASTCMT002/MSSQL; Database=FluentAPILesson; Trusted_Connection=true;");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<DoctorsSchedule>().ToTable("Doctors").Property(Doctors => Doctors.Id).HasColumnName("ID");
                modelBuilder.Entity<DoctorsSchedule>().ToTable("Schedule").Property(Schedules => Schedules.Id).HasColumnName("ID");

                modelBuilder.Entity<Doctors>().HasKey(Doctors => Doctors.Id);
                modelBuilder.Entity<Doctors>().Property(Doctors => Doctors.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();

                modelBuilder.Entity<Schedules>().HasKey(Schedules => Schedules.Id);

                modelBuilder.Entity<Direction>().HasOne(Directions => Directions.Doctor).WithMany(Doctors => Doctors.Directions);
                modelBuilder.Entity<Direction>().HasOne(Directions => Directions.Schedule).WithMany(Schedules => Schedules.Directions);

                base.OnModelCreating(modelBuilder);
            }
        }
    }
}
