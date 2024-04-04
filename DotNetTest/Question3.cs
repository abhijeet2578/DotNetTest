//Q3:Find non-repeating characters in a string
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    internal class Question3
    {
        
    static void Main(string[] args)
        {
            string input = "aabbccdefgghhii";
            List<char> nonRepeatingChars = FindNonRepeatingChars(input);

            Console.WriteLine("Non-repeating characters in the string '" + input + "':");
            foreach (char c in nonRepeatingChars)
            {
                Console.WriteLine(c);
            }
        }

        static List<char> FindNonRepeatingChars(string input)
        {
            List<char> nonRepeatingChars = new List<char>();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

          
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            foreach (KeyValuePair<char, int> kvp in charCount)
            {
                if (kvp.Value == 1)
                    nonRepeatingChars.Add(kvp.Key);
            }

            return nonRepeatingChars;
        }
    }


}
