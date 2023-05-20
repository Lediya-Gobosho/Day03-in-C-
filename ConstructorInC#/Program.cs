using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ example 1 ------");
            Calculator calculator =
                new Calculator("normal");

            Calculator c2 = new Calculator();
            double d = calculator.Calculate(2, 3);
            Console.WriteLine("------ example 2 ------");

            WeatherManager weatherManager = new WeatherManager(Unit.Kelvin);

            weatherManager.GetTemperature("warsaw");

            weatherManager.GetTemperature("singapore");
        }
    }
    
}
