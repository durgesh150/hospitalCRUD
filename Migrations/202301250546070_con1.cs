namespace hospitalCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class con1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appusers", "Isadmin", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Appusers", "password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Appusers", "password", c => c.String(nullable: false, maxLength: 25));
            DropColumn("dbo.Appusers", "Isadmin");
        }
    }
}
