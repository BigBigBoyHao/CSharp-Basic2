using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class Program
    {
        static void RandomNum(int n,int min,int max)
        {
            Random ra = new Random();
            for(int i=0;i<n;i++)
            {
                Console.Write(ra.Next(min, max + 1) + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            RandomNum(5, 0, 1);
            RandomNum(10, 10, 15);
            Console.ReadKey();
        }
    }
}
