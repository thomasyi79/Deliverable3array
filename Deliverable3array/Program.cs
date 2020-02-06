/*
    Author: Thomas Yi
    Date: 2/4/2020
    Comments: This C# Console application code s Deliverable 3: Arrays for ISM 4041 
*/

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer between 1 and 25: ");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                // If the value of user input is between 1 and 25, automatically populate an array and iterate throught its values
                if ((value_of_input >= 1) && (value_of_input <= 25))
                {
                    // Automatically populate an array with a number of elements input by the user
                    int[] countdown = new int[value_of_input];
                    Console.WriteLine("__________________________________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("You have entered the number: " + value_of_input);
                    Console.WriteLine("Therefore, " + value_of_input + " elements should be populated in the array.");
                    Console.WriteLine("__________________________________________________________________________");
                    Console.WriteLine("");
                    int pop_array = 0;
                    // Iterate through the array using a For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        countdown[i] = pop_array;
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("__________________________________________________________________________");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                } // End of else if
                // If the user selects a number that is not between 1 and 25 , display a message
                else
                {
                    Console.WriteLine("Please enter an integer value between 1 and 25 next time ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                } // End of else
            } // End of try
            // If a user does not enter an integer, display a message
            catch
            {
                Console.WriteLine("Please input integer values only next time...");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            } // End of catch
        }
    }
}