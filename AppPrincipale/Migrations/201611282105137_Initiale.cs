namespace AppPrincipale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initiale : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abonnements",
                c => new
                    {
                        AbonnementID = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Courriel = c.String(),
                        Actif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AbonnementID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abonnements");
        }
    }
}
