using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5_REST_Hello.Models
{
    public class Produit
    {
        public int id { get; set; }
        public string Nom { get; set; }
        public decimal PrixUnitaire { get; set; }
    }
}