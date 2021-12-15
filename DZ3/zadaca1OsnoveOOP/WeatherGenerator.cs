using System;
using System.Collections.Generic;
using System.Text;

namespace zadaca2OsnoveOOP
{
    public class WeatherGenerator
    {
        private double minTemperature;
        private double maxTemperature;
        private double minHumidity;
        private double maxHumidity;
        private double minWindSpeed;
        private double maxWindSpeed;
        private IRandomGenerator generator;

        public WeatherGenerator()
        {
            this.minTemperature = 0;
            this.maxTemperature = 0;
            this.minHumidity = 0;
            this.maxHumidity = 0;
            this.minWindSpeed = 0;
            this.maxWindSpeed = 0;
            this.generator = null;
        }
        public WeatherGenerator(double minTemperature, double maxTemperature, double minHumidity, double maxHumidity, double minWindSpeed, double maxWindSpeed, IRandomGenerator generator)
        {
            this.minTemperature = minTemperature;
            this.maxTemperature = maxTemperature;
            this.minHumidity = minHumidity;
            this.maxHumidity = maxHumidity;
            this.minWindSpeed = minWindSpeed;
            this.maxWindSpeed = maxWindSpeed;
            this.generator = generator;
        }

        public double MinTemperature
        {
            get { return this.minTemperature; }
            set { this.minTemperature = value; }
        }

        public double MaxTemperature
        {
            get { return this.maxTemperature; }
            set { this.maxTemperature = value; }
        }

        public double MinHumidity
        {
            get { return this.minHumidity; }
            set { this.minHumidity = value; }
        }

        public double MaxHumidity
        {
            get { return this.maxHumidity; }
            set { this.maxHumidity = value; }
        }

        public double MinWindSpeed
        {
            get { return this.minWindSpeed; }
            set { this.minWindSpeed = value; }
        }

        public double MaxWindSpeed
        {
            get { return this.maxWindSpeed; }
            set { this.maxWindSpeed = value; }
        }

        public void SetGenerator(IRandomGenerator generator)
        {
            this.generator = generator;
        }

        public Weather Generate()
        {
            Weather weather = new Weather(this.generator.Generate(this.minTemperature, this.maxTemperature), this.generator.Generate(this.minHumidity, this.maxHumidity), this.generator.Generate(this.minWindSpeed, this.maxWindSpeed));
            return weather;
        }
    }
}
