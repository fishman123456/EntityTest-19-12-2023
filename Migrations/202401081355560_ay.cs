namespace EntityTest_19_12_2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ay : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.ClassAttrBs", "ClassAttrB", c => c.String());
            //UPDATE ClassAttrBs  set BlockXor ='66' where BlockXor ='' 
            // добавляем значение в пустую ячейку столбца where BlockXor
            Sql("UPDATE dbo.ClassAttrBs set BlockXor ='665' where BlockXor ='' ");
        }
        
        public override void Down()
        {
            //DropColumn("dbo.ClassAttrBs", "Abstract");
        }
    }
}
