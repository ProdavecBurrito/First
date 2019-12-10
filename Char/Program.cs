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
            int SaveCoordX = 0;
            int SaveCoordY = 0;
            Console.WriteLine("Введите нахождение персонажа по координате Х");
            int X = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine("Введите нахождение персонажа по координате Y");
            int Y = Convert.ToInt32(Console.ReadLine())-1;
            if (X >= 10 || X+1 <= 0 || Y >= 10 || Y+1 <= 0)
            {
                Console.WriteLine("Нельзя разместить персонажа за пределами карты");
                Console.ReadKey();
            }
            else
            {
                ClassCharactor Hodr = new ClassCharactor("Hodr", 9, X, Y);
                ClassLet FirstLet = new ClassLet(3-1, 6-1);
                ClassLet SecondLet = new ClassLet(8-1, 9-1);
                while (Hodr.CharLive())
                {
                    Console.WriteLine("Для перемещения нажмите WASD. Для удара персонажа нажмите Enter, для исцеления нажмите Backspace");

                    Console.WriteLine();
                    int[,] Arr = new int[10, 10];
                    CharOnLet(ref SaveCoordX, ref SaveCoordY, Hodr, FirstLet, SecondLet);

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Arr[i, j] = 0;
                            if (FirstLet.LetPlace(i, j))
                            {
                                Arr[i, j] = 7;
                            }
                            if (SecondLet.LetPlace(i, j))
                            {
                                Arr[i, j] = 7;
                            }
                            if (Hodr.Place(i, j))
                            {
                                Arr[i, j] = 5;
                            }
                            Console.Write(Arr[i, j]);
                        }

                        Console.WriteLine();
                    }
                    Console.WriteLine();


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

        private static void Action(ClassCharactor Hodr)
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

        private static void CharOnLet(ref int SaveCoordX, ref int SaveCoordY, ClassCharactor Hodr, ClassLet FirstLet, ClassLet SecondLet)
        {
            if (FirstLet.LetPosition()[0] == Hodr.CharPosition()[0] && FirstLet.LetPosition()[1] == Hodr.CharPosition()[1] || SecondLet.LetPosition()[0] == Hodr.CharPosition()[0] && SecondLet.LetPosition()[1] == Hodr.CharPosition()[1])
            {
                Hodr.Dmg();
                Hodr.CharReposition(SaveCoordX, SaveCoordY);
            }
            else
            {
                SaveCoordX = Hodr.CharSaveLastPosition()[0];
                SaveCoordY = Hodr.CharSaveLastPosition()[1];
            }
        }
    }
}
