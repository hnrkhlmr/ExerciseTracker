using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExerciseTracker.Models
{
    public class WorkoutExercise
    {
        public Guid Id { get; set; }
        public Exercise Exercise { get; set; }
        //public IEnumerable<Set> Sets { get; set; }
        public ICollection<Set> Sets { get; set; }
    }
}