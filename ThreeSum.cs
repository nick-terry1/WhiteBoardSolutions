using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// author: nick terry
// date: apr 21, 2018

// This is a brute force solution that will take an integer array and find all number combinations that equal zero 
// and return them in a List<int[]> while excluding duplicate triplets. Exceptions like null values, format errors, invalid 
// array sizes not allowed. 

namespace _3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sampleAr = new int[] { -1, 0, 1, 2, -1, -4 };

            // printing each answer to the console
            foreach (int[] trip in ThreeSum(sampleAr))
            {
                foreach (int num in trip)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }

        public static List<int[]> ThreeSum(int[] ar)
        {
            List<int[]> triplets = new List<int[]>();

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    for (int k = j + 1; k < ar.Length; k++)
                    {
                        if (ar[i] + ar[j] + ar[k] == 0)
                        {
                            int[] temp = new int[] { ar[i], ar[j], ar[k] };
                            Array.Sort(temp);
                            if (triplets.Count == 0)
                                triplets.Add(temp);
                            int count = 0;
                            foreach (int[] trip in triplets)
                            {
                                // adding a value to triplets while iterating through it returns an error here so count was added
                                if (!temp.SequenceEqual(trip))
                                {
                                    count++;
                                }
                            }
                            if (count == triplets.Count)
                            {
                                triplets.Add(temp);
                            }
                        }
                    }
                }
            }
            return triplets;
        }
    }
}
