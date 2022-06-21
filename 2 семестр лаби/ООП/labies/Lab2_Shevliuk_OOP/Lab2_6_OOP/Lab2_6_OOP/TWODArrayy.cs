using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_6_OOP
{
    class TWODArrayy
    {
        public int[,] arr;
        public int columns;
        public int rows;
        public TWODArrayy()
        {
            rows = 2;
            columns = 3;
            arr = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
        }
        public void InpurArray()
        {
            string s;
            Random rnd = new Random();
            Console.Write("Введіть кількість рядків: ");
            s = Console.ReadLine();
           
            rows = Convert.ToInt32(s);
            Console.Write("Введіть кілкість стовбців: ");
            s = Console.ReadLine();
           
            columns = Convert.ToInt32(s);
            arr = new int[rows, columns];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(10, 100);
                }
            }
        }
        public void OutputArray()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void Transform() {
            Console.WriteLine("Трансофрмований масив: ");
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write($"{arr[j, i],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }


public void SortArr(int index)
        {
            switch (index)
            {
                case 1:
                    Console.WriteLine("Ось ваш відсортований масив: ");
                    Sort1();
                    break;
                case 2:
                    Console.WriteLine("Ось ваш відсортований масив: ");
                    Sort2();
                    break;
                case 3:
                    Console.WriteLine("Ось ваш відсортований масив: ");
                    Sort3();
                    break;
                case 4:
                    Transform();
                    break;
                default:
                    Console.WriteLine("Будь ласка, оберіть пункт, який є в меню!\n");
                    break;
            }
            OutputArray();
        }
        public void CopyArr(TWODArrayy a)
        {
            this.arr = a.arr;
        }
        private void Sort3()
        {
            int minVal = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int q = i; q < arr.GetLength(0); q++)
                    {
                        for (int w = (q == i) ? j : 0; w < arr.GetLength(1); w++)   
                        {

                            if (arr[i, j] < arr[q, w])
                            {
                                minVal = arr[q, w];
                                arr[q, w] = arr[i, j];
                                arr[i, j] = minVal;
                            }
                        }
                    }
                }
            }
        }
        private void Sort2()
        {
            int minVal = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int q = i; q < arr.GetLength(0); q++)
                    {
                        for (int w = (q == i) ? j : 0; w < arr.GetLength(1); w++)  
                        {

                            if (arr[i, j] > arr[q, w])
                            {
                                minVal = arr[q, w];
                                arr[q, w] = arr[i, j];
                                arr[i, j] = minVal;
                            }
                        }
                    }
                }
            }
        }
        private void Sort1()
        {
            int x, b;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    x = arr[i, j];
                    for (b = j - 1; b >= 0 && arr[i, b] > x; b--)
                    {
                        arr[i, b + 1] = arr[i, b];
                    }
                    arr[i, b + 1] = x;
                }
            }
        }
        

    }
}
