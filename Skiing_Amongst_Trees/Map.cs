using System;
using System.Collections.Generic;
using System.Text;

namespace Skiing_Amongst_Trees
{
    class Map
    {
        private int count = 0;
        private char[,] hill  = new char[322,31];
        private int x = 0;
        private int y = 0;
        
        public Map()
        {
            hill = extract(hill);
        }
        private char[,] extract( char[,] hill)
        {
            string line;


            
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Aubrey Oblad\Source\Repos\etl---skiing-through-trees-BobbydpStrange\Skiing_Amongst_Trees\TreeMap.txt");
            while((line = file.ReadLine()) != null)
            {
                foreach(char item in line)
                {
                    checkCords();
                    hill[y,x]= item;
                    System.Console.WriteLine(item);
                    
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
            for(int i = 0; i == 322; i++)
            {
                for (int j=0; j == 31; j++)
                {
                    System.Console.WriteLine(hill[j, i]);
                    
                }
            }
        }

        public void isTree (int x, int y)
        {
            
            if (hill[y, x] == '#')
            {
                count++;
            }
        }
        public int getCount()
        {
            return count;
        }
    }
}
