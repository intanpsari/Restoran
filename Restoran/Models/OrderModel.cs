using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoran.Models
{
    public class OrderModel
    {
        public int IdOrder { get; set; }
        public string MejaId { get; set; }
        public string MenuId { get; set; }
        
        public string Nama { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }
        
        public int NoMeja { get; set; }
        public int Status { get; set; }

        public IEnumerable<SelectListItem> tMejas { get; set; }
        public IEnumerable<SelectListItem> tMenus { get; set; }
        public OrderModel()
        {
            tMejas = new List<SelectListItem>();
            tMenus = new List<SelectListItem>();

        }

        

        
    }
}