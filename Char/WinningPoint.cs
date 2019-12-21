using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    class WinningPoint
    {
        int CoordinateX;
        int CoordinateY;

        public WinningPoint(int x, int y)
        {
            this.CoordinateX = x;
            this.CoordinateY = y;
        }

        public bool WinningCoordinates(int coordinateX, int coordinateY)
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

        public int[] WinningPosition()
        {
            int[] pos = new int[2];
            pos[0] = this.CoordinateX;
            pos[1] = this.CoordinateY;
            return pos;
        }
    }
}
