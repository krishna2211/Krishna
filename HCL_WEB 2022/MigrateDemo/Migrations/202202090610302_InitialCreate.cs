namespace MigrateDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        modelNo = c.Int(nullable: false, identity: true),
                        CarModel = c.String(),
                    })
                .PrimaryKey(t => t.modelNo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
