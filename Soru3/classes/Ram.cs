using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3.classes
{
    class Ram:TeknolojikCihaz
    {
        public int HafizaKapasitesi { get; set; }
        public int HafizaFrekansHizi { get; set; }
        public override int EnerjiKullan
        {
            get
            {
                return Enerji / 5;
            }
        }
    }
}
