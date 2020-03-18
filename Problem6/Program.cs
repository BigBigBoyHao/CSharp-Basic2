using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] units = new string[] {"Zero", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine ", "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Ninteen " };
            string[] tens = new string[] { "Ten ", "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninty " };
            int i, num;
            string result = "";
            Console.Write("Enter number here in range 0-999 : ");
            num = int.Parse(Console.ReadLine());
            if (num > 99 && num < 1000)
            {
                i = num / 100;
                result = units[i] + "hundred ";
                num = num % 100;
                if(num>0 && !result.Equals(""))
                {
                    result = result + "and ";
                }
            }//if
            if (num > 19 && num < 100)
            {
                i = num / 10;
                if (result.Equals(""))
                    result = result + tens[i-1];
                else
                    result = result + tens[i-1].ToLower();
                num = num % 10;
            }//if
            if (num < 20 && num >= 0)
                if (result.Equals(""))
                    result += units[num];
                else if(num != 0)
                    result += units[num].ToLower();
            Console.WriteLine("The number you entered: " + result);
            Console.ReadLine();
        }
    }
}
