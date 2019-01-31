namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Date_Birth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "DateOfBirth");
        }
    }
}
