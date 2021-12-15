using System;
using System.Collections.Generic;
using System.Text;

namespace zadaca2OsnoveOOP
{
    public class BiasedGenerator : IRandomGenerator
    {
        private Random generator;

        public BiasedGenerator()
        {
            this.generator = null;
        }
        public BiasedGenerator(Random generator)
        {
            this.generator = generator;
        }

        public Random Generator
        {
            get { return this.generator; }
            set { this.generator = value; }
        }
        public double Generate(double bottomBorder, double topBorder)
        {
            double randomNumber = bottomBorder + this.generator.NextDouble() * (topBorder - bottomBorder);
            if (randomNumber > bottomBorder + ((topBorder - bottomBorder) / 2))
            {
                randomNumber = bottomBorder + this.generator.NextDouble() * (topBorder - bottomBorder);
            }
            return randomNumber;
        }
    }
}
