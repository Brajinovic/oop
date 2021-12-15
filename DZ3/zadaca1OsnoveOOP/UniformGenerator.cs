using System;
using System.Collections.Generic;
using System.Text;

namespace zadaca2OsnoveOOP
{
    public class UniformGenerator: IRandomGenerator
    {
        private Random generator;

        public UniformGenerator()
        {
            this.generator = null;
        }
        public UniformGenerator(Random generator)
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
            return randomNumber;
        }
    }
}
