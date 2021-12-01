using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace zadaca1OsnoveOOP
{
    public class ForecastUtilities
    {
        public static DailyForecast Parse(string v)
        {
            DailyForecast forecast = new DailyForecast();
            forecast.Date = DateTime.ParseExact(v.Split(",")[0], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            forecast.TheWeather = new Weather(Double.Parse(v.Split(",")[1]), Double.Parse(v.Split(",")[3]), Double.Parse(v.Split(",")[2]));
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
    }
}
