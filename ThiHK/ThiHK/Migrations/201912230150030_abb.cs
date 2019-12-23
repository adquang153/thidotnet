namespace ThiHK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LopHocs", "SiSo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LopHocs", "SiSo");
        }
    }
}
