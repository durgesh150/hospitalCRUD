namespace hospitalCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class con : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appusers", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Appusers", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Appusers", "Username", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Appusers", "password", c => c.String(nullable: false, maxLength: 25));
            CreateIndex("dbo.Appusers", "Username", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Appusers", new[] { "Username" });
            AlterColumn("dbo.Appusers", "password", c => c.String());
            AlterColumn("dbo.Appusers", "Username", c => c.String());
            AlterColumn("dbo.Appusers", "LastName", c => c.String());
            AlterColumn("dbo.Appusers", "FirstName", c => c.String());
        }
    }
}
