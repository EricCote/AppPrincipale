namespace AppPrincipale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajoutNAS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abonnements", "Nas", c => c.String());
            AlterColumn("dbo.Abonnements", "Courriel", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abonnements", "Courriel", c => c.String(nullable: false));
            DropColumn("dbo.Abonnements", "Nas");
        }
    }
}















