using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherManager weatherManager = new WeatherManager();


            double temp = weatherManager.GetTemperature("Warsaw", "Fahrenheit");
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
