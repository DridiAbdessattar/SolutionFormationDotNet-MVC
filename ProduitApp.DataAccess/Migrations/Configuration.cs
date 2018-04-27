namespace ProduitApp.DataAccess.Migrations
{
    using ProduitApp.DataAccess.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProduitApp.DataAccess.Infrastructure.ProduitsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProduitApp.DataAccess.Infrastructure.ProduitsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Produits.AddOrUpdate(new Produit { Id = "P100", Libelle = "Produit1", PrixUnitaire = 100M });
            context.Produits.AddOrUpdate(new Produit { Id = "P200", Libelle = "Produit2", PrixUnitaire = 100M });
            context.Produits.AddOrUpdate(new Produit { Id = "P300", Libelle = "Produit3", PrixUnitaire = 100M });
        }
    }
}
