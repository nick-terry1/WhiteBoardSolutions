using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// author: nick terry
// date: may 31, 2018
// description: this program randomly generates numbers from 0 - 10000 until it generates 10000. Then it prints every value to 
// the screen in order.

namespace TenThousandGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // the array 'test' will hold all the numbers generated in the form of a 1 in the index of the number generated.
            byte[] test = new byte[1250];
            Random temp = new Random();

            // the upper bound is 10001 and therefore the highest number allowed is 10000.
            int x = temp.Next(10001);

            while (x != 10000)
            {
                // dividing by the number of bits in a byte (8) will find the correct index in the array 'test'
                int arrayindex = x / 8;

                // modulating by the number of bits in a byte (8) will find the correct index in the byte
                int bitindex = x % 8;

                // ORing 1 with whatever number is already at the bit index will set the bit regardless
                test[arrayindex] |= (byte)(1 << bitindex);
                x = temp.Next(10001);
            }
            

            for (int i = 0; i < test.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    // testing every bit in the entire byte array
                    if ((test[i] & (1 << j)) != 0)
                    {
                        // printing the values as space seperated integers
                        Console.Write((i * 8 + j) + " ");
                    }
                }
            }

            // printing this value will always signal the end of the program
            Console.WriteLine(10000);
        }
    }
}
