using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    class Mines
    {
        int CoordinateX;
        int CoordinateY;
        public int MineActiv = 0;

        public Mines(int x, int y)
        {
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

        public bool MineOn()
        {
            if (MineActiv == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
