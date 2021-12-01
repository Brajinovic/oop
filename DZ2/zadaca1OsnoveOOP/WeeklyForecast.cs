using System;
using System.Collections.Generic;
using System.Text;

namespace zadaca1OsnoveOOP
{
    public class WeeklyForecast
    {
        private DailyForecast[] weathers;

        public WeeklyForecast()
        {
            this.weathers = null;
        }
        public WeeklyForecast(DailyForecast[] dailyForecasts)
        {
            this.weathers = dailyForecasts;
        }
        public DailyForecast this[int weatherIndex]
        {
            get { return this.weathers[weatherIndex]; }
            set { this.weathers[weatherIndex] = value; }
        }
        public DailyForecast[] Weathers
        {
            get { return this.weathers; }
            set { this.weathers = value; }
        }

        public string GetAsString()
        {
            string text = "";
            for(int index = 0; index < weathers.Length; index++)
            {
                text += $"{weathers[index].GetAsString()}\n";
            }

            return text;
        }

        public string GetMaxTemperature()
        {
            Weather biggestTemperature = weathers[0].TheWeather;
            for(int index = 1; index < weathers.Length; index++)
            {
                if (biggestTemperature < weathers[index].TheWeather)
                    biggestTemperature = weathers[index].TheWeather;
            }
            return biggestTemperature.GetTemperature().ToString();
        }

      
    }
}
