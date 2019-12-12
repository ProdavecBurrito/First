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
                Charactor Hodr = new Charactor("Hodr", 9, X, Y);
                Let FirstLet = new Let(3-1, 6-1);
                Let SecondLet = new Let(8-1, 9-1);
                HealingElixir FirstHealEl = new HealingElixir(4 - 1, 3 - 1);
                HealingElixir SecondHealEl = new HealingElixir(10 - 1, 7 - 1);

                while (Hodr.CharLive())
                {
                    Console.WriteLine("Для перемещения нажмите WASD. Для удара персонажа нажмите Enter, для исцеления нажмите Backspace");

                    Console.WriteLine();
                    int[,] Field = new int[10, 10];
                    CharOnLet(ref SaveCoordX, ref SaveCoordY, Hodr, FirstLet, SecondLet);
                    GrabHealingEl(Hodr, FirstHealEl);
                    GrabHealingEl(Hodr, SecondHealEl);
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Field[i, j] = 0;

                            // тут пора бы уже свич делать, завтра попробую
                            if (FirstLet.LetPlace(i, j))
                            {
                                Field[i, j] = 7;
                            }
                            if (SecondLet.LetPlace(i, j))
                            {
                                Field[i, j] = 7;
                            }
                            if (FirstHealEl.HealElPlace(i, j))
                            {
                                if (FirstHealEl.HealElOn())
                                {
                                    Field[i, j] = 3;
                                }
                                else
                                {
                                    Field[i, j] = 0;
                                }
                            }
                            if (SecondHealEl.HealElPlace(i, j))
                            {
                                if (SecondHealEl.HealElOn())
                                {
                                    Field[i, j] = 3;
                                }
                                else
                                {
                                    Field[i, j] = 0;
                                }
                            }
                            if (Hodr.Place(i, j))
                            {
                                Field[i, j] = 1;
                            }
                            Console.Write(Field[i, j]);
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

        private static void GrabHealingEl(Charactor pers, HealingElixir healEl)
        {
            if (healEl.HealPosition()[0] == pers.CharPosition()[0] && healEl.HealPosition()[1] == pers.CharPosition()[1])
            {
                if (pers.Health != 10)
                {
                    if (healEl.HealElOn())
                    {
                        pers.Heal();
                        healEl.HealActiv = 1;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Персонаж полностью здоров");
                    Console.WriteLine("Нажмите любую клавишу, что бы продолжить");
                    Console.ReadKey();
                }
            }
        }

        private static void Action(Charactor pers)
        {
            ConsoleKey Act = Console.ReadKey().Key;
            if (Act == ConsoleKey.W || Act == ConsoleKey.A || Act == ConsoleKey.S || Act == ConsoleKey.D)
            {
                pers.Move(Act);
            }
            else if (Act == ConsoleKey.Enter)
            {
                pers.Dmg();
            }
            else if (Act == ConsoleKey.Backspace)
            {
                pers.Heal();
            }
        }

        private static void CharOnLet(ref int SaveCoordX, ref int SaveCoordY, Charactor Hodr, Let FirstLet, Let SecondLet)
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
