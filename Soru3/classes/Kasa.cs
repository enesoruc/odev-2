using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3.classes
{
    class Kasa:TeknolojikCihaz
    {
        public bool CDRomVarMi { get; set; }
        public bool GucGirisiVarMi { get; set; }
        public override int EnerjiKullan
        {
            get
            {
                return Enerji / 2;
            }
        }
    }
}
