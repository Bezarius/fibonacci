using System;
using System.Collections.Generic;

namespace Fib
{
    internal sealed class Program
    {

        private static int Fib(int num, ref int[] arr)
        {
            if (num <= 1)
            {
                arr[num] = num;
                return 1;
            }

            var res = Fib(num - 1, ref arr) + Fib(num - 2, ref arr);

            arr[num] = res;

            return res;
        }

        private static IEnumerable<int> Fib(int num)
        {
            var arr = new int[num + 1];
            Fib(num, ref arr);
            return arr;
        }

        static void Main(string[] args)
        {
            foreach (var fibVal in Fib(10))
            {
                Console.WriteLine(fibVal);
            }
            Console.ReadKey();
        }
    }
}
