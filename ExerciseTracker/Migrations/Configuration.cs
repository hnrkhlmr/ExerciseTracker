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
            var exercises = new List<Exercise>
            {
                new Exercise { Id = Guid.NewGuid(), Name = "Sit-up", Target = "Mage", Description = "Ligg på rygg, lyft upp benen, 90 grader i höft och knäled. Lyft överkroppen med magmusklerna." },
                new Exercise { Id = Guid.NewGuid(), Name = "Benlyft", Target = "Mage", Description = "Ligg på rygg. Lyft upp benen rak till ca 70 grader. Landa inte med fötterna i nederläget, stanna några centimeter ovanför." },
                new Exercise { Id = Guid.NewGuid(), Name = "Armhävning", Target = "Bröst", Description = "Händerna i golvet lite bredare än axelbrett. Kroppen rak." }
            };

            exercises.ForEach(e => context.Exercises.AddOrUpdate(p => p.Id, e));
            context.SaveChanges();

            var workout = new Workout
            {
                Date = DateTime.Now.AddDays(-15),
                Duration = DateTime.Now - DateTime.Now.AddHours(-1),
                Id = Guid.NewGuid(),
                WorkoutType = "Styrketräning"
            };

            context.Workouts.Add(workout);
            var workoutExercises = new List<WorkoutExercise> { 
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[0], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[1], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },                                
                    };

            var workouts = new List<Workout>
            {
                new Workout { Date = DateTime.Now.AddDays(-15), 
                    Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
                    Id = Guid.NewGuid(), 
                    WorkoutType = "Styrketräning",
                    Exercises = { 
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[0], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[1], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },                                
                    }
                },
                new Workout { Date = DateTime.Now.AddDays(-13), 
                    Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
                    Id = Guid.NewGuid(), 
                    WorkoutType = "Styrketräning",
                    Exercises = { 
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[0], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[1], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },                                
                    }
                 },
                new Workout { Date = DateTime.Now.AddDays(-10), 
                    Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
                    Id = Guid.NewGuid(), 
                    WorkoutType = "Styrketräning",
                    Exercises = { 
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[0], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[1], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },                                
                    }
                 },
                new Workout { Date = DateTime.Now.AddDays(-8), 
                    Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
                    Id = Guid.NewGuid(), 
                    WorkoutType = "Styrketräning",
                    Exercises = { 
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[0], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[1], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },                                
                    }
                 },
                new Workout { Date = DateTime.Now.AddDays(-7), 
                    Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
                    Id = Guid.NewGuid(), 
                    WorkoutType = "Styrketräning",
                    Exercises = { 
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[0], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[1], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },                                
                    }
                 },
                new Workout { Date = DateTime.Now.AddDays(-6), 
                    Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
                    Id = Guid.NewGuid(), 
                    WorkoutType = "Styrketräning",
                    Exercises = { 
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[0], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[1], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },                                
                    }
                 },
                new Workout { Date = DateTime.Now.AddDays(-4), 
                    Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
                    Id = Guid.NewGuid(), 
                    WorkoutType = "Styrketräning",
                    Exercises = { 
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[0], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[1], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },                                
                    }
                 },
                new Workout { Date = DateTime.Now.AddDays(-3), 
                    Duration = DateTime.Now - DateTime.Now.AddHours(-1), 
                    Id = Guid.NewGuid(), 
                    WorkoutType = "Styrketräning",
                    Exercises = { 
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[0], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },
                        new WorkoutExercise { Id = Guid.NewGuid(), 
                            Exercise = exercises[1], 
                            Sets = { new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 },
                                    new Set { Id = Guid.NewGuid(), Reps = 20, Weight = 0 }
                                }
                        },                                
                    }
                 }
                
            };

            workouts.ForEach(w => context.Workouts.AddOrUpdate(p => p.Id, w));
            context.SaveChanges();
        }
    }
}
