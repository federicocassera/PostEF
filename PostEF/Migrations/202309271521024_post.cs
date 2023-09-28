namespace PostEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class post : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Posts");        
            DropColumn("dbo.Posts", "Id");
            AddColumn("dbo.Posts", "codice", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Posts", "codice");
    
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Posts");
            DropColumn("dbo.Posts", "codice");
            AddPrimaryKey("dbo.Posts", "Id");
        }
    }
}
