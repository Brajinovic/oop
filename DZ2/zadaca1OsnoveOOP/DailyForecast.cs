using System;
using System.Collections.Generic;
using System.Text;

namespace zadaca1OsnoveOOP
{
    public class DailyForecast
    {
        private DateTime date;
        private Weather theWeather;

        public DailyForecast()
        {
            this.date = DateTime.Now;
            this.theWeather = null;

        }

        public DailyForecast(DateTime day, Weather weather) {
            this.date = day;
            this.theWeather = weather;

        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public Weather TheWeather{
            get { return this.theWeather; }
            set { this.theWeather = value; }
        }

        public string GetAsString()
        {
            return $"{date.ToString("dd/MM/yyyy HH:mm:ss")}: T={theWeather.GetTemperature()}°C, w={theWeather.GetWindSpeed()}km/h, h={theWeather.GetHumidity()}%";
        }
    }
}
