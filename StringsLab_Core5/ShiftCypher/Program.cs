using System;

namespace ShiftCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "zoo";
            int shift = 3;
            string output = ShiftCypher(input, shift);
            Console.WriteLine(output);
        }
        static string ShiftCypher(string s, int shift)
        {
            string encodedS = "";
            foreach (char c in s)
            {
                if (char.IsLetter(c))
                {
                    int ascii = (int)c;
                    ascii += shift;

                    if (ascii >= (int)'a' && ascii < (int)'z')
                    {
                        char shiftedC = (char)ascii;
                        encodedS += shiftedC;
                    }
                    else
                    {
                        char shiftedC = (char)(ascii - 26);
                        encodedS += shiftedC;
                    }

                }
                else
                {
                    encodedS += c;
                }

            }
            return encodedS;
        }
    }
}
