namespace ExerciseTracker.Migrations
{
    using ExerciseTracker.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExerciseTracker.DAL.ExerciseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;            
        }

        protected override void Seed(ExerciseTracker.DAL.ExerciseContext context)
        {
            var guidEx1 = Guid.Parse("08b2ca9e-6457-439d-b533-c5cf09981c19");
            var guidEx2 = Guid.Parse("9d615178-c075-4569-836d-086a571d45c2");
            var guidEx3 = Guid.Parse("baff4ca2-3b9f-41f6-a205-c1573ba8d8ab");
            
            var exercises = new List<Exercise>
            {
                new Exercise { Id = guidEx1, Name = "Sit-up", Target = "Mage", Description = "Ligg på rygg, lyft upp benen, 90 grader i höft och knäled. Lyft överkroppen med magmusklerna." },
                new Exercise { Id = guidEx2, Name = "Benlyft", Target = "Mage", Description = "Ligg på rygg. Lyft upp benen rak till ca 70 grader. Landa inte med fötterna i nederläget, stanna några centimeter ovanför." },
                new Exercise { Id = guidEx3, Name = "Armhävning", Target = "Bröst", Description = "Händerna i golvet lite bredare än axelbrett. Kroppen rak." }
            };

            exercises.ForEach(e => context.Exercises.AddOrUpdate(p => p.Id, e));
            context.SaveChanges();            

            var guidWorkout = Guid.Parse("a348489d-f118-4814-8cbb-095dfddceeaf");

            var workout = new Workout
            {
                Date = DateTime.Now.AddDays(-15),
                Duration = DateTime.Now - DateTime.Now.AddHours(-1),
                Id = guidWorkout,
                WorkoutType = "Styrketräning"
            };

            context.Workouts.AddOrUpdate(w => w.Id, workout);
            context.SaveChanges();

            var guidWorkoutExercise = Guid.Parse("516aa327-23fd-42fc-b8c3-786860adf123");

            var workoutExercise = new WorkoutExercise
                {
                    Id = guidWorkoutExercise,
                    WorkoutId = workout.Id,
                    ExerciseId = exercises[0].Id
                };

            context.WorkoutExercises.AddOrUpdate(we => we.Id, workoutExercise);
            context.SaveChanges();

            var guidSet1 = Guid.Parse("99ed53db-c57e-4df4-b7cf-51c594364920");
            var guidSet2 = Guid.Parse("e76ecf57-d15d-469f-81e9-ed9f4fb44b0c");
            var guidSet3 = Guid.Parse("c23865ec-e6fe-457b-a294-41a471b3df54");
            
            var sets1 = new List<Set>
            {
                new Set { Id = guidSet1, Reps = 20, Weight = 0, WorkoutExerciseId = workoutExercise.Id },
                new Set { Id = guidSet2, Reps = 20, Weight = 0, WorkoutExerciseId = workoutExercise.Id },
                new Set { Id = guidSet3, Reps = 20, Weight = 0, WorkoutExerciseId = workoutExercise.Id }
            };

            sets1.ForEach(s => context.Sets.AddOrUpdate(p => p.Id, s));
            context.SaveChanges();
                      


            //Exercises = { 
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[0], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[1], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },                                
            //        }

            //var workouts = new List<Workout>
            //{
            //    new Workout { Date = DateTime.Now.AddDays(-15), 
            //        Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
            //        Id = Guid.NewGuid(), 
            //        WorkoutType = "Styrketräning",
            //        Exercises = { 
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[0], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[1], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },                                
            //        }
            //    },
            //    new Workout { Date = DateTime.Now.AddDays(-13), 
            //        Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
            //        Id = Guid.NewGuid(), 
            //        WorkoutType = "Styrketräning",
            //        Exercises = { 
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[0], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[1], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },                                
            //        }
            //     },
            //    new Workout { Date = DateTime.Now.AddDays(-10), 
            //        Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
            //        Id = Guid.NewGuid(), 
            //        WorkoutType = "Styrketräning",
            //        Exercises = { 
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[0], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[1], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },                                
            //        }
            //     },
            //    new Workout { Date = DateTime.Now.AddDays(-8), 
            //        Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
            //        Id = Guid.NewGuid(), 
            //        WorkoutType = "Styrketräning",
            //        Exercises = { 
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[0], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[1], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },                                
            //        }
            //     },
            //    new Workout { Date = DateTime.Now.AddDays(-7), 
            //        Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
            //        Id = Guid.NewGuid(), 
            //        WorkoutType = "Styrketräning",
            //        Exercises = { 
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[0], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[1], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },                                
            //        }
            //     },
            //    new Workout { Date = DateTime.Now.AddDays(-6), 
            //        Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
            //        Id = Guid.NewGuid(), 
            //        WorkoutType = "Styrketräning",
            //        Exercises = { 
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[0], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[1], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },                                
            //        }
            //     },
            //    new Workout { Date = DateTime.Now.AddDays(-4), 
            //        Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
            //        Id = Guid.NewGuid(), 
            //        WorkoutType = "Styrketräning",
            //        Exercises = { 
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[0], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[1], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },                                
            //        }
            //     },
            //    new Workout { Date = DateTime.Now.AddDays(-3), 
            //        Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
            //        Id = Guid.NewGuid(), 
            //        WorkoutType = "Styrketräning",
            //        Exercises = { 
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[0], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },
            //            new WorkoutExercise { Id = Guid.NewGuid(), 
            //                Exercise = exercises[1], 
            //                Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
            //                        new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
            //                    }
            //            },                                
            //        }
            //     }
                
            //};

            //workouts.ForEach(w => context.Workouts.AddOrUpdate(p => p.Id, w));
            //context.SaveChanges();
        }
    }
}
