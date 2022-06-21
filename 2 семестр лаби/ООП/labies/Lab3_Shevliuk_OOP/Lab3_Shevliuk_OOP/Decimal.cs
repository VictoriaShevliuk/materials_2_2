using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Shevliuk_OOP
{
    class Decimal : IPersent
    {
        public double number { get; set; }
        public Decimal(double number)
        {
            this.number = number;
        }
        public decimal Persentage(decimal p)
        {
            return ((p / 100) * (decimal)number);
        }
        public decimal LessMore(decimal lm)
        {
            return (decimal)number + lm;
        }

    }
}
