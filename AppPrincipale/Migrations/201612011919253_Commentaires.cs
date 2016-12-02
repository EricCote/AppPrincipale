namespace AppPrincipale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Commentaires : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commentaires",
                c => new
                    {
                        CommentaireID = c.Int(nullable: false, identity: true),
                        Nom = c.String(maxLength: 50),
                        Contenu = c.String(maxLength: 1000),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CommentaireID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Commentaires");
        }
    }
}
