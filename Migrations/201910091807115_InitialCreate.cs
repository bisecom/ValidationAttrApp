namespace ValidationAttrApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        SecondName = c.String(nullable: false),
                        PassportId = c.String(nullable: false),
                        Birthdate = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Email = c.String(),
                        Password = c.String(maxLength: 10),
                        ConfirmPassword = c.String(nullable: false),
                        EnterenceYear = c.String(maxLength: 4),
                        GroupDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
