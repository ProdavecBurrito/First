using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            CharPlaсe(out X, out Y);
            if (X >= 50 || X <= 0 || Y >= 20 || Y <= 0)
            {
                Console.WriteLine("Нельзя разместить персонажа за пределами карты");
                Console.ReadKey();
            }
            else
            {
                Charactor Hodr = new Charactor("Hodr", 9, X, Y);

                while (Hodr.CharLive())
                {
                    Console.WriteLine("Для перемещения нажмите WASD. Для удара персонажа нажмите Enter, для исцеления нажмите Backspace");

                    Console.WriteLine();
                    MapCharView(Hodr);

                    Hodr.CharCheck();
                    Action(Hodr);

                    Console.Clear();
                    if (Hodr.CharLive() == false)
                    {
                        Hodr.CharCheck();
                        Console.WriteLine();
                        Console.WriteLine("Вы проиграли");
                        Console.WriteLine();
                        Console.WriteLine("Нажмите любую клавишу, что бы выйти");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }

        private static void CharPlaсe(out int x, out int y)
        {
            Console.WriteLine("Введите нахождение персонажа по координате Х");
            x = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Введите нахождение персонажа по координате Y");
            y = Convert.ToInt32(Console.ReadLine()) - 1;
        }

        private static void MapCharView(Charactor hodr)
        {
            int[,] map = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    map[i, j] = 0;
                    if (hodr.Place(i, j))
                    {
                        map[i, j] = 5;
                    }
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void Action(Charactor Hodr)
        {
            ConsoleKey Act = Console.ReadKey().Key;
            if (Act == ConsoleKey.W || Act == ConsoleKey.A || Act == ConsoleKey.S || Act == ConsoleKey.D)
            {
                Hodr.Move(Act);
            }
            else if (Act == ConsoleKey.Enter)
            {
                Hodr.Dmg();
            }
            else if (Act == ConsoleKey.Backspace)
            {
                Hodr.Heal();
            }
        }
    }
}
