using System;
using System.IO;

namespace Char
{
    class Map
    {
        public int MaxWidth = 50;
        public int MaxHight = 20;
        public int X = 5;
        public int Y = 10;
        char[,] MapAsArray;

        public void MapReader()
        {
            using (var mapRead = new StreamReader(@"../../../Map.txt"))
            {
                int i = 0;
                this.MapAsArray = new char[MaxHight, MaxWidth];
                while (!mapRead.EndOfStream)
                {
                    string mapRow = mapRead.ReadLine();
                    for (int j = 0; j < mapRow.Length; ++j)
                    {
                        this.MapAsArray[i, j] = mapRow[j];
                    }
                    i++;
                }
            }
        }

        public void MapWriter()
        {
            for (int i = 0; i < MaxHight; i++)
            {
                for (int j = 0; j < MaxHight; j++)
                {
                    if (j == X && i == Y)
                    {
                        this.MapAsArray[i, j] = 'X';
                    }
                    Console.Write(this.MapAsArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
