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

        public void movePosition()
        {

            if (positionY + slopeY <= 322)
            {
                positionX += slopeX;
                positionY += slopeY;
            }


            if (positionX >= 31)
            {
                positionX = (positionX - 31);

            }
            else if (positionY + slopeY >= 322)
            {
                positionY = 322;
            }
        }


    }
}