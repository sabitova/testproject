namespace TeamSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Buyer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buyers", t => t.Buyer_Id)
                .Index(t => t.Buyer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Buyer_Id", "dbo.Buyers");
            DropIndex("dbo.Items", new[] { "Buyer_Id" });
            DropTable("dbo.Items");
            DropTable("dbo.Buyers");
        }
    }
}
