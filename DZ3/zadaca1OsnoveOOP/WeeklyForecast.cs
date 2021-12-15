using System;
using System.Collections.Generic;
using System.Text;

namespace zadaca2OsnoveOOP
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
        
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            for (int index = 0; index < weathers.Length; index++)
            {
                text.AppendLine($"{weathers[index].ToString()}");
            }

            return text.ToString();
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
