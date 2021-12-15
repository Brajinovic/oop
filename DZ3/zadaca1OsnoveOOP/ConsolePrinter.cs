using System;
using System.Collections.Generic;
using System.Text;

namespace zadaca2OsnoveOOP
{
    public class ConsolePrinter : IPrinter
    {
        private ConsoleColor textColor;

        public ConsolePrinter()
        {
            this.textColor = ConsoleColor.Gray;
        }

        public ConsolePrinter(ConsoleColor textColor)
        {
            this.textColor = textColor;
        }

        public ConsoleColor TextColor
        {
            get { return this.textColor; }
            set { this.textColor = value; }
        }
        public void Printer(Weather[] weathers)
        {
            Console.ForegroundColor = this.textColor;
            foreach (Weather weather in weathers) {

                
                Console.WriteLine(weather.ToString());
            }

        }
    }
}
