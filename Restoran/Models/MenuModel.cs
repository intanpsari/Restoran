using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoran.Models
{
    public class MenuModel
    {
        public string IdMenu { get; set; }
        public string Nama { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }
        public string Images { get; set; }
        

        
    }

}