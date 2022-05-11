using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Testing
{
    public class DayofWeek
    {
        public static void DayWeek()
        {
            //User input 
            Console.Write("\nEnter a Month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Day : ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            //Gregorian calendar formulas
            int y0 = year - (14 - month) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + 31 * m0 / 12) % 7;

            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("\nDay Of The Week : " + days[d0]);
        }
    }
}
