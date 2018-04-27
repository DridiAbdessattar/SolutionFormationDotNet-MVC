using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProduitApp.DataAccess.Domain;
using ProduitApp.DataAccess.Infrastructure;

namespace ProduitApp.DataAccess.Repository
{
    public class ProduitsRepositoryImpl : IProduitsRepository
    {
        public void Creation(Produit p)
        {
            using (var ctxt = new ProduitsContext())
            {
                ctxt.Produits.Add(p);
                ctxt.SaveChanges();
            }
        }

        public void delete(string id)
        {
            throw new NotImplementedException();
        }

        public IList<Produit> FindAll()
        {
            using (var ctxt = new ProduitsContext())
            {
                return ctxt.Produits.ToList();
            }
        }

        public Produit FindByid(string id)
        {
            using (var ctxt = new ProduitsContext())
            {
                return ctxt.Produits.Where(p => p.Id.Equals(id)).FirstOrDefault();
            }
        }

        public Produit Update(Produit p)
        {
            throw new NotImplementedException();
        }
    }
}
