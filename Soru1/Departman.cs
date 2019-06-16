using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Departman:IPersonel
    {
        public string DepartmanAdi { get; set; }
        public string Ad { get ; set; }
        public string Soyad { get; set; }
        public string Unvanı { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
