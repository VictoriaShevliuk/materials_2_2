using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Shevliuk_OOP
{
    class RationalFraction : IPersent
    {
        public int numerator { get; set; } 
        public int denominator { get; set; } 

        public RationalFraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Знаменник не може дорiвнювати нулю!");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public decimal Persentage(decimal p)
        {
            decimal lm = ((decimal)numerator) / ((decimal)denominator) * (p / 100);
            return lm;
        }

        public decimal LessMore(decimal lm)
        {
            return (((decimal)numerator) / ((decimal)denominator) + lm);
        }


    }
}
