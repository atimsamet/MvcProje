using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonProje.Data.Entity
{
    public class Urun : Base
    {
        public string UrunAdi { get; set; }
        public double Fiyat{ get; set; }
        public Kategori Kategori { get; set; }

    }
}
