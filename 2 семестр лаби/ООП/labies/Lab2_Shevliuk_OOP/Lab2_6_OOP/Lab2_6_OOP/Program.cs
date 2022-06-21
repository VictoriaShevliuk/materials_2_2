using System;

namespace Lab2_6_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            while (result)
            {
                Console.WriteLine("Оберіть, з яким масивом ви хочете працювати: \n\n");
                Console.WriteLine("1.Одновимірний");
                Console.WriteLine("2.Двовимірний");
                Console.WriteLine("3.Багатовимірний");
                Console.WriteLine("4.Завершити роботу програми");
                int ind;
                string s = InputNum();
                ind = Convert.ToInt32(s);
                switch (ind)
                {
                    case 1:
                        ONEDArray();
                        break;
                    case 2:
                        TWODArrayy();
                        Console.ReadLine();
                        break;
                    case 3:
                        MULTIArray();
                        Console.ReadLine();
                        break;
                    case 4:
                        result = false;
                        break;
                    default:
                        Console.WriteLine("Будь ласка, оберіть пункт, який є в меню!\n");
                        break;
                }
            }

            
        }

        private static void MULTIArray()
        {
            Random rand = new Random();
            MULTIArray[] ars = new MULTIArray[2];
            for (int i = 0; i < 2; i++)
            {
                ars[i] = new MULTIArray();
                Console.WriteLine("\tArray " + (i + 1));
                ars[i].InpurArray();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\tArray " + (i + 1));
                ars[i].OutputArray();
                ars[i].SortArr();
            }
            if (ars[0].rows == ars[1].rows && ars[0].columns == ars[1].columns && ars[0].width == ars[1].width)
            {
                Console.WriteLine("1.Скопіювати Array 1 в Array 2");
                Console.WriteLine("2.Скопіювати Array 2 в Array 1");
                int index;
                string s = InputNum();
                index = Convert.ToInt32(s);
                switch (index)
                {
                    case 1:
                        ars[1].CopyArr(ars[0]);
                        Console.WriteLine("\tArray 2");
                        ars[1].OutputArray();
                        break;
                    case 2:
                        ars[0].CopyArr(ars[1]);
                        Console.WriteLine("\tArray 1");
                        ars[0].OutputArray();
                        break;
                }
            }
        }
        private static void TWODArrayy()
        {
            Random rand = new Random();
            TWODArrayy[] ars = new TWODArrayy[2];
            for (int i = 0; i < 2; i++)
            {
                ars[i] = new TWODArrayy();
                Console.WriteLine("\tArray " + (i + 1));
                ars[i].InpurArray();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\tArray " + (i + 1));
                ars[i].OutputArray();
                Console.WriteLine("1.Відсортувати за рядками");
                Console.WriteLine("2.Відсортувати за збільшенням");
                Console.WriteLine("3.Відсортувати за зменшенням");
                Console.WriteLine("4. Трансофрмувати");
                string s = InputNum();
                int x = Convert.ToInt32(s);
                ars[i].SortArr(x);
            }
            if (ars[0].rows == ars[1].rows && ars[0].columns == ars[1].columns)
            {
                Console.WriteLine("1. Скопіювати Array 1 в Array 2");
                Console.WriteLine("2. Скопіювати Array 2 в Array 1");
                int index;
                string s = InputNum();
                index = Convert.ToInt32(s);
                switch (index)
                {
                    case 1:
                        ars[1].CopyArr(ars[0]);
                        Console.WriteLine("\tArray 2");
                        ars[1].OutputArray();
                        break;
                    case 2:
                        ars[0].CopyArr(ars[1]);
                        Console.WriteLine("\tArray 1");
                        ars[0].OutputArray();
                        break;
                }
            }
        }
        private static void ONEDArray()
        {
            Random rand = new Random();
            ONEDArray[] ars = new ONEDArray[2];
            for (int i = 0; i < 2; i++)
            {
                ars[i] = new ONEDArray();
                Console.WriteLine("\tArray " + (i + 1));
                ars[i].InpurArray();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\tArray " + (i + 1));
                ars[i].OutputArray();
                ars[i].MinMax();
                ars[i].SortArr();
            }
            bool result = true;
            int elem;
            while (result)
            {
                Console.WriteLine("\n1.Додати число до масиву");
                Console.WriteLine("2.Видалити число з масиву");
                Console.WriteLine("3. Скопіювати Array 1 в Array 2");
                Console.WriteLine("4. Скопіювати Array 2 в Array 1");
                Console.WriteLine("5.Exit");
                int ind;
                string a = InputNum();
                ind = Convert.ToInt32(a);
                switch (ind)
                {
                    case 1:
                        Console.WriteLine("1.Додати до масиву Array 1");
                        Console.WriteLine("2.Додати до масиву Array 2");
                        a = InputNum();
                        ind = Convert.ToInt32(a);
                        if (ind == 1)
                        {
                            a = InputNum();
                            elem = Convert.ToInt32(a);
                            ars[0].arr.Add(elem);
                            ars[0].OutputArray();
                            break;
                        }
                        else if (ind == 2)
                        {
                            a = InputNum();
                            elem = Convert.ToInt32(a);
                            ars[1].arr.Add(elem);
                            ars[1].OutputArray();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Будь ласка, оберіть пункт, який є в меню!\n");
                            break;
                        }
                    case 2:
                        Console.WriteLine("1.Видалити число з Array1");
                        Console.WriteLine("2.Видалити число з Array2");
                        a = InputNum();
                        ind = Convert.ToInt32(a);
                        if (ind == 1)
                        {
                            a = InputNum();
                            elem = Convert.ToInt32(a);
                            if (ars[0].arr.Contains(elem) == true)
                            {
                                ars[0].arr.Remove(elem);
                                ars[0].OutputArray();
                            }
                            else
                            {
                                Console.WriteLine("Такого числа немає в масиві!\n");
                            }
                            break;
                        }
                        else if (ind == 2)
                        {
                            a = InputNum();
                            elem = Convert.ToInt32(a);
                            if (ars[1].arr.Contains(elem) == true)
                            {
                                ars[1].arr.Remove(elem);
                                ars[1].OutputArray();
                            }
                            else
                            {
                                Console.WriteLine("Такого числа немає в масиві!\n");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Будь ласка, оберіть пункт, який є в меню!\n");
                            break;
                        }
                    case 3:
                        ars[1].arr.AddRange(ars[0].arr);
                        Console.WriteLine("\tArray 2");
                        ars[1].OutputArray();
                        break;
                    case 4:
                        ars[0].arr.AddRange(ars[1].arr);
                        Console.WriteLine("\tArray 1");
                        ars[0].OutputArray();
                        break;
                    case 5:
                        result = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Будь ласка, оберіть пункт, який є в меню!\n");
                        break;
                }
            }
        }
        private static string InputNum()
        {
            string a;
            Console.Write("Ваш вибір: ");
            a = Console.ReadLine();

            return a;
        }


    }
}
