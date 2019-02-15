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
            Console.WriteLine(UsingRecursion.calculateRecursively(1, 3));       // Static Method. That's why called diffently
        }
    }

    class UsingRecursion
    {
        // A method that calculates sum of all numbers

        public static int calculateRecursively(int n, int m)                    // Each Stack has it's own heap frame
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

    class Village                                                                 // Abstract Data Types Class
    {
        public Village west;
        public Village east;
        public string villageName;
        public int distanceToNextVillage;
        public int distanceToPreviousVillage;
        public bool isAstrildgeHere;



        public Village(string _villageName, bool _isAHere)
        {
            _isAHere = isAstrildgeHere;
            _villageName = villageName;
        }
    }

    class CountrySide                                                       
    {
                                                                        // Linked List Class
        Vi
    }

 



}
