using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Shevliuk_OOP
{
    class TCylinder:TCircle
    {
        private double height;

        public TCylinder()
        {
            height = 0;
        }

        public TCylinder(double radius, double height)
        {
            SetRadius(radius);
            this.height = height;
        }

        public TCylinder(TCylinder cylinder)
        {
            this.height = cylinder.GetHeight();
        }

        public double GetHeight()
        {
            return height;
        }

        public double SetHeight(int radius)
        {
            return this.height = radius;
        }

        public double CylinderVolume()
        {
            return height * CircleSquare();
        }

        public void CylinderCompare(TCylinder cylinder)
        {
            if (cylinder.CylinderVolume() > CylinderVolume())
            {
                Console.WriteLine("Другий цилiндр бiльший за перший!");
            }
            else if (cylinder.CylinderVolume() == CylinderVolume())
            {
                Console.WriteLine("Цi цилiнри рiвнi!");
            }
            else if (cylinder.CylinderVolume() < CylinderVolume())
            {
                Console.WriteLine("Перший цилiндр бiльший за другий!");
            }
        }


    }
}
