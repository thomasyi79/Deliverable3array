/*
    Author: Thomas Yi
    Date: 2/4/2020
    Comments: This C# Console application code s Deliverable 3: Arrays for ISM 4041 
*/

using System;

namespace Arrays_Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // call local variable for the total amount of numbers in an array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            foreach ( int i in numbers)
            {
                Console.WriteLine("Element Value" + "=" + i + " ");
            }
        }
    }
}