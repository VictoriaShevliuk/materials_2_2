using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Lab2_6_OOP
{
    class ONEDArray
    {
        public List<int> arr;
        public ONEDArray()
        {
            arr = new List<int>() { 2, 3, 9, 9, 6 };
        }
        public ONEDArray(List<int> arr)
        {
            this.arr = arr;
        }
        public ONEDArray(ONEDArray a)
        {
            arr = a.arr;
        }
        public void InpurArray()
        {
            string a;
            Random rnd = new Random();
            Console.Write("Введіть розмір масиву: ");
            a = Console.ReadLine();
        
            int length = Convert.ToInt32(a);
            arr = new List<int>(length);
            for (int i = 0; i < length; i++)
            {
                arr.Add(rnd.Next(0, 10));
            }
        }
        public void OutputArray()
        {
            for (int i = 0; i < arr.Count(); i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void MinMax()
        {
            int max = arr.Max<int>();
            int min = arr.Min<int>();
            Console.WriteLine("\nНайбільший елемент масиву: " + max);
            Console.WriteLine("\nНайменший елемент масиву " + min);
        }
        public void SortArr()
        {
            arr.Sort();
            Console.WriteLine("Ось ваш відсортований масив: ");
            for (int i = 0; i < arr.Count(); i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
       
    }
}
