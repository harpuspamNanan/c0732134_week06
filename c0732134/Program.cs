using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0732134
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

    class UsingRecursion
    {
        // A method that calculates sum of all numbers

        public static int calculateRecursively(int n, int m)
        {
            int sum = n;
            if ( n < m )
            {
                n++;
                return (sum += calculateRecursively(n, m));
            }
            return sum;
        }
    }

 



}
