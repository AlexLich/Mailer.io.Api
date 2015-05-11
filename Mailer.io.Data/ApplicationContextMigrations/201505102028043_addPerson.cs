namespace Mailer.io.Data.ApplicationContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPerson : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Middlename = c.String(),
                        Lastname = c.String(),
                        Phonenumber = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
