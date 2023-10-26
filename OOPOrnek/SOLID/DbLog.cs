using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.SOLID
{
    public class DbLog : Logger
    {
        public override void LogYaz(string value)
        {
            Console.WriteLine(value + " db e kaydedildi");
        }

    }
}
