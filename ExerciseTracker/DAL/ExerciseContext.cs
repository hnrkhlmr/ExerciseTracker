using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ExerciseTracker.Models;

namespace ExerciseTracker.DAL
{
    public class ExerciseContext : DbContext
    {
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<Set> Sets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Workout>()
                .H;

            //modelBuilder.Entity<ApplicationUser>()
            //    .HasMany(u => u.Assignments).WithRequired(i => i.AssignedTo);

            base.OnModelCreating(modelBuilder);
        }
    }
}