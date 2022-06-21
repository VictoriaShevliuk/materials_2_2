using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Shevliuk_OOP
{
    class TCircle
    {
        private double radius; 

        public TCircle()
        {
            radius = 0;
        }

        public TCircle(double radius)
        {
            this.radius = radius;
        }

        public TCircle(TCircle circle)
        {
            this.radius = circle.GetRadius();
        }

        public double GetRadius()
        {
            return radius;
        }

        public double SetRadius(double radius)
        {
           return this.radius = radius;
        }

        public double CircleSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double CircleLength()
        {
            return Math.PI * radius * 2;
        }

        //порівняння кіл
        public void CircleCompare(TCircle circle)
        {
            if (circle.GetRadius() > radius)
            {
                Console.WriteLine("Друге коло бiльше за перше!");
            }
            else if (circle.GetRadius() == radius)
            {
                Console.WriteLine("Цi кола рiвнi!");
            }
            else if (circle.GetRadius() < radius)
            {
                Console.WriteLine("Перше коло бiльше за друге!");
            }
        }

        //перевантаження операторів
        public static TCircle operator +(TCircle cir1, TCircle cir2)
        {
            return new TCircle(cir1.GetRadius() + cir2.GetRadius());
        }

        public static TCircle operator -(TCircle cir1, TCircle cir2)
        {
            return new TCircle(cir1.GetRadius() - cir2.GetRadius());
        }

        public static TCircle operator *(TCircle cir, double num)
        {
            return new TCircle(cir.GetRadius() * num);
        }

        


    }
}
