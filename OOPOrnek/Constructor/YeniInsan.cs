using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.Constructor
{
    public class YeniInsan
    {
        Kafa kafa;
        string ad;
        string soyad;

        public YeniInsan(Kafa kafa, string ad, string soyad)
        {
            this.kafa = kafa;
            this.ad = ad;
            this.soyad = soyad;
        }

        public void EkranaYaz()
        {
            Console.WriteLine("Kişinin Adı: " + ad);
            Console.WriteLine("Kişinin Soyadı: " + soyad);
            Console.WriteLine("Kişinin Göz Rengi: " + kafa.goz.renk);
            Console.WriteLine("Kişinin Burun Tipi: " + kafa.burun.tipi);
            Console.WriteLine("Kişinin Kulak Şekli: " + kafa.kulak.sekil);
        }
    }
}
