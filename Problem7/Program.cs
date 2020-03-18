using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] value = new string[] { " 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9", "10", " J", " Q", " K", " A" };
            for(int i = 0;i<13;i++)
                for(int j = 0;j<4;j++)
                {
                    Console.Write(value[i]);
                    switch (j)
                    {
                        case 0:
                            Console.Write("♣    ");
                            break;
                        case 1:
                            Console.Write("♦    ");
                            break;
                        case 2:
                            Console.Write("♥    ");
                            break;
                        case 3:
                            Console.WriteLine("♠");
                            break;
                    }
                }
            Console.ReadKey();
        }
    }
}
