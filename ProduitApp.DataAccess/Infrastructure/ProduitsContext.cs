using ProduitApp.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduitApp.DataAccess.Infrastructure
{
    class ProduitsContext : DbContext
    {
        public ProduitsContext() : base("name=MyDB")  
            
            {

             }

        public DbSet<Produit> Produits { get; set; }
    }
}
