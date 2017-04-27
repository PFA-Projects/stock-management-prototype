namespace GestionMagasin.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using GestionMagasin.Classe;

    public class ModelMagazin : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « ModelMagazin » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « GestionMagasin.Model.ModelMagazin » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « ModelMagazin » dans le fichier de configuration de l'application.
        public ModelMagazin()
            : base("name=ModelMagazin")
        {
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Matriel> Matriels { get; set; }
        public virtual DbSet<Categorie_Matriel> CMatriels { get; set; }
        public virtual DbSet<Emplacement> Emplacements { get; set; }
        public virtual DbSet<Service> services { get; set; }
        public virtual DbSet<Societe> Societes { get; set; }
      

        public virtual DbSet<Livraison> Livraisons { get; set; }
        public virtual DbSet<EntrerSortieMatriel> EntreSortie { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}