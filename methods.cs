using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    internal class methods
    {
        public static int Search(int[] array, int k)
        {
            int output = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (Array.Exists(array, element => element == k))
                {
                    if (array[i] == k)
                    {
                        output = i;
                        Console.WriteLine("Student #" + (i + 1) + " earns " + k + "%");

                    }
                }
                else
                {
                    Console.WriteLine("None of the students earn " + k + "%");
                    break;
                }
                
            }
            return output;
        }
        public static int integerPower(int baseval, int exponent)
        {
            int output = baseval;
            for (int i = 0; i < exponent; i++)
            {
                output *= baseval;
            }
            return output;
        }
        static void Main(string[] args)
        {
            int[] scores = { 1, 2, 3, 4, 100, 6, 7, 8, 9, 10, 11, 12, 13
                    , 14, 15, 16, 17, 18, 100, 20, 100, 22, 23, 24, 25, 26 };
             Search(scores, 100);
            int n = 10;
            int total = 0;
            for (int i = 0; i <= n; i++)
                total += integerPower(2, i);
            Console.WriteLine(total);
        }
    }
}
