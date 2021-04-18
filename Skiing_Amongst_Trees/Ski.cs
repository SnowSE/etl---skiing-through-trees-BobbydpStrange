﻿using System;
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
           if (positionY != 322)
            {
                positionX += slopeX;
                positionY += slopeY;
            }
            if (positionX >= 31)
            {
                positionX = positionX % slopeX;
            }
            else
            {

            }
        }


    }
}