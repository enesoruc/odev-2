using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3.classes
{
    class Sogutucu:TeknolojikCihaz
    {
        public int RPM { get; set; }
        public override int EnerjiKullan
        {
            get
            {
                return Enerji / 7;
            }
        }
    }
}
