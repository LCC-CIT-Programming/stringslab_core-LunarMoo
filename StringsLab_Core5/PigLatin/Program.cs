using System;
using System.Text.RegularExpressions;

namespace PigLatin
{
    class Program
    {
		static void Main(string[] args)
		{

			Console.WriteLine("Please enter a word or phrase.  Press the ENTER key when you're done.");
			string input = Console.ReadLine();
			/*
			// uppercase and lowercase
			string lower = input.ToLower();
			Console.WriteLine("Converted to lowercase: " + lower);
			string upper = input.ToUpper();
			Console.WriteLine("Converted to uppercase: " + upper);

			// iterate through a string with a foreach loop
			string reverse = "";
			foreach (char c in input)
				reverse = c + reverse;
			Console.WriteLine("In reverse: " + reverse);

			// use Char method.  Note that most of the Char methods are static - they get called on a CLASS
			// Math.pow is a static method.  gen.Next(..) gets called on a random OBJECT and is NOT static
			int pCount = 0;
			foreach (char c in input)
				if (Char.IsPunctuation(c))
					pCount++;
			Console.WriteLine("Puncutation count: " + pCount);

			// find the index of the first vowel in a string
			// see the method IsVowel below
			int vIndex = -1;
			// a string has a Length property  - just like an array
			for (int i = 0; i < input.Length && vIndex == -1; i++)
			{
				char c = input[i];
				if (IsVowel(c))
					vIndex = i;
			}
			Console.WriteLine("The index of the first vowel is: " + vIndex);
			// create an array of strings from a string.  Default delimiter is white space.
			string[] words = input.Split();
			foreach (string word in words)
			Console.WriteLine(word);

			string pig1 = PigLatin1(input);
			Console.WriteLine("The word {0} in pig latin is: {1}", input, pig1);

			string pig2 = PigLatin2(input);
			Console.WriteLine("The word {0} in pig latin is: {1}", input, pig2);


			*/
			
			string pig = Piglatin3(input);
			Console.WriteLine("The word {0} in pig latin is: {1}", input, pig);
			
		}
		static bool IsVowel(char c)
		{
			switch (c)
			{
				case 'A':
				case 'a':
				case 'E':
				case 'e':
				case 'I':
				case 'i':
				case 'O':
				case 'o':
				case 'U':
				case 'u':
				case 'y':
				case 'Y':
					return true;
				default:
					return false;
			}
		}
		static string PigLatin1(string s) // For Part1
		{
			string pig = s.Substring(1) + s[0] + "ay";
			return pig;
		}
		static string PigLatin2(string s) // For Part1
		{
			string pig;
			if (IsVowel(s[0]))
				pig = s + "way";
			else
				pig = s.Substring(1) + s[0] + "ay";
			return pig;
		}
		static string Piglatin3(string s)
		{
			
			string pig = "";
			int indexofLast = s.Length - 1;
			char last = s[indexofLast];
			bool punc = false;
            if (char.IsPunctuation(last))
            {
				punc = true;
				s = s.Substring(0, indexofLast);  
            }
			bool isUpper = false;
			if (char.IsUpper(s[0]))
			{
				isUpper = true;
			}
			s = s.ToLower();

			int index = IndexOfFirstVowel(s);
			if (index == 0)
				pig = s + "way";
			else
				pig = s.Substring(index) + s.Substring(0, index) + "ay";
			if (isUpper == true)
				pig = pig.Substring(0, 1).ToUpper() + pig.Substring(1);
			if (punc == true)
				pig = pig + last;

			return pig;
			
		}
		static int IndexOfFirstVowel(string s)
		{
			int index = -1;
			for (index = 0; index < s.Length; index++)
			{
				if (IsVowel(s[index]))
					return index;
			}
			return -1;
		}
		
	}
}

