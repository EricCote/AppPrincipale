namespace AppPrincipale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifs : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abonnements", "Nom", c => c.String(nullable: false));
            AlterColumn("dbo.Abonnements", "Courriel", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abonnements", "Courriel", c => c.String());
            AlterColumn("dbo.Abonnements", "Nom", c => c.String());
        }
    }
}
