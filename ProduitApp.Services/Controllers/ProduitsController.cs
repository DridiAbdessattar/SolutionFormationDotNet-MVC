using ProduitApp.DataAccess;
using ProduitApp.DataAccess.Domain;
using ProduitApp.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProduitApp.Services.Controllers
{
    public class ProduitsController : ApiController
    {

        private IProduitsRepository repo = new ProduitsRepositoryImpl(); 
        // GET: api/Produits
        public IEnumerable<Produit> Get()
        {
            return repo.FindAll();
        }

        // GET: api/Produits/5
        public Produit Get(string id)
        {
            return repo.FindByid(id);
        }

        // POST: api/Produits
        public void Post(Produit p)
        {
            repo.Creation(p);
        }

        // PUT: api/Produits/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Produits/5
        public void Delete(int id)
        {
        }
    }
}
