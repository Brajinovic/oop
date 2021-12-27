using System;
using System.Collections.Generic;
using System.Text;

namespace zadaca2OsnoveOOP
{
    public class DailyForecast : IComparable
    {
        private DateTime date;
        private Weather Weather;

        public DailyForecast()
        {
            this.date = DateTime.Now;
            this.Weather = new Weather();

        }

        public DailyForecast(DateTime day, Weather weather) {
            this.date = day;
            this.Weather = weather;

        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public Weather TheWeather{
            get { return this.Weather; }
            set { this.Weather = value; }
        }

        public int CompareTo(object obj)
        {
            DailyForecast forecast = obj as DailyForecast;
            return Date.Date.CompareTo(forecast.Date);
        }

        

        public override string ToString()
        {
            return $"{date.ToString("dd/MM/yyyy HH:mm:ss")}: T={this.Weather.GetTemperature()}°C, w={this.Weather.GetWindSpeed()}km/h, h={this.Weather.GetHumidity()}%";
        }
    }
}
