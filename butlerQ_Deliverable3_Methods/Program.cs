using System;

namespace butlerQ_Deliverable3_Methods
{
    /*
    Author: Quinn Butler
    Date: 2/5/2021
    Comments: C# console application that asks for user input and prints input in a method
    */
    class Program
    {
        static void Main(string[] args)
        {
            /*Watch the 2 videos posted in CANVAS on: Methods
            Review the source code on all of the GitHub link. Then write the following program:
            PROGRAM #2: 
            Create a C# Console application that demonstrates a Method with the following instructions:
            1. As the user to enter their name
            2. Write a method that prints to the Console: "Hello users name!".
            Here's an example of the User Input and Output:
            INPUT: He Zhang
            OUTPUT: Hello He Zhang!
            Once you complete this program, upload it to GitHub.
            Then, past in your GitHub Link to GitHub here.*/
            //Ask for user to input name, as although it's not written in the delierable, we should not have the assumption the user knows what to do with a 
            //given text prompt
            Console.WriteLine("Please input your name:");
            try
            {
                //Create string variable for user input and read input from console
                string NameString = Console.ReadLine();
                //Calls for method to print string
                //Note application will end in method
                PrintString(NameString);
            }
            catch
            {
            Console.WriteLine("Please input a valid input for name.");
            }
        }
        private static void PrintString(string Name)
        {
            //Prints string variable from method call
            Console.WriteLine("Hello " + Name + "!");
            //Ask user to input to end application
            Console.WriteLine("Please press any key to exit console.");
            Console.ReadKey(true);
        }
    }
}
