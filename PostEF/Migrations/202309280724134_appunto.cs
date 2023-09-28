namespace PostEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class appunto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "appunto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "appunto");
        }
    }
}
