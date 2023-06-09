﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndFields
{
    enum Unit
    {
        Celsius,
        Kelvin,
        Fahrenheit
    }
    internal class WeatherManager
    {
        public string SearchChar { get; } = "°"; // readonly property 
        public string EndChar { get; set; } = ">"; // full access property 

        // private field 
        private string address = $"https://www.google.com/search?q=weather+";


        public double GetTemperature(string city, Unit unit)
        {
            // char onlyOneCharacter = 'a';


            //  Console.WriteLine("Enter the city name");
            //   string city = Console.ReadLine();



            WebClient wc = new WebClient();
            string data = wc.DownloadString(address + city);

            try
            {
                int index = data.IndexOf(SearchChar);
                int currentPosition = index;
                int iterationCount = 0;

                while (data.Substring(currentPosition, 1) != EndChar)
                {
                    iterationCount++;
                    currentPosition--;
                }

                string result = data.Substring(currentPosition + 1, index - currentPosition + 1);
        
                return TransformTemperature(unit,
                    Convert.ToDouble(result.Substring(0, result.Length - 2)));
            }
            catch (Exception)
            {
                throw new Exception("Failed to retrieve temperature");
            }
        }


        public double TransformTemperature(Unit unit, double temperature)
        {
            if (unit == Unit.Celsius)
                return temperature;

            if (unit == Unit.Fahrenheit)
                return temperature * 1.8 + 32;

            if (unit == Unit.Kelvin)
                return temperature + 273.15;

            throw new Exception("Unknown unit");
        }
    }
}
