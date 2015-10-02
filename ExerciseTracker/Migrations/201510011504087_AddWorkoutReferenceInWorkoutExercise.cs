namespace ExerciseTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWorkoutReferenceInWorkoutExercise : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WorkoutExercise", "Workout_Id", "dbo.Workout");
            DropIndex("dbo.WorkoutExercise", new[] { "Workout_Id" });
            RenameColumn(table: "dbo.WorkoutExercise", name: "Workout_Id", newName: "WorkoutId");
            AddForeignKey("dbo.WorkoutExercise", "WorkoutId", "dbo.Workout", "Id", cascadeDelete: true);
            CreateIndex("dbo.WorkoutExercise", "WorkoutId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.WorkoutExercise", new[] { "WorkoutId" });
            DropForeignKey("dbo.WorkoutExercise", "WorkoutId", "dbo.Workout");
            RenameColumn(table: "dbo.WorkoutExercise", name: "WorkoutId", newName: "Workout_Id");
            CreateIndex("dbo.WorkoutExercise", "Workout_Id");
            AddForeignKey("dbo.WorkoutExercise", "Workout_Id", "dbo.Workout", "Id");
        }
    }
}
