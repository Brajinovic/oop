using System;
using System.Collections.Generic;
using System.Text;

namespace zadaca1OsnoveOOP
{
    public class Weather
    {
        private double currentTemperature;
        private double relativeHumidity;
        private double windSpeed;

        public Weather()
        {
            currentTemperature = 0;
            relativeHumidity = 0;
            windSpeed = 0;
        }

        public Weather(double currentTemperature, double relativeHumidity, double windSpeed)
        {
            this.currentTemperature = currentTemperature;
            this.relativeHumidity = relativeHumidity;
            this.windSpeed = windSpeed;
        }

        public double GetTemperature()
        { return this.currentTemperature; }

        public void SetTemperature(double value)
        { this.currentTemperature = value; }

        public double GetHumidity()
        { return this.relativeHumidity; }

        public void SetHumidity(double value)
        { this.relativeHumidity = value; }

        public double GetWindSpeed()
        { return this.windSpeed; }

        public void SetWindSpeed(double value)
        { this.windSpeed = value; }

        public double CalculateFeelsLikeTemperature()
        {
            float feelsLikeTemperature;
            //calculating the feels like temperature, src: https://en.wikipedia.org/wiki/Heat_index
            feelsLikeTemperature = (float)(-8.78469475556 + 
                                            1.61139411 * this.currentTemperature + 
                                            2.33854883889 * this.relativeHumidity +
                                           -0.14611605 * this.currentTemperature * this.relativeHumidity +
                                           -0.012308094 * Math.Pow(this.currentTemperature, 2) +
                                           -0.0164248277778 * Math.Pow(this.relativeHumidity, 2) +
                                            0.002211732 * Math.Pow(this.currentTemperature, 2) * this.relativeHumidity +
                                            0.00072546 * this.currentTemperature * Math.Pow(this.relativeHumidity, 2) +
                                            -0.000003582 * Math.Pow(this.currentTemperature, 2) * Math.Pow(this.relativeHumidity, 2));
            return feelsLikeTemperature;
        }

        public double CalculateWindChill()
        {
            float windChill;
            //calculating the wind chill, src: https://en.wikipedia.org/wiki/Wind_chill
            if(this.currentTemperature < 10 && this.windSpeed > 4.8) { 
            windChill = (float)(13.12 + 
                                0.6215 * this.currentTemperature - 
                                11.37 * Math.Pow(this.windSpeed, 0.16) + 
                                0.3965 * this.currentTemperature * Math.Pow(this.windSpeed, 0.16));
            }
            else
            {
                windChill = 0;
            }
            return windChill;
        }
        
        public string GetAsString()
        {
            return $"T={this.currentTemperature}°C, w={this.windSpeed}km/h, h={this.relativeHumidity}%";
        }

        public static bool operator <(Weather dayOne, Weather dayTwo)
        {
            return dayOne.GetTemperature() < dayTwo.GetTemperature();
        }

        public static bool operator >(Weather dayOne, Weather dayTwo)
        {
            return dayOne.GetTemperature() > dayTwo.GetTemperature();
        }
    }
    
}
