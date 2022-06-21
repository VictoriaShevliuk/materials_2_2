using System;
using System.Text;

namespace lab9
{
    class Program
    {

        public static class RC4
        {
            public static byte[] Apply(byte[] data, byte[] key)
            {
                int[] S = new int[256];
                for (int _ = 0; _ < 256; _++)
                {
                    S[_] = _;
                }

                int[] T = new int[256];

                if (key.Length == 256)
                {
                    Buffer.BlockCopy(key, 0, T, 0, key.Length);
                }
                else
                {
                    for (int _ = 0; _ < 256; _++)
                    {
                        T[_] = key[_ % key.Length];
                    }
                }

                int i = 0;
                int j = 0;
                for (i = 0; i < 256; i++)
                {
                    j = (j + S[i] + T[i]) % 256;
                    int temp = S[i];
                    S[i] = S[j];
                    S[j] = temp;
                }

                i = j = 0;
                byte[] result = new byte[data.Length];
                for (int iteration = 0; iteration < data.Length; iteration++)
                {
                    i = (i + 1) % 256;
                    j = (j + S[i]) % 256;

                    int temp = S[i];
                    S[i] = S[j];
                    S[j] = temp;

                    int K = S[(S[i] + S[j]) % 256];
                    result[iteration] = Convert.ToByte(data[iteration] ^ K);
                }

                return result;
            }
        }


        static void Main(string[] args)
        {
            string phrase = "Viktoria Shevliuk PP22";

            string key_phrase = "What do you eat for breakfast?";

            byte[] data = Encoding.UTF8.GetBytes(phrase);

            byte[] key = Encoding.UTF8.GetBytes(key_phrase);

            byte[] encrypted_data = RC4.Apply(data, key);

            byte[] decrypted_data = RC4.Apply(encrypted_data, key);

            string decrypted_phrase = Encoding.UTF8.GetString(decrypted_data);

            Console.WriteLine("Phrase:\t\t\t{0}", phrase);
            Console.WriteLine("Phrase Bytes:\t\t{0}", BitConverter.ToString(data));
            Console.WriteLine("Key Phrase:\t\t{0}", key_phrase);
            Console.WriteLine("Key Bytes:\t\t{0}", BitConverter.ToString(key));
            Console.WriteLine("Encryption Result:\t{0}", BitConverter.ToString(encrypted_data));
            Console.WriteLine("Decryption Result:\t{0}", BitConverter.ToString(decrypted_data));
            Console.WriteLine("Decrypted Phrase:\t{0}", decrypted_phrase);

            Console.WriteLine(Environment.NewLine + "Press enter to close");
            Console.ReadLine();

        }
    }
}
