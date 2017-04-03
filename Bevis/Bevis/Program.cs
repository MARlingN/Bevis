using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevis
{
    class Program
    {
        static void Main(string[] args)
        {
            tjek4 tjek = new tjek4();
            int a = 4;
            int b = 8;
            int c = b / a;
            int d = 2;
            Console.WriteLine(tjek.erdet(d, c));
            Console.WriteLine(tjek.erdet(a, b));
            Console.WriteLine(tjek.erdet(1, 3));
        }
    }
}
