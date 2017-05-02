namespace GestionMagasin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorie_Matriel",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Emplacements",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                        service_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Services", t => t.service_id)
                .Index(t => t.service_id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Observation = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Livraisons",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        Marcher = c.String(),
                        NumeroBonLivraison = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Matriels",
                c => new
                    {
                        NumeroInvontaire = c.String(nullable: false, maxLength: 128),
                        Designation = c.String(),
                        Model = c.String(),
                        Numero_Serie = c.String(),
                        DateMiseService = c.DateTime(nullable: false),
                        Observation = c.String(),
                        acquisition = c.Single(nullable: false),
                        valeurAcquisition = c.String(),
                        IsValeurAcquisitionExist = c.Boolean(nullable: false),
                        EtatPhysique = c.String(),
                        IsExistStok = c.Boolean(nullable: false),
                        Dimension = c.Int(nullable: false),
                        Numero_INN = c.String(),
                        categorie_id = c.Int(),
                    })
                .PrimaryKey(t => t.NumeroInvontaire)
                .ForeignKey("dbo.Categorie_Matriel", t => t.categorie_id)
                .Index(t => t.categorie_id);
            
            CreateTable(
                "dbo.Societes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NomSociete = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matriels", "categorie_id", "dbo.Categorie_Matriel");
            DropForeignKey("dbo.Emplacements", "service_id", "dbo.Services");
            DropIndex("dbo.Matriels", new[] { "categorie_id" });
            DropIndex("dbo.Emplacements", new[] { "service_id" });
            DropTable("dbo.Societes");
            DropTable("dbo.Matriels");
            DropTable("dbo.Livraisons");
            DropTable("dbo.Services");
            DropTable("dbo.Emplacements");
            DropTable("dbo.Categorie_Matriel");
        }
    }
}
