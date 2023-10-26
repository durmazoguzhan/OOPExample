using OOPOrnek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class Anne : Insan, IOku, IDinleVeYaz
    {
        public void Dinle(string adi)
        {
            Console.WriteLine($"{adi} dinliyor...");
        }

        public void Yaz(string adi)
        {
            Console.WriteLine($"{adi} yazıyor...");
        }

        public void Oku(string adi)
        {
            Console.WriteLine($"{adi} okuyor...");
        }


    }
}
