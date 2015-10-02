namespace ExerciseTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WorkoutExercise", "Exercise_Id", "dbo.Exercise");
            DropForeignKey("dbo.Set", "WorkoutExercise_Id", "dbo.WorkoutExercise");
            DropIndex("dbo.WorkoutExercise", new[] { "Exercise_Id" });
            DropIndex("dbo.Set", new[] { "WorkoutExercise_Id" });
            RenameColumn(table: "dbo.WorkoutExercise", name: "Exercise_Id", newName: "ExerciseId");
            RenameColumn(table: "dbo.Set", name: "WorkoutExercise_Id", newName: "WorkoutExerciseId");
            AddForeignKey("dbo.WorkoutExercise", "ExerciseId", "dbo.Exercise", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Set", "WorkoutExerciseId", "dbo.WorkoutExercise", "Id", cascadeDelete: true);
            CreateIndex("dbo.WorkoutExercise", "ExerciseId");
            CreateIndex("dbo.Set", "WorkoutExerciseId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Set", new[] { "WorkoutExerciseId" });
            DropIndex("dbo.WorkoutExercise", new[] { "ExerciseId" });
            DropForeignKey("dbo.Set", "WorkoutExerciseId", "dbo.WorkoutExercise");
            DropForeignKey("dbo.WorkoutExercise", "ExerciseId", "dbo.Exercise");
            RenameColumn(table: "dbo.Set", name: "WorkoutExerciseId", newName: "WorkoutExercise_Id");
            RenameColumn(table: "dbo.WorkoutExercise", name: "ExerciseId", newName: "Exercise_Id");
            CreateIndex("dbo.Set", "WorkoutExercise_Id");
            CreateIndex("dbo.WorkoutExercise", "Exercise_Id");
            AddForeignKey("dbo.Set", "WorkoutExercise_Id", "dbo.WorkoutExercise", "Id");
            AddForeignKey("dbo.WorkoutExercise", "Exercise_Id", "dbo.Exercise", "Id");
        }
    }
}
