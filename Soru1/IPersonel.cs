using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    interface IPersonel
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        string Unvanı { get; set; }
        DateTime DogumTarihi { get; set; }
    }
}
