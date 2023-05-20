using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Smith";
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.FullName);
            
            WeatherManager weatherManager = new WeatherManager();
            Console.WriteLine(weatherManager.SearchChar);
            weatherManager.EndChar = "%";
            weatherManager.GetTemperature("Warsaw", Unit.Celsius);
        }
    }
}
