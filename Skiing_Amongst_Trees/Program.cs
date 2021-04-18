using System;

namespace Skiing_Amongst_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Map mountain = new Map();
            Ski skiSlope = new Ski(4, 1);

            while (skiSlope.getPositionY() <= 322)
            {
                skiSlope.movePosition();
                mountain.isTree(skiSlope.getPositionX(), skiSlope.getPositionY());

                /*System.Console.WriteLine(mountain.getCount());*/
            }
            System.Console.WriteLine("THe number of times you hit a tree is: " + mountain.getCount());
        }
    }
}
