//Q2: Given a string s, find the length of the longest substring without repeating characters.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    internal class Question_2
    {
        static void Main(string[] args)
        {
            string s1 = "abcabcbb";
            string s2 = "bbbbb";
            string s3 = "pwwkew";

            Console.WriteLine("Length of longest substring without repeating characters in '" + s1 + "': " + LengthOfLongestSubstring(s1));
            Console.WriteLine("Length of longest substring without repeating characters in '" + s2 + "': " + LengthOfLongestSubstring(s2));
            Console.WriteLine("Length of longest substring without repeating characters in '" + s3 + "': " + LengthOfLongestSubstring(s3));
        }

        static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int maxLength = 0;
            int left = 0;
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

            for (int right = 0; right < s.Length; right++)
            {
                if (charIndexMap.ContainsKey(s[right]))
                {
                    left = Math.Max(left, charIndexMap[s[right]] + 1);
                }
                charIndexMap[s[right]] = right;
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }

}

