using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3.classes
{
    abstract class TeknolojikCihaz
    {
        public string Marka { get; set; }
        public string Ad { get; set; }
        public string Renk { get; set; }
        public int Genislik { get; set; }
        public int Uzunluk { get; set; }
        public int Enerji { get; set; }

        public virtual int EnerjiKullan
        {
            get
            {
                return Enerji;
            }
        }
    }
}
