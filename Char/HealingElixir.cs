using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    class HealingElixir
    {
        public int CoordinateX;
        public int CoordinateY;

        public HealingElixir(int coordinateX, int coordinateY)
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
        }
        public bool HealElPlace(int coordinateX, int coordinateY)
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

        public int[] HealPosition()
        {
            int[] Pos = new int[2];
            Pos[0] = this.CoordinateX;
            Pos[1] = this.CoordinateY;
            return Pos;
        }

        public void HealDelite()
        {
            CoordinateX = 0;
            CoordinateY = 0;
        }
    }
}
