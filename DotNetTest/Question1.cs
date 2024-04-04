//Q1: Replace each array element by its corresponding rank
//  Given an array of distinct integers, replace each array element by its corresponding rank in the array.

//The minimum array element has the rank 1; the second minimum element has a rank of 2, and so on… For example,



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    internal class Question1
    {
        //
        class Program
        {
            static void Main(string[] args)
            {
                int[] array = { 10, 8, 15, 12, 6, 20, 1 };
                int[] ranks = GetRanks(array);

                Console.WriteLine("Input array: " + string.Join(", ", array));
                Console.WriteLine("Output array: " + string.Join(", ", ranks));
            }
            static int[] GetRanks(int[] array)
            {             
                int[] sortedArray = array.ToArray();
                Array.Sort(sortedArray);
                
                var rankDict = new System.Collections.Generic.Dictionary<int, int>();
               
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    
                    if (!rankDict.ContainsKey(sortedArray[i]))
                    {
                        rankDict.Add(sortedArray[i], i + 1);
                    }
                }
                
                int[] ranks = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    ranks[i] = rankDict[array[i]];
                }
                return ranks;
            }
        }
    }
}
