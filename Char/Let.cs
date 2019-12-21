using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    class Let
    {
        public int CoordinateX;
        public int CoordinateY;

        public Let(int letCoordX, int letCoordY)
        {
            this.CoordinateX = letCoordX;
            this.CoordinateY = letCoordY;
        }

        public bool LetPlace(int x, int y)
        {
            if (x == this.CoordinateX && y == this.CoordinateY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int[] LetPosition()
        {
            int[] pos = new int[2];
            pos[0] = this.CoordinateX;
            pos[1] = this.CoordinateY;
            return pos;
        }
    }
}
