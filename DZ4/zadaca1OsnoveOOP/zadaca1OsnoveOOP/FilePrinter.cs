using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace zadaca2OsnoveOOP
{
    public class FilePrinter : IPrinter
    {
        private string fileName;
        public FilePrinter()
        {
            this.fileName = "";
        }
        public FilePrinter(string fileName)
        {
            this.fileName = fileName;
        }

        public string FileName
        {
            get { return this.fileName; }
            set { this.fileName = value; }
        } 

        public void Printer(Weather[] weathers)
        {
            string[] data = new string[weathers.Length];
            for(int index = 0; index < weathers.Length; index++)
            {
                data[index] = weathers[index].ToString();
            }
        
            File.WriteAllLines(this.fileName, data);
        }
    }
}
    

