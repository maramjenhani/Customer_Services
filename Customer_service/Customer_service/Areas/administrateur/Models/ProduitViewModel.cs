using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer_service.Areas.administrateur.Models
{
    public class ProduitViewModel
    {
        public int @ref { get; set; }
        public string designation { get; set; }
        public string description { get; set; }
        public float prix { get; set; }
        public string couleur { get; set; }
        public byte[] photo { get; set; }
    }
}