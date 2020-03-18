using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void BonusScore(int n)
        {
            int result = 0;
            if (n <= 0 || n >= 10)
                Console.WriteLine("invalid score");
            else if (n <= 3)
                result = n * 10;
            else if (n <= 6)
                result = n * 100;
            else if (n <= 9)
                result = n * 1000;
            if (result != 0)
                Console.WriteLine("The result is " + result);
        }
        static void Main(string[] args)
        {
            BonusScore(2);
            BonusScore(4);
            BonusScore(9);
            BonusScore(-1);
            BonusScore(10);
            Console.ReadKey();
        }
    }
}
