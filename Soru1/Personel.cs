using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvanı { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Departman { get; set; }
        public Personel(string ad,string soyad,string unvan,DateTime dogumTarihi,string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Unvanı = unvan;
            DogumTarihi = dogumTarihi;
            Departman = departman;
        }
        public override string ToString()
        {
            return this.Departman + " " + this.Unvanı + " " + this.Ad + " " + this.Soyad + " " + this.DogumTarihi;
        }
    }
}
