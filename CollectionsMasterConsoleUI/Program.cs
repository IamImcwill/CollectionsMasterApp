﻿using System;
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
            int[] array = new int[50];
           

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(array);
           

            //TODO: Print the first number of the array
            Console.WriteLine($"First number of the array: {array[0]}");
            //TODO: Print the last number of the array            
            Console.WriteLine($"Last number of the array: {array[array.Length - 1]}");
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(array);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)`0
            */
            ReverseArray(array);
            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(array);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            NumberPrinter(array);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(array);

            

            NumberPrinter(array);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Array.Sort(array);
            Console.WriteLine("Sorted numbers:");
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion


            //List
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> list = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine("Capacity of List: ");
            Console.WriteLine(list.Capacity);


            //TODO: Populate the List with 50 random numbers between 0 and 50
            //you will need a method for this            
            Populater(list);
            NumberPrinter(list);

            //TODO: Print the new capacity
            Console.WriteLine($"List Capacity: {list.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int userNumber)) 
            {
                NumberChecker(list, userNumber);
            }
            else 
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
                NumberPrinter(list);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(list);
            NumberPrinter(list);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            list.Sort(); 
            NumberPrinter(list); 
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] arryFromList = list.ToArray ();

            //TODO: Clear the list
            list.Clear();
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++) 
            {
                
                if (numbers[i] % 3 == 0)
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


        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }
        }

        private static void ReverseArray(int[] array)
        {
            int[] newArray = new int[50];
            int index = 0;
            for  (int i =array.Length-1; i>= 0; i--) 
            {
                newArray[index] = array[i];
                index++;
            }
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
