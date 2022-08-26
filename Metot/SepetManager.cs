using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot
{

    public class SepetManager
    {
        //naming convention

        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
            //.....
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi: " + urunAdi);
        }
    }
}
