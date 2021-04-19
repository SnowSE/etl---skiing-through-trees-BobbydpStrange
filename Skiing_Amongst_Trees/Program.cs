using System;

namespace Skiing_Amongst_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Map mountain = new Map();


            Console.WriteLine("What is the left to right?");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string leftRight = Console.ReadLine();


            Console.WriteLine("What is the up and down?");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string upDown = Console.ReadLine();

            if (!string.IsNullOrEmpty(upDown) || !string.IsNullOrEmpty(leftRight))
            {
                System.Console.WriteLine("Not a valid input!");
                Environment.Exit(0);
            }


            Ski skiSlope = new Ski(Convert.ToInt32(leftRight), Convert.ToInt32(upDown));


            while (skiSlope.getPositionY() < 322)
            {

                /*                System.Console.WriteLine(skiSlope.getPositionX() +"space" + skiSlope.getPositionY());
                                */

                skiSlope.movePosition();
                mountain.isTree(skiSlope.getPositionX(), skiSlope.getPositionY());

                /*System.Console.WriteLine(mountain.getCount());*/
            }

            /*mountain.print();*/
            System.Console.WriteLine("THe number of times you hit a tree is: " + mountain.getCount());
        }
    }
}