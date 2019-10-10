namespace ValidationAttrApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "EnterenceYear", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "EnterenceYear", c => c.String(maxLength: 4));
        }
    }
}
