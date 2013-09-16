using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome !");
            
            Console.WriteLine("---------------");
            Console.WriteLine("How much gold have you collected ?");
            Console.Write("(ie: 12) > ");
            int gold = int.Parse(Console.ReadLine());
            Console.WriteLine("(thank you)");


            Console.WriteLine("---------------");
            Console.WriteLine("How many hours have you played ?");
            Console.Write("(ie: 2.5) > ");
            float hours = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("(thank you)");

            float minutes = hours * 60;

            float goldPerMinutes = gold / minutes;
            Console.WriteLine("+--------------+----------------+------------------+");
            Console.WriteLine("|-----gold-----|--hours played--|-gold per minutes-|");
            Console.WriteLine("+--------------+----------------+------------------+");
            Console.WriteLine("|  {0,10:D}  |  {1,12:F}  | {2,16:F} |", gold, hours, goldPerMinutes);
            Console.WriteLine("+--------------+----------------+------------------+");

        }

    }
}
