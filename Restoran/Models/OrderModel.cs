using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

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

        //Buat dropdown
        public IEnumerable<SelectListItem> tMejas { get; set; }
        public IEnumerable<SelectListItem> tMenus { get; set; }

        public OrderModel()
        {
            tMejas = new List<SelectListItem>();
            tMenus = new List<SelectListItem>();

        }

        //buat checkbox
        public List<CheckBoxes> DaftarMenu { get; set; }

        public class CheckBoxes
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public bool Checked { get; set; }
        }



    }
}