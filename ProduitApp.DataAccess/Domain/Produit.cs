using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduitApp.DataAccess.Domain
{
   public class Produit
    {
        public string Id { get; set; }
        public string Libelle { get; set; }
        public decimal PrixUnitaire { get; set; }

    }
}
