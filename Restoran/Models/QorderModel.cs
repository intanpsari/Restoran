using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restoran.Models
{
    public class QorderModel
    {
        public string IdMeja { get; set; }
        public int Status { get; set; }

        public string IdMenu { get; set; }
        public string Nama { get; set; }
        public string Images { get; set; }
        public int Harga { get; set; }
        public int Jumlah { get; set; }
    }
}