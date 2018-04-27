using ProduitApp.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduitApp.DataAccess
{
   public  interface IProduitsRepository
    {

        //CRUD

        void Creation(Produit p);//C DU CRUD
        IList<Produit> FindAll();//R
        Produit FindByid(string id);//R
        Produit Update(Produit p);//U
        void delete(string id);//D
    }
}
