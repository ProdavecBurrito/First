using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Char
{
    class Map
    {
        public int MaxWidth = 50;
        public int MaxHight = 20;
        public int X = 5;
        public int Y = 10;
        public char[,] line;

        public char[,] MapReader()
        {
            using (var mapRead = new StreamReader(@"../../../Map.txt"))
            {

                int i = 0;
                this.line = new char[MaxHight, MaxWidth];
                char Kek;
                while (!mapRead.EndOfStream)
                {
                    string mapRow = mapRead.ReadLine();
                    for(int j=0; j <mapRow.Length; ++j)
                    {
                        this.line[i,j] = mapRow[j];
                    }
                    i++;
                }
            }
            return this.line;
        }
        public void MapWriter(char[,] map)
        {
            for (int i = 0; i < MaxHight; i++)
            {
                for (int j = 0; j < MaxHight; j++)
                {
                    if (j == X && i == Y)
                    {
                        map[i, j] = 'X';
                        //Console.WriteLine([j]);
                    }
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
