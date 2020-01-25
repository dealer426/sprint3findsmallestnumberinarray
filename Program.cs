using System;
using System.Linq;

namespace sprint3findsmallestnumberinarray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for 5 integers and save them in an array


            //Instantiate the array to hold the integers
            //We know we want the user to only insert 5 numbers so create and array that holds 5 ints
            int[] myNumbers = new int[5];

            //Continually ask the user for 5 numbers and fill the array: While Loop
            //Stop asking the user once the array is filled
            //How do we know if the array is filled,

            //Create a counter to loop through the index of the list and insert the number at that index
            int counter = 0;

            //Run this loop if the length of the array does not equal 5
            //Remember Arrays start at 0 
            //Track the position of the Arrays Length starting at 0 using a counter
            while (counter != myNumbers.Length)
            {
                Console.WriteLine("Enter 5 Numbers");
                string userInput = Console.ReadLine();

                //Since input is a string I need to convert my input to type int, since the Array is of type int
                int insertNumber = Convert.ToInt32(userInput);


                //counter starts at 0 so the first item will insert into the array position at 0
                myNumbers[counter] = insertNumber;

                //If I run continue to run the loop counter will stay at 0, so I need to increment the counter
                //as I am running the loop, this way it will change to one, two, three as the loop runs
                counter++;

            }

            //Check output, Did I capture 5 numbers
            Console.WriteLine("List as Entered by user input");
            for (int i = 0; i < myNumbers.Length; i++)
            {
                //show the numbers on one line
                Console.Write(myNumbers[i] + " ");
            }

            //Find the smalles number in the array and write it to the screen
            //Sort the Array
            //The sort Array automatically sort the array items ascedning
            Array.Sort(myNumbers);

            //Check output, Did The list sort
            Console.WriteLine("\nList Sorted ");
            for (int i = 0; i < myNumbers.Length; i++)
            {
                //show the numbers on one line
                Console.Write( myNumbers[i] + " ");
            }

            //Show the smallest number to the user 
            //We are going to call the First Method, since the list is sorted ascending
            //Add using System.Linq; to the top of the program
            Console.WriteLine($"\nThe Smallest Number is {myNumbers.First()}");

            Console.ReadKey();
        }
    }
}
