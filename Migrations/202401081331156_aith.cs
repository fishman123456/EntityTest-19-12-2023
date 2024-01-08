namespace EntityTest_19_12_2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aith : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.ClassAttrBs", "Abstract", c => c.String());

            //Sql("UPDATE dbo.ClassAttrBs SET Abstract = LEFT(Content, 100) WHERE Abstract IS NULL");
        }
        
        public override void Down()
        {
            //DropColumn("dbo.ClassAttrBs", "Abstract");
        }
    }
}
