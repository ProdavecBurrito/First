using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    public class ClassCharactor
    {
        string Name;
        int Health;
        int X;
        int Y;
        int Min = 0;
        int Max = 9;

        public ClassCharactor(string name, int health, int x, int y)
        {
            this.Name = name;
            this.Health = health;
            //if (x > Max || x < Min || y > Max || x < Min)
            //{
            //    Console.WriteLine("Нельзя поставить персонажа за приделами поля");

            //}
            //else
            {
                this.X = x;
                this.Y = y;
            }
        }

        public void Move(ConsoleKey a)
        {
            if (a == ConsoleKey.W)
            {
                if (this.X != this.Min)
                {
                    this.X -= 1;
                }
            }
            else if (a == ConsoleKey.D)
            {
                if (this.Y != this.Max)
                {
                    this.Y += 1;
                }
            }
            else if (a == ConsoleKey.S)
            {
                if (this.X != this.Max)
                {
                    this.X += 1;
                }
            }
            else if (a == ConsoleKey.A)
            {
                if (this.Y != this.Min)
                {
                    this.Y -= 1;
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
            if (x == this.X && y == this.Y)
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
            Console.WriteLine($"Координаты - {this.X + 1}x{this.Y + 1}");
        }

        public int[] CharSaveLastPosition()
        {
            int[] pos = new int[2];
            pos[0] = this.X;
            pos[1] = this.Y;
            return pos;
        }
        public int[] CharPosition() // Поидее, это перегрузка CharSaveLastPosition. Должна быть. Но ведь они о разном совершенно
        {
            int[] pos = new int[2];
            pos[0] = this.X;
            pos[1] = this.Y;
            return pos;
        }

        public void CharReposition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
