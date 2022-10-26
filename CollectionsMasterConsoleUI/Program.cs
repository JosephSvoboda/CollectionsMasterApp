using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

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
            //TODO: Create an integer Array of size 50 - DONE!
            var fifty = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50 - DONE!
            Populater(fifty);

            //TODO: Print the first number of the array - DONE!
            Console.WriteLine($"{fifty[0]}");

            //TODO: Print the last number of the array - DONE!
            Console.WriteLine($"{fifty[fifty.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists - DONE!
            NumberPrinter(fifty);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console. - DONE!
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            
            Console.WriteLine("All Numbers Reversed:");
            
            Array.Reverse(fifty);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers - DONE!
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(fifty);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now - DONE!
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(fifty);
            NumberPrinter(fifty);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List - DONE!
            var intList = new List<int>();

            //TODO: Print the capacity of the list to the console - DONE!
            Console.WriteLine($"{intList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this - DONE!       
            Populater(intList);

            //TODO: Print the new capacity - DONE!
            Console.WriteLine($"{intList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list - DONE!
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            int userInput;
            bool number;

            do
            {
                Console.WriteLine("Type in a number from the list.");
                number = int.TryParse(Console.ReadLine(), out userInput);
            } while (number == false);

            NumberChecker(intList, userInput);

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results - DONE!
            Console.WriteLine("Evens Only!!");
            
            OddKiller(intList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results - DONE!
            Console.WriteLine("Sorted Evens!!");

            intList.Sort();
            NumberPrinter(intList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable - DONE!

            var anArray = intList.ToArray();

            //TODO: Clear the list - DONE!

            intList.Clear();

            #endregion
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
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"That number is in the list.");
            }
            else
            {
                Console.WriteLine($"that number is not in the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            while (numberList.Count < 50)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);

                numberList.Add(number);
            }

            NumberPrinter(numberList);
        }

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);

            }

        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);

            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
