namespace CodeFirstDomain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deliveryaddrss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeliveryAddresses",
                c => new
                    {
                        DevliverAddressID = c.Int(nullable: false, identity: true),
                        NickName = c.String(),
                        DeliveryAddressPostCode = c.String(),
                    })
                .PrimaryKey(t => t.DevliverAddressID);
            
            AddColumn("dbo.Addresses", "DeliverAddress_DevliverAddressID", c => c.Int());
            CreateIndex("dbo.Addresses", "DeliverAddress_DevliverAddressID");
            AddForeignKey("dbo.Addresses", "DeliverAddress_DevliverAddressID", "dbo.DeliveryAddresses", "DevliverAddressID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "DeliverAddress_DevliverAddressID", "dbo.DeliveryAddresses");
            DropIndex("dbo.Addresses", new[] { "DeliverAddress_DevliverAddressID" });
            DropColumn("dbo.Addresses", "DeliverAddress_DevliverAddressID");
            DropTable("dbo.DeliveryAddresses");
        }
    }
}
