using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;


namespace zadaca2OsnoveOOP
{
    [Serializable]
    public class NoSuchDailyWeatherException : Exception
    {
        DateTime date;
        public NoSuchDailyWeatherException() { }
        public NoSuchDailyWeatherException(string message) : base(message) { }
        public NoSuchDailyWeatherException(string message, DateTime date) : base(message)
        {//rock 'n' roll singer
            this.date = date;
        }
        public NoSuchDailyWeatherException(string message, Exception innerException) : base(message, innerException) { }
        public NoSuchDailyWeatherException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
