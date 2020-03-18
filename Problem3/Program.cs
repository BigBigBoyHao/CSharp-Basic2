using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    
    class Program
    {
        static void Extract(int n, int p)
        {
            string binary = Convert.ToString(n, 2).PadLeft(16, '0');
            Console.WriteLine("The value of n:" + n + "\t The value of p:" + p);
            Console.WriteLine(binary);
            Console.WriteLine(binary[15 - p]);
        }
        static void Main(string[] args)
        {
            Extract(5, 2);
            Extract(0, 9);
            Extract(15, 1);
            Extract(5343, 7);
            Extract(62241, 11);
            Console.ReadKey();

        }
    }
}
