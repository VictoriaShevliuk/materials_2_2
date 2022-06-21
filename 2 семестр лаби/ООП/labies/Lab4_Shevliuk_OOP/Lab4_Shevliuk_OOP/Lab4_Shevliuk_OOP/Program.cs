using System;
using System.Collections.Generic;

namespace Lab4_Shevliuk_OOP
{
    class Program
    {

        private class Result : Program
        {
            public Result()
            {
                Vowel = 0;
                Consonant = 0;
            }
            public int Vowel { get; set; }
            public int Consonant { get; set; }
        }

        private static bool isVowel(char c)
        {
            return c == 'a' || c == 'e' ||
                    c == 'i' || c == 'o' ||
                    c == 'u' || c == 'A' ||
                    c == 'E' || c == 'I' ||
                    c == 'O' || c == 'U';
        }

        static void PrintResult(Result res)
        {
            Console.WriteLine("Кiлькiсть голосних: " + res.Vowel);
            Console.WriteLine("Кiлькiсть приголосних: " + res.Consonant);
        }

        static Result VowCons(char[] inputstring)
        {
            Result res = new Result();
            foreach (char c in inputstring)
            {
                if (Char.IsLetter(c))
                {
                    if (isVowel(c) == true) { res.Vowel++; }
                    else { res.Consonant++; };
                }

            }
            return res;
        }

        static Result VowConsList(List<char> inputstring)
        {
            Result res = new Result();
            int vowelCounter = 0;
            int consonantCounter = 0;
            Console.WriteLine("List:");
            foreach (char c in inputstring)
            {
                if (Char.IsLetter(c))
                {
                    if (isVowel(c) == true) { Console.WriteLine(c); vowelCounter++; }
                    else { Console.WriteLine(c); consonantCounter++; };
                }

            }
            res.Vowel = vowelCounter;
            res.Consonant = consonantCounter;
            return res;
        }




        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\mytext.txt");
            Console.WriteLine("Text: " + text);

            char[] inputstring = text.ToCharArray();

            Result res = VowCons(inputstring);
            PrintResult(res);


            List<char> list = new List<char>();
            foreach (char c in inputstring) { list.Add(c); };
            Result res_list = VowConsList(list);
          
            PrintResult(res_list);

        }
    }
}
