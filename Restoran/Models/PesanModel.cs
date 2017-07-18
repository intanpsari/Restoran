using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoran.Models
{
    public class PesanModel
    {
        public int NoMeja { get; set; }
        public int Status { get; set; }

        public int IdOrder { get; set; }

        public string Nama { get; set; }

        public string Images { get; set; }

        public int JumlahMenu { get; set; }

        public string IdMenu { get; set; }

        

        public IEnumerable<SelectListItem> tMejas { get; set; }

        public PesanModel()
        {
            tMejas = new List<SelectListItem>();

        }
        public string IdMeja { get; set; }

    }
}