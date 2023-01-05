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

            var randNums = new int[50];
            

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(randNums);

            //TODO: Print the first number of the array
            Console.WriteLine(randNums[0]);

            //TODO: Print the last number of the array
            Console.WriteLine(randNums[randNums.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(randNums);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(randNums);
            Array.ForEach(randNums, Console.WriteLine);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(randNums);
            Array.ForEach(randNums, Console.WriteLine);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(randNums);
            

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(randNums);

            foreach(int num in randNums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var randList = new List<int>();
            

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(randList.Capacity);
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(randList);

            //TODO: Print the new capacity
            Console.WriteLine(randList.Capacity);


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int number;
            var userInput = Console.ReadLine();
            bool tryParse = int.TryParse(userInput, out number);
            while(!tryParse)
            {
                Console.WriteLine("Please enter a valid integer: ");
                userInput = Console.ReadLine();
                tryParse = int.TryParse(userInput, out number);

            }

            NumberChecker(randList, number);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(randList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(randList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            randList.Sort();

            foreach (int num in randList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var arr = randList.ToArray();

            //TODO: Clear the list
            randList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
           for(int i = 0; i < numbers.Length; i++)
            {
                if(i % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }

           foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.RemoveAt(i--);
                }
            }

            foreach (int num in numberList)
            {
                Console.WriteLine(num);
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if(numberList.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is in the list!");
            } 
            else
            {
                Console.WriteLine($"{searchNumber} is not in the list");
            } 
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();


            for (int i = 0; i < 50; i++)
            {

                numberList.Add( rng.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                
                numbers[i] = random.Next(0, 50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            for(int i = 0; i < array.Length /2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            
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
