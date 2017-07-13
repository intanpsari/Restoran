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

        public string IdMeja { get; set; }
        public int Status { get; set; }

        public IEnumerable<SelectListItem> tMejas { get; set; }
        public MenuModel()
        {
            tMejas = new List<SelectListItem>();

        }
    }

}