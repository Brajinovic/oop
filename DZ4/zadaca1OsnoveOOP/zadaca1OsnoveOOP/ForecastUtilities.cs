using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace zadaca2OsnoveOOP
{
    public class ForecastUtilities
    {
        public static DailyForecast Parse(string fileInput)
        {
            DailyForecast forecast = new DailyForecast();
            string[] data = fileInput.Split(",");
            forecast.Date = DateTime.ParseExact(data[0], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            forecast.TheWeather = new Weather(Double.Parse(data[1]), Double.Parse(data[3]), Double.Parse(data[2]));
            return forecast ;
        }

        public static Weather FindWeatherWithLargestWindchill(Weather[] weathers)
        {
            int largest = 0;
            for (int weatherIndex = 0; weatherIndex < weathers.Length; weatherIndex++)
            {
                if (weathers[weatherIndex].CalculateWindChill() > weathers[largest].CalculateWindChill())
                {
                    largest = weatherIndex;
                }
            }

            return weathers[largest];
        }

        public static void PrintWeathers(IPrinter[] printers, Weather[] weathers)
        { 
            foreach(IPrinter printer in printers)
            {
                printer.Printer(weathers);
            }
        }
    }
}
