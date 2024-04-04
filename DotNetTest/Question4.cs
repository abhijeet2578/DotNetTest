

//Q4: You are given an array of integers. 
//Write a C# program to find the frequency of each unique element in the array and 
//store the results in a dictionary where the key is the element and the value is its frequency.
//Then, print the elements and their frequencies.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    internal class Question4
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            Dictionary<int, int> frequencyMap = GetFrequency(numbers);

            Console.WriteLine("Element frequencies:");
            foreach (var kvp in frequencyMap)
            {
                Console.WriteLine($"Element: {kvp.Key}, Frequency: {kvp.Value}");
            }
        }

        static Dictionary<int, int> GetFrequency(int[] numbers)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            return frequencyMap;
        }

    }
}
