namespace MigrateDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationForColorInCar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "color", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "color");
        }
    }
}
