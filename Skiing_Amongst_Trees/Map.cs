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
                    //System.Console.WriteLine(hill[y, x]);
                    x++;


                    if (x == 31)
                    {
                        y++;
                        //System.Console.WriteLine(y);
                    }
                }
            }
            file.Close();
            return hill;
        }


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

        public int isTree(int x, int y)
        {
            if (hill[y, x] == '.')
            {
                hill[y, x] = 'O';
            }

            if (hill[y, x] == '#')
            {
                hill[y, x] = 'X';
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