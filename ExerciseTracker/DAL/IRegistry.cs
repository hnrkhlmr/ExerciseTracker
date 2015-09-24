using ExerciseTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseTracker.DAL
{
    public interface IRegistry
    {
        IEnumerable<Workout> GetWorkouts();
        IEnumerable<Workout> GetWorkoutByDates(DateTime from, DateTime to);
        Workout GetWorkoutById(Guid id);
        void CreateOrUpdateWorkout(Workout workout);
        void DeleteWorkout(Guid id);
    }
}
