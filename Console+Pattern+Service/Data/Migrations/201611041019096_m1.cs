namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inboxes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
            DropTable("dbo.Inboxes");
        }
    }
}
