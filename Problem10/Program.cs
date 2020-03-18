using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        static int Gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return Gcd(b, a % b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入a值：");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入b值：");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a和b的最大公约数为："+Gcd(a, b));
            Console.ReadKey();
        }
    }
}
