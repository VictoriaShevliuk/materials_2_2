using System;

namespace Lab1_Shevliuk_OOP
{
    class Program
    {
        public static int mult_num = 3;
        static void Main(string[] args)
        {
            TCircle cir0 = new TCircle(InputRadius());
            CircleInfo(cir0);
            Console.WriteLine("Створюю ще одне коло... Збiльшую його радiус!");
            TCircle cir1 = new TCircle(cir0 + new TCircle(5));
            CircleInfo(cir1);
            Console.WriteLine("Порiвняємо Ваше коло з тим, що я зробив  ;)");
            cir0.CircleCompare(cir1);
            Console.WriteLine("\n\nТепер на основi цих кiл створимо цилiндри! \n\n ");
            double height = InputHeight();
            TCylinder cyl1 = new TCylinder(cir0.GetRadius(), height);
            Console.WriteLine("Перший цилiндр: \n");
            CylinderInfo(cyl1);
            TCylinder cyl2 = new TCylinder(cir1.GetRadius(), height);
            Console.WriteLine("Другий цилiндр: \n");
            CylinderInfo(cyl2);
            Console.WriteLine("Порiвняємо цi два цилiндри! \n");
            cyl1.CylinderCompare(cyl2);
        }


        private static void CircleInfo(TCircle circle)
        {
            Console.WriteLine(String.Format("Радiус кола: " +
                                            "{0:0.##}\n" +
                                            "Довжина кола: {1:0.##}\n" +
                                            "Площа кола: {2:0.##}\n" +
                                            "Сума радiусiв двох однакових кiл: {3:0.##}\n" +
                                            "Радiус кола, помножений на {4:0.##}: {5:0.##}\n" +
                                            "Рiзниця мiж Вашим та помноженим на число " +
                                            "радiусами кiл: {6:0.##}\n",
                                            circle.GetRadius(), circle.CircleLength(), circle.CircleSquare(),
                                            (circle + circle).GetRadius(), mult_num, (circle*mult_num).GetRadius(),
                                            (circle*mult_num - circle).GetRadius()
                                            ));
        }

        private static void CylinderInfo(TCylinder cylinder)
        {
            Console.WriteLine(String.Format("Радiус цилiндра: " +
                                            "{0:0.##}\n" +
                                            "Висота цилiндра: " +
                                            "{1:0.##}\n" +
                                            "Об’єм цилiндра: {2:0.##}\n" +
                                            "\n",
                                            cylinder.GetRadius(),cylinder.GetHeight(), cylinder.CylinderVolume()
                                            ));
        }

        private static double InputRadius()
        {
            Console.WriteLine("Введiть радiус вашого кола: ");
            return Convert.ToDouble(Console.ReadLine());
        }
        private static double InputHeight()
        {
            Console.WriteLine("Введiть висоту для вашого цилiдра: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
