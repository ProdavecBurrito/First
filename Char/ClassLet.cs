using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    class ClassLet
    {
        public int LetCoordX;
        public int LetCoordY;

        public ClassLet(int letCoordX, int letCoordY)
        {
            this.LetCoordX = letCoordX;
            this.LetCoordY = letCoordY;
        }

        //public int LetDmg()
        //{
        //    if (LetCoordX == this.X)
        //}
        public bool LetPlace(int x, int y)
        {
            if (x == this.LetCoordX && y == this.LetCoordY)
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
            int[] Pos = new int[2];
            Pos[0] = this.LetCoordX;
            Pos[1] = this.LetCoordY;
            return Pos;
        }
    }
}
