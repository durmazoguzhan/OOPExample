using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class MyClass
    {
        public int x;
        public int y;

        private void MesajGoster()
        {
            Console.WriteLine($"x'in değeri: {x} \n y'nin değeri: {y}");
        }

        public string MesajDon()
        {
            return "bir mesaj";
        }

        public MyClass()
        {
            
        }

        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsBetween(int i)
        {
            if (i > 0)
                return true;
            else
                return false;
        }

        public double CostSalary(int hour, double salary) => hour * salary;
    }
}
