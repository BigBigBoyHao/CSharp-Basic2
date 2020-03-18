using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Exchange(long n)
        {
            string binary = Convert.ToString(n, 2).PadLeft(32, '0');
            char b3 = binary[28];
            char b4 = binary[27];
            char b5 = binary[26];

            char b24 = binary[5];
            char b25 = binary[6];
            char b26 = binary[7];

            string str1 = binary.Substring(0, 5);
            string str2 = binary.Substring(8, 18);
            string str3 = binary.Substring(29, 3);
            string exchange = str1 + b5 + b4 + b3 + str2 + b24 + b25 + b26 + str3;

            long excn = Convert.ToInt64(exchange, 2);
            Console.WriteLine("原值为：" + n);
            Console.WriteLine("原二进制数：" + binary);
            Console.WriteLine("新二进制数：" + exchange);
            Console.WriteLine("结果为：" + excn);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Exchange(1140867093);
            Exchange(255406592);
            Exchange(4294901775);
            Exchange(5351);
            Exchange(2369124121);
            Console.ReadKey();
        }
    }
}
