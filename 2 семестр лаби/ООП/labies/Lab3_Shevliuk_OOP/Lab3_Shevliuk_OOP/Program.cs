using System;

namespace Lab3_Shevliuk_OOP
{
    class Program
    {
        static int select_menu()
        {
            Console.WriteLine("З яким числом ви хочете працювати? \n");
            Console.WriteLine("1 -> Рацiональний дрiб");
            Console.WriteLine("2 -> Десятковий дрiб");
            Console.WriteLine("0 -> Завершити програму");
            int s = Convert.ToInt32(Console.ReadLine()); ;
            return s;
        }
        static void Main(string[] args)
        {
           
           
                while (true)
                {
                    int s = select_menu();
                    switch (s)
                    {
                        case 1:

                            Console.Write("Введіть чисельник: ");
                            int numer = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Введіть знаменник: ");
                            int denom = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Введіть відсоток: ");
                            double p = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine();
                            RationalFraction n = new RationalFraction(numer, denom);
                            decimal res = n.Persentage((decimal)p);
                            Console.Write("{0}% від {1}/{2} = {3}", p, n.numerator, n.denominator, res);
                            Console.WriteLine();
                            decimal more = n.LessMore(res);
                            Console.Write("{0}/{1} + {2}%= {3}", n.numerator, n.denominator, p, more);
                            Console.WriteLine();
                            decimal less = n.LessMore(-res);
                            Console.Write("{0}/{1} + {2}%= {3}", n.numerator, n.denominator, p, less);
                            Console.WriteLine();
                            Console.WriteLine();
                            break;

                        case 2:

                            Console.Write("ВВедіть число: ");
                            double numb = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Введіть відсоток: ");
                            double pc = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine();
                            Decimal d = new Decimal(numb);
                            decimal d_find_res = d.Persentage((decimal)pc);
                            Console.Write("{0}% від {1} = {2}", pc, d.number, d_find_res);
                            Console.WriteLine();
                            decimal d_plus_res = d.LessMore(d_find_res);
                            Console.Write("{0} + {1}%= {2}", d.number, pc, d_plus_res);
                            Console.WriteLine();
                            decimal d_minus_res = d.LessMore(-d_find_res);
                            Console.Write("{0} - {1}%= {2}", d.number, pc, d_minus_res);
                            Console.WriteLine();
                            Console.WriteLine();
                            break;

                        case 0:

                            Environment.Exit(9);
                            break;

                        default:

                            Console.WriteLine("Будь ласка, оберіть пункт, що є в меню!");
                            break;
                    }
                }

            
        }
    }   
}
