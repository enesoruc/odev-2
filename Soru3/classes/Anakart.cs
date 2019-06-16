using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3.classes
{
    class Anakart:TeknolojikCihaz
    {
        public int USBPortAdedi { get; set; }
        public bool GucBaglantisiVarMi { get; set; }

        public override int EnerjiKullan
        {
            get
            {
                return Enerji / 3;
            }
        }
    }
}
