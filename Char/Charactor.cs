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
        public int Health;
        int CoordinateX;
        int CoordinateY;
        int Min = 0;
        int Max = 9;
        public int HealingPotions = 0;


        public Charactor(string name, int health, int x, int y)
        {
            this.Name = name;
            this.Health = health;
            this.CoordinateX = x;
            this.CoordinateY = y;
        }

        public void Move(ConsoleKey a)
        {
            if (a == ConsoleKey.W)
            {
                if (this.CoordinateX != this.Min)
                {
                    this.CoordinateX -= 1;
                }
            }
            else if (a == ConsoleKey.D)
            {
                if (this.CoordinateY != this.Max)
                {
                    this.CoordinateY += 1;
                }
            }
            else if (a == ConsoleKey.S)
            {
                if (this.CoordinateX != this.Max)
                {
                    this.CoordinateX += 1;
                }
            }
            else if (a == ConsoleKey.A)
            {
                if (this.CoordinateY != this.Min)
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
        public bool Place(int x, int y)
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
            Console.WriteLine($"Координаты - {this.CoordinateX + 1}x{this.CoordinateY + 1}");
            Console.WriteLine($"Колл. хилок - {HealingPotions}");
        }

        public int[] CharSaveLastPosition()
        {
            int[] pos = new int[2];
            pos[0] = this.CoordinateX;
            pos[1] = this.CoordinateY;
            return pos;
        }
        public int[] CharPosition() // Поидее, это перегрузка CharSaveLastPosition. Должна быть. Но ведь они о разном совершенно
        {
            int[] pos = new int[2];
            pos[0] = this.CoordinateX;
            pos[1] = this.CoordinateY;
            return pos;
        }

        public void CharReposition(int x, int y)
        {
            this.CoordinateX = x;
            this.CoordinateY = y;
        }
    }
}
