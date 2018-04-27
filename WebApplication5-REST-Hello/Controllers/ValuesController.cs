using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication5_REST_Hello.Models;

namespace WebApplication5_REST_Hello.Controllers
{
    public class ValuesController : ApiController
    {

        public static List<Produit> data = new List<Produit>()
            {
                new Produit {id = 100, Nom = "Produit 1 ",PrixUnitaire = 10.5M},
                new Produit { id = 200, Nom = "Produit 2 ", PrixUnitaire = 110.5M }
        };
       
        // GET api/values
        public IEnumerable<Produit> Get()
        {
            return data;
        }

        // GET api/values/5
        public Produit Get(int id)
        {
            return data.Where(p => p.id.Equals(id)).FirstOrDefault();
        }

        // POST api/values
        public void Post(Produit value)
        {
            data.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
