using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Checkpoint(double x,double y)
        {
            Console.Write("The value of x:" + x);
            Console.WriteLine("\tThe value of y:" + y);
            //先判断是否在圆内
            bool InCircle = false;
            if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 2.25)
                InCircle = true;
            //判断是否在矩形内
            bool OutsideRectangle = true;
            if (x <= 5 && x >= -1 && y >= -1 && y <= 1)
                OutsideRectangle = false;
            if (InCircle && OutsideRectangle)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            
        }
        static void Main(string[] args)
        {
            //获取变量
            Checkpoint(1, 2);
            Checkpoint(2.5, 2);
            Checkpoint(0, 1);
            Checkpoint(2.5, 1);
            Checkpoint(2, 0);
            Checkpoint(4, 0);
            Checkpoint(2.5, 1.5);
            Checkpoint(2, 1.5);
            Checkpoint(1, 2.5);
            Checkpoint(-100, -100);
            Console.ReadKey();
        }
    }
}
