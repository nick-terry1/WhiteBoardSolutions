using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// author: nick terry
// date: apr 20, 2018

// This program will take a string of lowercase letters only and return the length of its longest substring. For example
// a string of abacebdc would return a value of 5, a string of bbbbb would return a value of 1, and a string of ababcbc would
// return a value of 3.

namespace Substring
{
    class Solution
    {
        static void Main(string[] args)
        {
            // a sample input and output printed to the screen for testing
            string sample = "abacebdc";
            Console.WriteLine(LengthOfLongestSubstring(sample));

        }

        public static int LengthOfLongestSubstring(string sample)
        {
            try
            {
                if (sample == "")
                {
                    return 0;
                }
                int result = 0;
                // length nicer looking than sample.Length so I created a seperate variable for it
                int length = sample.Length;

                for (int i = 0; i < length; i++)
                {
                    // checking 'substring' against 'check'
                    StringBuilder substring = new StringBuilder(sample);
                    StringBuilder check = new StringBuilder();
                    // removing all the previously checked letters
                    substring.Remove(0, i);

                    for (int j = i; j < length; j++)
                    {
                        check.Append(substring[0]);
                        substring.Remove(0, 1);
                        // if any of the letters in 'check' are the next letter in 'substring' aka index 0 compare with result and break the loop
                        if (substring.ToString().IndexOfAny(check.ToString().ToCharArray()) == 0)
                        {
                            if (result < check.Length)
                                result = check.Length;
                            break;
                        }
                    }
                }
                return result;
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                return -1;
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return -1;
            }
        }
    }
}
