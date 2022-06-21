using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_6_OOP
{
    class MULTIArray
    {
        public int[,,] arr;
        public int columns;
        public int rows;
        public int width;
        public MULTIArray()
        {
            width = 2;
            rows = 3;
            columns = 4;
            arr = new int[,,]{
                   {
                       { 1, 2, 3, 4 },
                       { 5, 6, 7, 8 },
                       { 9, 10, 11, 12 }
                   },
                   {
                       { 13, 14, 15, 16 },
                       { 17, 18, 19, 20 },
                       { 21, 22, 23, 24 }
                   }
               };
        }
        public void InpurArray()
        {
            string s;
            Random rnd = new Random();
            Console.Write("Введіть кількість рядків: ");
            s = Console.ReadLine();
           
            rows = Convert.ToInt32(s);
            Console.Write("Введіть кількість стовбців: ");
            s = Console.ReadLine();
            
            columns = Convert.ToInt32(s);
            Console.Write("Введіть ширину: ");
            s = Console.ReadLine();
           
            width = Convert.ToInt32(s);
            arr = new int[width, rows, columns];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        arr[i, j, k] = rnd.Next(10, 100);
                    }
                }
            }
        }
        public void OutputArray()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        Console.Write("{0} ", arr[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        public void CopyArr(MULTIArray a)
        {
            this.arr = a.arr;
        }
        public void SortArr()
        {
            for (int k = 0; k < width; k++)
            {
                int minVal = arr[k, 0, 0];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        for (int q = i; q < rows; q++)
                        {
                            for (int w = (q == i) ? j : 0; w < columns; w++)
                            {
                                if (arr[k, i, j] > arr[k, q, w])
                                {
                                    minVal = arr[k, q, w];
                                    arr[k, q, w] = arr[k, i, j];
                                    arr[k, i, j] = minVal;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Ось ваш відсортований масив: ");
            this.OutputArray();
        }
    }
}
