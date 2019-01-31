namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cliente_MembershipType_Relation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "MembershipTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clientes", "MembershipTypeId");
            AddForeignKey("dbo.Clientes", "MembershipTypeId", "dbo.MembershipTypes", "MembershipTypeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Clientes", new[] { "MembershipTypeId" });
            DropColumn("dbo.Clientes", "MembershipTypeId");
        }
    }
}
