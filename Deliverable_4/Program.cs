/* Author: Khushbu Patel
 * Date: 2/5/2023
 * Description: A C# console app that computes the first 25 numbers in a fibonacci sequence
 */

using System;
namespace Deliverable_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];

            // Initialize fibonacci series
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 0; i < 25; i++)
            {
                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
                Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
            }
        }
    }
}