using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru2
{
    class sifrele
    {
        public string Sifre { get; set; }
        string parcaDizi = string.Empty;
        string kelime = string.Empty;
        string _olusmusSifre = string.Empty;
        char[] ayir;
        int oncekiHarf = 0;
        public sifrele(string sifre)
        {
            Sifre = sifre;
        }
        
        public string SifreCevir()//kendinden önceki harfe çevirerek şifreleme
        {
            kelime = Sifre;
            for (int i = 0; i < kelime.Length; i++)
            {
                ayir = kelime.ToCharArray();
                char harf = ayir[i];
                int letter=Convert.ToInt32(harf);
                oncekiHarf = letter - 1;
                char son = Convert.ToChar(oncekiHarf);
                _olusmusSifre += son;                
            }
            return _olusmusSifre;
        }
        public string SifreCevir1()// 3lü bloklara ayırarak şifreleme
        {
            kelime = Sifre;
            for (int i = 0; i < kelime.Length; i++)
            {
                ayir = kelime.ToCharArray();
                char harf = ayir[i];
                if (i%3==2)
                {
                    parcaDizi += harf+"|";
                }
                else
                {
                    parcaDizi += harf;
                }                
            }
            string[] bdizi = new string[] {parcaDizi};
            string isaretlenmisMetin = bdizi[0];
            string[] cevrilecekMetin = isaretlenmisMetin.Split('|');
            for (int i = 0; i < cevrilecekMetin.Count(); i++)
            {
                cevrilecekMetin[i] = new string(cevrilecekMetin[i].Reverse().ToArray());
                _olusmusSifre += cevrilecekMetin[i];
            }
            return _olusmusSifre;
        }
    }
}
