using System;
using System.IO;
using System.Text;


namespace lab7
{
    class Program
    {
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }


        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);
            File.WriteAllTextAsync("encipher.txt", output);
            return output;
        }

        public static string Decipher(string input, int key)
        {
            File.WriteAllTextAsync("decipher.txt", Encipher(input, 26 - key));
            return Encipher(input, 26 - key);
        }

        public static string Bruteforce(string input)
        {
            string output = string.Empty;

            for (int bruteKey = 0; bruteKey < 26; bruteKey++)
            {
                foreach (char ch in input)
                    output += cipher(ch, bruteKey);
            }

            File.WriteAllTextAsync("bruteforce.txt", output);
            return output;
        }

        public static string XOREncryptOrDecrypt(string text, string key)
        {
            var result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
                result.Append((char)((uint)text[c] ^ (uint)key[c % key.Length]));

            File.WriteAllTextAsync("xor.txt", Convert.ToString(result));
            return result.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Type a string to encrypt:");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Write("Enter your Key");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Encrypted Data");

            string cipherText = Encipher(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Decrypted Data:");

            string t = Decipher(cipherText, key);
            Console.WriteLine(t);
            Console.Write("\n");

            string bruteForceCipherText = File.ReadAllText("encipher.txt");
            string y = Bruteforce(bruteForceCipherText);
            Console.WriteLine(y);
            Console.Write("\n");


            Console.WriteLine("Enter the key for XOR encryption");
            string xorKey = Console.ReadLine();
            Console.WriteLine(XOREncryptOrDecrypt(UserString, xorKey));

            Console.WriteLine("Enter the key for XOR decryption");
            string xorDecryptKey = Console.ReadLine();
            string xorEncrypted = File.ReadAllText("xor.txt");
            Console.WriteLine(XOREncryptOrDecrypt(xorEncrypted, xorDecryptKey));

            Console.ReadKey();

        }
    }
}
