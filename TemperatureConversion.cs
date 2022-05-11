using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Testing
{
    public class TemperatureConversion
    {
        public static void Temperature()
        {
            //User input
            Console.WriteLine("1 - Celsius to Fahrenheit");
            Console.WriteLine("2 - Fahrenheit to Celsius");
            Console.Write("\n\tPick a Option : ");
            int pick = Convert.ToInt32(Console.ReadLine());
            switch (pick)
            {
                case 1:
                    Console.Write("\nEnter temperature in degree Celsius : ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32; //Formula
                    Console.WriteLine("\nTemperature in degree Fahrenheit : " + fahrenheit + " degF");
                    break;
                case 2:
                    Console.Write("\nEnter temperature in degree Fahrenheit : ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9; //Formula
                    Console.WriteLine("\nTemperature in degree Celsius : " + celsius + " degC");
                    break;
                default:
                    Console.WriteLine("\n\t\tInvalid Option");
                    break;
            }
        }
    }
}
