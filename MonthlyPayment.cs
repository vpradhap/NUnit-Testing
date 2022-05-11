using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Testing
{
    public class MonthlyPayment
    {
        public static void Payment()
        {
            //User inputs
            Console.Write("\nEnter Principle Amount : ");
            double P = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter How Many Years To Pay : ");
            double Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Rate of Interest Compounded Monthly : ");
            double R = Convert.ToInt32(Console.ReadLine());

            //Formulas
            double n = 12 * Y;
            double r = R / (12 * 100);
            double payment = (P * r) / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine("\nMonthly payment : " + payment);
        }
    }
}
