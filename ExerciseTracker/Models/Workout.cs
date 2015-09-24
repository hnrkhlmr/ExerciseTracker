using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExerciseTracker.Models
{
    public class Workout
    {
        public Guid Id { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime Date { get; set; }
        public string WorkoutType { get; set; }
        //public IEnumerable<WorkoutExercise> Exercises { get; set; }
        public ICollection<WorkoutExercise> Exercises { get; set; }
    }
}