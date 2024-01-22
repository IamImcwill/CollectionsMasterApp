using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var numbersArray = new int[50]; 

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbersArray);

            //TODO: Print the first number of the array
            Console.WriteLine($"First number pf the array: {numbersArray[0]}");
            //TODO: Print the last number of the array            
            Console.WriteLine($"Last number of the array: {numbersArray[numbersArray.Length - 1]}");
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbersArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)`0
            */
            ReverseArray(numbersArray);
            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(numbersArray);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            NumberPrinter(numbersArray);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            ThreeKiller(numbersArray);

            Console.WriteLine("Multiple of three = 0: ");
   
            NumberPrinter(numbersArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Array.Sort(numbersArray);
            Console.WriteLine("Sorted numbers:");
            NumberPrinter(numbersArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

           
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++);
            {
                int i = 0;
                if (numbers[i] % 3 == 0) ;
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(number => number % 2 != 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is present in the list.");
            }
            else
            { 
                Console.WriteLine($"{searchNumber} is not present in the list.");
            }

        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                int randomNumber = rng.Next(0, 50);
                numberList.Add(randomNumber);
                
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
           for (int i = 0; i < numbers.Length; i++) 
                {
                    numbers[i] = rng.Next(0, 50);
                }
        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
                foreach (var number in collection) 
                {
                    Console.WriteLine($"{number}");
                }
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
