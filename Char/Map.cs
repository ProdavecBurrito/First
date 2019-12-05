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
        public string[] line;

        public string[] MapReader()
        {
            using (var mapRead = new StreamReader(@"C:\Users\shipo\source\repos\First\Map.txt"))
            {
                int count = 0;
                this.line = new string[MaxHight];
                while (!mapRead.EndOfStream)
                {
                    line[count] = mapRead.ReadLine();
                    count++;
                }
                return line;
            }
        }
        public void MapWriter(string[] map)
        {
            for (int i = 0; i < map.Length; i++)
            {
                if (i == Y)
                {
                    map[i].ToCharArray();
                    for (int j = 0; j < MaxHight; i++)
                    {
                        if (j == X)
                        {
                            map[j] = "X";
                            Console.WriteLine(map[j]);
                        }
                    }
                }
                Console.WriteLine(map[i]);
            }
        }
    }
}
