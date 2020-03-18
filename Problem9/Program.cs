using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        static void DecToBin(long dec)
        {
            string binary = Convert.ToString(dec,2);
            Console.WriteLine(binary);
        }
        static void Main(string[] args)
        {
            DecToBin(0);
            DecToBin(3);
            DecToBin(43691);
            DecToBin(236476736);
            Console.ReadKey();
        }
    }
}
