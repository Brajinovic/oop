using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadaca2OsnoveOOP
{
    public class DailyForecastRepository: IEnumerator, IEnumerable
    {
        private List<DailyForecast> forecasts;
        private int position = -1;
        public DailyForecastRepository()
        {
            this.forecasts = new List<DailyForecast>();
        }
        /*no idea why i wrote this part of code
        public DailyForecastRepository(List<DailyForecast> forecasts)
        {   //drink with the living dead
            //Concat returns a IEnumerable<T>, convert to list 
            this.forecasts.Concat(forecasts).ToList();
            //the same could have been done with AddRange...
            //this.forecasts = new List<DailyForecast>();
            //this.forecasts.AddRange(forecasts);
            //for more info, https://stackoverflow.com/questions/100196/net-listt-concat-vs-addrange
        }
        */
        public DailyForecastRepository(DailyForecastRepository repository)
        {//perfect strangers
            this.forecasts = new List<DailyForecast>();
            this.forecasts.AddRange(repository.GetDailyForecasts());
            //won't work because this.forecasts is empty, a new List<DailyForecast>
            //this.forecasts.Concat(repository.GetDailyForecasts());
            //how I firstly made it but then realised it is a reference, not a new object 
            //this.forecasts = repository.GetDailyForecasts();
        }
        

        public void Sort()
        {
            if (this.forecasts.Count >= 2)
            {
                this.forecasts.Sort();
            }
        }

        public void Add(DailyForecast forecast)
        {//the pot & kettle, srce na cesti
            //delete the previus forecast for the same day
            try
            {
                Remove(forecast.Date);
            }
            catch (NoSuchDailyWeatherException) { 
                //do nothing
            }
            //add the forecast to the forecast repository
            this.forecasts.Add(forecast);
            //sort the forecasts if there are 2 or more of them
            Sort();
        }

        public void Add(List<DailyForecast> forecasts)
        {//all right now
            foreach(DailyForecast forecast in forecasts)
            {
                Add(forecast);
            }
            Sort();
        }

        public void Remove(DateTime date)
        {//smoke on the water
            DailyForecast referentForecast = this.forecasts.Find(forecast => forecast.Date.Date == date.Date);
            if (this.forecasts.Contains(referentForecast))
            {
                this.forecasts.Remove(referentForecast);
            }
            else { 
                throw new NoSuchDailyWeatherException($"There is no forecast on {date.Date}!");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {//Ain't no fun
            position++;
            return position < forecasts.Count;
        }
        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get { return forecasts[position]; }
        }

        public List<DailyForecast> GetDailyForecasts()
        {//give it away
            return this.forecasts;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder(); ;
            foreach (DailyForecast forecast in forecasts) {
                text.AppendLine($"{forecast.ToString()}");
                
            }
            //ugly formating
            //text.Remove(text.Length - 2, 2);
            return text.ToString();
        }
    }
}
