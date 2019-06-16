using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3.classes
{
    class Islemci:TeknolojikCihaz
    {
        public string İslemciAilesi { get; set; }
        public int CekirdekSayisi { get; set; }
        public override int EnerjiKullan
        {
            get
            {
                return Enerji / 10;
            }
        }
    }
}
