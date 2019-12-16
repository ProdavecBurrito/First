using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    class Mines
    {
        public string MineName;
        int CoordinateX;
        int CoordinateY;
        Random RanMine1 = new Random();
        //Random RanMine2 = new Random();// не додумался до способа присвоить каждой мине отличные координаты от другой

        public Mines(int mineNumber, int x, int y)
        {
            this.MineName = "Mine" + mineNumber;
            this.CoordinateX = x;
            this.CoordinateY = y;
        }

        public bool MineCoordinates(int coordinateX, int coordinateY)
        {
            if (coordinateX == this.CoordinateX && coordinateY == this.CoordinateY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int[] MinePosition()
        {
            int[] pos = new int[2];
            pos[0] = this.CoordinateX;
            pos[1] = this.CoordinateY;
            return pos;
        }
    }
}
