namespace SNMManagement.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Email_Mahatma : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mahatmas", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mahatmas", "Email");
        }
    }
}
