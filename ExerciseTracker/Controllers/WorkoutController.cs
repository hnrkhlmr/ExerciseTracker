using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExerciseTracker.Models;
using ExerciseTracker.DAL;

namespace ExerciseTracker.Controllers
{
    public class WorkoutController : Controller
    {
        private IRegistry _registry;

        public WorkoutController(IRegistry registry)
        {
            _registry = registry;
        }
        //
        // GET: /Workout/

        public ActionResult Index()
        {
            return View(_registry.GetWorkouts());
        }

        //
        // GET: /Workout/Details/5

        public ActionResult Details(Guid id)
        {
            Workout workout = _registry.GetWorkoutById(id);
            if (workout == null)
            {
                return HttpNotFound();
            }
            return View(workout);
        }

        //
        // GET: /Workout/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Workout/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Workout workout)
        {
            if (ModelState.IsValid)
            {
                //workout.Id = Guid.NewGuid();
                _registry.CreateOrUpdateWorkout(workout);
                return RedirectToAction("Index");
            }

            return View(workout);
        }

        //
        // GET: /Workout/Edit/5

        public ActionResult Edit(Guid id)
        {
            Workout workout = _registry.GetWorkoutById(id);
            if (workout == null)
            {
                return HttpNotFound();
            }
            return View(workout);
        }

        //
        // POST: /Workout/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Workout workout)
        {
            if (ModelState.IsValid)
            {
                _registry.CreateOrUpdateWorkout(workout);
                return RedirectToAction("Index");
            }
            return View(workout);
        }

        //
        // GET: /Workout/Delete/5

        public ActionResult Delete(Guid id)
        {
            Workout workout = _registry.GetWorkoutById(id);
            if (workout == null)
            {
                return HttpNotFound();
            }
            return View(workout);
        }

        //
        // POST: /Workout/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _registry.DeleteWorkout(id);
            return RedirectToAction("Index");
        }        
    }
}