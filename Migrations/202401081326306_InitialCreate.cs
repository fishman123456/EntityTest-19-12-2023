namespace EntityTest_19_12_2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassAttrBs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        BlockHandle = c.String(),
                        BlockName = c.String(),
                        BlockAttrVal = c.String(),
                        BlockX = c.String(),
                        BlockY = c.String(),
                        BlockZ = c.String(),
                        BlockLayer = c.String(),
                        BlockXor = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClassAttrBs");
        }
    }
}
