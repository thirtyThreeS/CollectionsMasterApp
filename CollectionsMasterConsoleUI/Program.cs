using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] numbers = new int[50];


            //Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(numbers);

            //Print the first number of the array
            Console.WriteLine(numbers[0]);
            //Print the last number of the array            
            Console.WriteLine(numbers[49]);
            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            
            // 1st Method of Reverse:
            Array.Reverse(numbers);

            Console.WriteLine("All Numbers Reversed:");

            // 1st Method of Reverse:
            Console.WriteLine(String.Join(", ", numbers));

            Console.WriteLine("----------REVERSE CUSTOM----------");

            int[] reverse = Enumerable.Reverse(numbers).ToArray();
            // Using String.Join to make it more readable in CMD -- 15.6" laptop screen afterall
            Console.WriteLine(String.Join(", ", reverse));

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(reverse);
            
            


            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(reverse);
            Console.WriteLine(String.Join(", ", reverse));
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var listNum = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine(listNum.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Random listRand = new Random();
            
            for(int i = 0; i < 50; i++)
            {
                listNum.Add(listRand.Next(50));
            }

            Console.WriteLine(String.Join(", ", listNum));
            //Print the new capacity
            Console.WriteLine(listNum.Capacity);


            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            //int userNum = int.Parse(Console.ReadLine());
            int userNum;

            while (!int.TryParse(Console.ReadLine(), out userNum))
            {
                Console.WriteLine("This is not a number");
                //userNum = int.Parse(Console.ReadLine());
            }
            //if (listNum.Contains(userNumber))
            //{
            //    Console.WriteLine("This number is present in the list!");
            //}
            if (listNum.Contains(userNum))
            {
                Console.WriteLine("This number is present in the list!");
            }
            //else if (listNum.Contains(search))
            //{
            //    Console.WriteLine("This number is present in the list!");
            //}
            else
            {
                Console.WriteLine("This number is NOT present in the list..");
            }
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(listNum);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            foreach (int i in listNum)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(String.Join(", ", i)); //string.join not working? bigsad nned work around :/
                }
            }
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            var sortedList = new Object();
            listNum.Sort();
            foreach (int i in listNum)
            {
                Console.WriteLine(String.Join(", ", i));
            }
            
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            int[] converted = listNum.ToArray();
            Console.WriteLine(String.Join(", ", converted));
            
            //Clear the list
            Array.Clear(converted, 0, converted.Length);
            Console.WriteLine(String.Join(", ", converted));

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
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
                //Check to see if populated randomly .. Console.WriteLine(numbers[i]);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            
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
