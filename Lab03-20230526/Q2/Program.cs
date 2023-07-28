using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static int vowel(string word)
        {
            int Vowelcount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (
                    (word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
                    ||
                    (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                   )
                    
                    
                    Vowelcount++;
            }
            return Vowelcount;
        }
        static void Main(string[] args)
        {
            int vowels = 0;
            string word = "";

            Console.Write("Enter a word: ");
            word = Console.ReadLine();

            vowels = vowel(word);
            Console.WriteLine("Vowel Count: " + vowels);
        }
    }
}
