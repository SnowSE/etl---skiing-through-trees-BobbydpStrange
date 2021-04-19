using System;
using System.Collections.Generic;
using System.Text;

namespace Skiing_Amongst_Trees
{
    class Ski
    {

        private int slopeX;
        private int slopeY;
        private int positionX = 0;
        private int positionY = 0;


        //This will get the slopes from the main program and check to make sure if they are negative values.
        public Ski(int slopex, int slopey)
        {
            slopeX = slopex;
            slopeY = slopey;

            if (slopeX <= 0 || slopeY <= 0)
            {
                System.Console.WriteLine("Invalid, negitive slope! Cant go up!");
                Environment.Exit(0);
            }


        }

        public int getPositionX()
        {
            return positionX;
        }
        public int getPositionY()
        {
            return positionY;
        }

        //This calculates the position of the skier based on the slope and makes sure the skier goes to the correct spot on each line of the hill array and that they get to the bottom of the hill.
        public void movePosition()
        {

            if (positionY + slopeY <= 322)//makes sure to keep moving the user if they don't reach the bottom of the hill.
            {
                positionX += slopeX;
                positionY += slopeY;
            }


            if (positionX >= 31) // makes sure that if the skier reaches the end of arrays row it continues to the correct spot on the next row.
            {
                positionX = (positionX - 31);

            }
            else if (positionY + slopeY >= 322)// If the skie y input is not a multiple of the height of the hill then it sets it to the bottom of the hill if they try to go past.
            {
                positionY = 322;
            }
        }


    }
}