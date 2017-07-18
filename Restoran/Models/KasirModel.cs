using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoran.Models
{
    public class KasirModel
    {
        public int IdOrder { get; set; }
        public string IdMenu { get; set; }

        public string IdMeja { get; set; }
        public string Nama { get; set; }
        public int Harga { get; set; }
        public int Jumlah { get; set; }
        public int Total { get; set; }
        public int TotalBayar { get; set; }

        public IEnumerable<SelectListItem> tMejas { get; set; }

        public KasirModel()
        {
            tMejas = new List<SelectListItem>();

        }
    }
}