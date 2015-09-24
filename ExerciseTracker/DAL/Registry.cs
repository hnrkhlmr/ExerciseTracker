using ExerciseTracker.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ExerciseTracker.DAL
{
    public class Registry:IRegistry
    {
        private ExerciseContext _context;

        public Registry(ExerciseContext context)
        {
            _context = context;
        }

        public IEnumerable<Workout> GetWorkouts()
        {
            return _context.Workouts.ToList();
        }

        public IEnumerable<Workout> GetWorkoutByDates(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }


        public Workout GetWorkoutById(Guid id)
        {
            return _context.Workouts.Find(id);
        }


        public void CreateOrUpdateWorkout(Workout workout)
        {
            if (workout.Id.Equals(Guid.Empty))
            {
                //create
                _context.Entry(workout).State = EntityState.Added;
                _context.SaveChanges();
            }
            else
            {
                //update
                _context.Entry(workout).State = EntityState.Modified;
                _context.SaveChanges();
            }
            
        }

        public void DeleteWorkout(Guid id)
        {
            Workout workout = _context.Workouts.Find(id);
            _context.Workouts.Remove(workout);
            _context.SaveChanges();
        }

        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}