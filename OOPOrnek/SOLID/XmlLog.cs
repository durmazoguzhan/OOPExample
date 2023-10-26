using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.SOLID
{
    public class XmlLog : Logger
    {
        public override void LogYaz(string value)
        {
            Console.WriteLine(value + " xml e kaydedildi");
        }

    }
}
