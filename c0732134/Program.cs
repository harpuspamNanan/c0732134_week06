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
        Village Maeland;
        Village Helmholtz;
        Village Alst;
        Village Wessig;
        Village Badden;
        Village Uster;
        Village Schvenig;

        public void toRunThisClass()                                                // A method just to call other functions of this class in main 
        {
            this.createMap();
        }

        public void createMap()
        {
            Alst = new Village("Alst", false);                                     // Can make a list to see how much distance Hudi travelled
            Schvenig = new Village("Schvenig", false);
            Wessig = new Village("Wessig", true);

            Alst.east = Schvenig;
            Alst.distanceToNextVillage = 14;

            Alst.west = Wessig;
            Alst.distanceToNextVillage = 19;
        }

        public Village traverse(Village currentPoint)                                                 // A function named Traverse of datatype Village
        {
            try
            {
                if (currentPoint.isAstrildgeHere)
                {
                    Console.WriteLine("Hey, Hugi found Astrilde in Village: " + currentPoint.villageName);
                }
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
            }

            if(currentPoint == null)
            {
                return;
            }

            traverse(currentPoint.east);
            traverse(currentPoint.west);

            
        }
    }

 



}
