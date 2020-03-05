namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createStudent1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student1",
                c => new
                    {
                        SId = c.Int(nullable: false, identity: true),
                        SName = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.SId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student1");
        }
    }
}
