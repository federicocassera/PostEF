namespace PostEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Login = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Login);
            
            AddColumn("dbo.Posts", "author", c => c.String(maxLength: 128));
            CreateIndex("dbo.Posts", "author"); //crea indice siccome campo foreign key
            AddForeignKey("dbo.Posts", "author", "dbo.Users", "Login");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "author", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "author" });
            DropColumn("dbo.Posts", "author");
            DropTable("dbo.Users");
        }
    }
}
