using System;
using System.Collections.Generic;
using System.Text;

namespace Skiing_Amongst_Trees
{
    class Map
    {
        private int count = 0;
        private char[,] hill = new char[323, 31];
        private int x = 0;
        private int y = 0;

        public Map()
        {
            hill = extract(hill);
        }

        //Gets the layout of the trees from the text file and put it into a multidementional array.
        private char[,] extract(char[,] hill)
        {
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\aubrey.oblad\Source\Repos\etl---skiing-through-trees-BobbydpStrange\Skiing_Amongst_Trees\TreeMap.txt");
            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                foreach (char item in line)
                {
                    checkCords();
                    hill[y, x] = item;     
                    x++;

                    if (x == 31)
                    {
                        y++;                        
                    }
                }
            }
            file.Close();
            return hill;
        }

        //Makes sure that if when transfering the information from the text file that if it reaches the end of the line of the array it goes to the next one. 
        private void checkCords()
        {
            if (x == 31)
            {
                x = 0;
            }
            if (y == 322)
            {
                y = 0;
            }
        }

        //This is a way to print what is in the array.
        public void print()
        {
            for (int i = 0; i < 323; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    System.Console.Write(hill[i, j]);

                }
                System.Console.WriteLine();
            }
        }

        //This checks to make sure if the skier hit a tree and if they did the count for trees hit will increment.
        public int isTree(int x, int y)
        {
            if (hill[y, x] == '.')
            {
                hill[y, x] = 'O'; //this is if you print the map it will show O for where the skier was but if there wasn't a tree.
            }

            if (hill[y, x] == '#')
            {
                hill[y, x] = 'X';//this is if you print the map it will show X for where the skier was and hit a tree.
                count++;
                if (y == 322)
                {

                }
            }
            return count;
        }
        public char[,] getHill()
        {
            return hill;
        }
        public int getCount()
        {
            return count;
        }
    }
}