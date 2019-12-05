using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    public class Charactor
    {
        string Name;
        int Health;
        int CoordinateX;
        int CoordinateY;
        int MinX = 0;
        int MinY = 0;
        int MaxX = 50;
        int MaxY = 20;

        public Charactor(string name, int health, int x, int y)
        {
            this.Name = name;
            this.Health = health;
            if (x > MaxX || x < MinX || y > MaxX || y < MinX)
            {
                Console.WriteLine("Нельзя поставить персонажа за приделами поля");
            }
            else
            {
                this.CoordinateX = x;
                this.CoordinateY = y;
            }
        }

        public void Move(ConsoleKey a)
        {
            if (a == ConsoleKey.W)
            {
                if (this.CoordinateX != this.MinX)
                {
                    this.CoordinateX -= 1;
                }
            }
            else if (a == ConsoleKey.D)
            {
                if (this.CoordinateY != this.MaxX)
                {
                    this.CoordinateY += 1;
                }
            }
            else if (a == ConsoleKey.S)
            {
                if (this.CoordinateX != this.MaxX)
                {
                    this.CoordinateX += 1;
                }
            }
            else if (a == ConsoleKey.A)
            {
                if (this.CoordinateY != this.MinX)
                {
                    this.CoordinateY -= 1;
                }
            }
        }

        public int Dmg()
        {
            return this.Health -= 1;
        }

        public int Heal()
        {
            if (this.Health == 10)
            {
                Console.WriteLine();
                Console.WriteLine("Персонаж полностью здоров");
                Console.WriteLine("Нажмите любую клавишу, что бы продолжить");
                Console.ReadKey();
                return Health;
            }
            else
            {
                return Health += 1;
            }
        }

        public bool CharLive()
        {
            if (this.Health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Place (int x, int y)
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

        public void CharCheck()
        {
            Console.WriteLine($"Персонаж - {this.Name}");
            Console.WriteLine($"Кол-во жизней - {this.Health}");
            Console.WriteLine($"Координаты - {this.CoordinateX+1}x{this.CoordinateY+1}");
        }
    }
}
