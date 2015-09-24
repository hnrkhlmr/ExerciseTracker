namespace ExerciseTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Workout",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Duration = c.Time(nullable: false),
                        Date = c.DateTime(nullable: false),
                        WorkoutType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Workout");
        }
    }
}
