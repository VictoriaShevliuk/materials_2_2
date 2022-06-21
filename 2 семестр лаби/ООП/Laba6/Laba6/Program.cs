using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    class TArray
    {
        public List<int> arr;
        public TArray()
        {
            arr = new List<int>() { 2, 3, 9, 9, 6 };
        }
        public TArray(List<int> arr)
        {
            this.arr = arr;
        }
        public TArray(TArray a)
        {
            arr = a.arr;
        }
        public void Input()
        {
            string s;
            Random rnd = new Random();
            Console.Write("Enter the size of the array: ");
            s = Console.ReadLine();
            while (IsInt(s, 1) == false)
            {
                Console.Write("Error!!! Enter the size of the array: ");
                s = Console.ReadLine();
            }
            int length = Convert.ToInt32(s);
            arr = new List<int>(length);
            for (int i = 0; i < length; i++)
            {
                arr.Add(rnd.Next(0, 10));
            }
        }
        public void Output()
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
            Console.WriteLine("\nThe max element = " + max);
            Console.WriteLine("The min element = " + min);
        }
        public void Sort()
        {
            arr.Sort();
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < arr.Count(); i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }        
        private bool IsInt(string sVal, int func)
        {
            if (String.IsNullOrEmpty(sVal))
            {
                return false;
            }
            foreach (char c in sVal)
            {
                int iN = (int)c;
                if ((iN > 57) || (iN < 48))
                    return false;
            }
            if (func == 1)
            {
                int num = int.Parse(sVal);
                if (num > 9 || num < 1)
                    return false;
            }
            return true;
        }
    }
    class TwoArray
    {
        public int[,] arr;
        public int columns;
        public int rows;
        public TwoArray()
        {
            rows = 2;
            columns = 3;
            arr = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
        }       
        public void Input()
        {
            string s;
            Random rnd = new Random();
            Console.Write("Enter the number of rows: ");
            s = Console.ReadLine();
            while (IsInt(s, 1) == false)
            {
                Console.Write("Error!!! Enter the number of rows: ");
                s = Console.ReadLine();
            }
            rows = Convert.ToInt32(s);
            Console.Write("Enter the number of columns: ");
            s = Console.ReadLine();
            while (IsInt(s, 1) == false)
            {
                Console.Write("Error!!! Enter the number of columns: ");
                s = Console.ReadLine();
            }
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
        public void Output()
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
        public void Sort(int index)
        {            
            switch (index)
            {
                case 1:
                    Sort1();
                    break;
                case 2:
                    Sort2();
                    break;
                case 3:
                    Sort3();                    
                    break;               
                default:
                    Console.WriteLine("An unknown menu item was selected\n");
                    break;
            }            
            Console.WriteLine("Sorted array: ");
            this.Output();
        }
        public void Copy(TwoArray a)
        {
            this.arr = a.arr;
        }
        private void Sort3()
        {
            int minVal = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)// перечисление строк
            {
                for (int j = 0; j < arr.GetLength(1); j++)// перечисление символов(столбцов)
                {
                    for (int q = i; q < arr.GetLength(0); q++)//перечесления строк для проверки
                    {
                        for (int w = (q == i) ? j : 0; w < arr.GetLength(1); w++)   // перечесление смиволов для проверки (исключаем проверенные и заменннеые символы)
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
            for (int i = 0; i < arr.GetLength(0); i++)// перечисление строк
            {
                for (int j = 0; j < arr.GetLength(1); j++)// перечисление символов(столбцов)
                {
                    for (int q = i; q < arr.GetLength(0); q++)//перечесления строк для проверки
                    {
                        for (int w = (q == i) ? j : 0; w < arr.GetLength(1); w++)   // перечесление смиволов для проверки (исключаем проверенные и заменннеые символы)
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
        private bool IsInt(string sVal, int func)
        {
            if (String.IsNullOrEmpty(sVal))
            {
                return false;
            }               
            foreach (char c in sVal)
            {
                int iN = (int)c;
                if ((iN > 57) || (iN < 48))
                    return false;
            }
            if (func == 1)
            {
                int num = int.Parse(sVal);
                if (num > 9 || num < 2)
                    return false;
            }
            return true;
        }
    }
    class ThreeArray
    {
        public int[,,] arr;
        public int columns;
        public int rows;
        public int height;
        public ThreeArray()
        {
            height = 2;
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
        public void Input()
        {
            string s;
            Random rnd = new Random();
            Console.Write("Enter the number of rows: ");
            s = Console.ReadLine();
            while (IsInt(s, 1) == false)
            {
                Console.Write("Error!!! Enter the number of rows: ");
                s = Console.ReadLine();
            }
            rows = Convert.ToInt32(s);
            Console.Write("Enter the number of columns: ");
            s = Console.ReadLine();
            while (IsInt(s, 1) == false)
            {
                Console.Write("Error!!! Enter the number of columns: ");
                s = Console.ReadLine();
            }
            columns = Convert.ToInt32(s);
            Console.Write("Enter height: ");
            s = Console.ReadLine();
            while (IsInt(s, 1) == false)
            {
                Console.Write("Error!!! Enter height: ");
                s = Console.ReadLine();
            }
            height = Convert.ToInt32(s);
            arr = new int[height, rows, columns];
            for (int i = 0; i < height; i++)
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
        public void Output()
        {
            for (int i = 0; i < height; i++)
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
        public void Copy(ThreeArray a)
        {
            this.arr = a.arr;
        }
        public void Sort()
        {
            for(int k = 0; k < height; k++)
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
                                    arr[k, q , w] = arr[k, i, j];
                                    arr[k, i, j] = minVal;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Sorted array: ");
            this.Output();
        }
        private bool IsInt(string sVal, int func)
        {
            if (String.IsNullOrEmpty(sVal))
            {
                return false;
            }
            foreach (char c in sVal)
            {
                int iN = (int)c;
                if ((iN > 57) || (iN < 48))
                    return false;
            }
            if (func == 1)
            {
                int num = int.Parse(sVal);
                if (num > 9 || num < 2)
                    return false;
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {           
            bool result = true;            
            while (result)
            {
                Console.Clear();
                Console.WriteLine("1.One-Array");
                Console.WriteLine("2.Two-Array");
                Console.WriteLine("3.Multi-Array");               
                Console.WriteLine("4.Exit");
                int index;
                string s = InputNum();
                index = Convert.ToInt32(s);
                switch (index)
                {
                    case 1:                        
                        One_Array();                        
                        break;
                    case 2:
                        Two_Array();
                        Console.ReadLine();
                        break;
                    case 3:
                        Three_Array();
                        Console.ReadLine();
                        break;
                    case 4:
                        result = false;
                        break;
                    default:
                        Console.WriteLine("An unknown menu item was selected\n");
                        break;
                }
            }
        }
        private static void Three_Array()
        {
            Random rand = new Random();
            ThreeArray[] ars = new ThreeArray[2];
            for (int i = 0; i < 2; i++)
            {
                ars[i] = new ThreeArray();
                Console.WriteLine("\tArray " + (i + 1));
                ars[i].Input();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\tArray " + (i + 1));
                ars[i].Output();
                ars[i].Sort();
            }
            if (ars[0].rows == ars[1].rows && ars[0].columns == ars[1].columns && ars[0].height == ars[1].height)
            {
                Console.WriteLine("1.Copy Arr1 to Arr2");
                Console.WriteLine("2.Copy Arr2 to Arr1");
                int index;
                string s = InputNum();
                index = Convert.ToInt32(s);
                switch (index)
                {
                    case 1:
                        ars[1].Copy(ars[0]);
                        Console.WriteLine("\tArray 2");
                        ars[1].Output();
                        break;
                    case 2:
                        ars[0].Copy(ars[1]);
                        Console.WriteLine("\tArray 1");
                        ars[0].Output();
                        break;
                }
            }
        }
        private static void Two_Array()
        {            
            Random rand = new Random();
            TwoArray[] ars = new TwoArray[2];
            for (int i = 0; i < 2; i++)
            {
                ars[i] = new TwoArray();
                Console.WriteLine("\tArray " + (i + 1));
                ars[i].Input();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\tArray " + (i + 1));
                ars[i].Output();
                Console.WriteLine("1.Sort by rows");
                Console.WriteLine("2.Sort in ascending order");
                Console.WriteLine("3.Sort in descending order");
                string s = InputNum();
                int x = Convert.ToInt32(s);
                ars[i].Sort(x);
            }
            if (ars[0].rows == ars[1].rows && ars[0].columns == ars[1].columns)
            {
                Console.WriteLine("1.Copy Arr1 to Arr2");
                Console.WriteLine("2.Copy Arr2 to Arr1");
                int index;
                string s = InputNum();
                index = Convert.ToInt32(s);
                switch (index)
                {
                    case 1:
                        ars[1].Copy(ars[0]);
                        Console.WriteLine("\tArray 2");
                        ars[1].Output();
                        break;
                    case 2:
                        ars[0].Copy(ars[1]);
                        Console.WriteLine("\tArray 1");
                        ars[0].Output();
                        break;
                }
            }
        }
        private static void One_Array()
        {
            Random rand = new Random();
            TArray[] ars = new TArray[2];
            for (int i = 0; i < 2; i++)
            {
                ars[i] = new TArray();
                Console.WriteLine("\tArray " + (i + 1));
                ars[i].Input();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\tArray " + (i + 1));
                ars[i].Output();                
                ars[i].MinMax();
                ars[i].Sort();
            }
            bool result = true;
            int element;
            while (result)
            {
                Console.WriteLine("\n1.Add to Arr");
                Console.WriteLine("2.Remove from Arr");
                Console.WriteLine("3.Copy Arr1 to Arr2");
                Console.WriteLine("4.Copy Arr2 to Arr1");
                Console.WriteLine("5.Exit");
                int index;
                string s = InputNum();
                index = Convert.ToInt32(s);
                switch (index)
                {
                    case 1:
                        Console.WriteLine("1.Add to Arr1");
                        Console.WriteLine("2.Add to Arr2");
                        s = InputNum();
                        index = Convert.ToInt32(s);
                        if (index == 1)
                        {
                            s = InputNum();
                            element = Convert.ToInt32(s);
                            ars[0].arr.Add(element);
                            ars[0].Output();
                            break;
                        }
                        else if (index == 2)
                        {
                            s = InputNum();
                            element = Convert.ToInt32(s);
                            ars[1].arr.Add(element);
                            ars[1].Output();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("An unknown menu item was selected\n");
                            break;
                        }
                    case 2:
                        Console.WriteLine("1.Remove from Arr1");
                        Console.WriteLine("2.Remove from Arr2");
                        s = InputNum();
                        index = Convert.ToInt32(s);
                        if (index == 1)
                        {
                            s = InputNum();
                            element = Convert.ToInt32(s);
                            if (ars[0].arr.Contains(element) == true)
                            {
                                ars[0].arr.Remove(element);
                                ars[0].Output();
                            }
                            else
                            {
                                Console.WriteLine("There is no such item in the array\n");
                            }
                            break;
                        }
                        else if (index == 2)
                        {
                            s = InputNum();
                            element = Convert.ToInt32(s);
                            if (ars[1].arr.Contains(element) == true)
                            {
                                ars[1].arr.Remove(element);
                                ars[1].Output();
                            }
                            else
                            {
                                Console.WriteLine("There is no such item in the array\n");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("An unknown menu item was selected\n");
                            break;
                        }
                    case 3:
                        ars[1].arr.AddRange(ars[0].arr);
                        Console.WriteLine("\tArray 2");
                        ars[1].Output();
                        break;
                    case 4:
                        ars[0].arr.AddRange(ars[1].arr);
                        Console.WriteLine("\tArray 1");
                        ars[0].Output();
                        break;
                    case 5:
                        result = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("An unknown menu item was selected\n");
                        break;
                }
            }
        }
        private static string InputNum()
        {
            string s;
            Console.Write("Enter the number: ");
            s = Console.ReadLine();
            while (IsInt(s, 1) == false)
            {
                Console.Write("Error!!! Enter the number: ");
                s = Console.ReadLine();
            }
            return s;
        }
        public static bool IsInt(string sVal, int func)
        {
            if (String.IsNullOrEmpty(sVal))
            {
                return false;
            }
            foreach (char c in sVal)
            {
                int iN = (int)c;
                if ((iN > 57) || (iN < 48))
                    return false;
            }
            if (func == 2)
            {
                int num = int.Parse(sVal);
                if (num > 9 || num < 0)
                    return false;
            }
            return true;
        }
    }
}
