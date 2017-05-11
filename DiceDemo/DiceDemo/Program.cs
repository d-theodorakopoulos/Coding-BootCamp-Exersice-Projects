using System;
using System.Collections.Generic;

namespace DiceDemo
{
    class Program
    {
        static void Main (string[] args)
        {
            List<Dice> myDices = new List<Dice>() { new Dice() };
            String input = "";
            int number;
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

            do
            {
                Console.WriteLine("--- Main Menu ----\n"+
                                  "Press 1 to START roll dice\n" +
                                  "Press 2 to CHANGE dice's Max Value(default is 6)\n" +
                                  "Press 3 to ADD a dice\n" +
                                  "Press 4 to SHOW dice statistics\n"+
                                  "Press 0 to QUIT application");

                input = Console.ReadLine();
                switch (input)
                {
                    case "1": // Start roll dice
                        while (true)
                        {
                            Console.WriteLine("Press a key to roll the dices...\nPress 'q' to go back to menu!");
                            keyInfo = Console.ReadKey();
                            ClearConsoleLine();

                            if (keyInfo.Key == ConsoleKey.Q)
                                break;
                            else if (keyInfo.Modifiers == ConsoleModifiers.Control && keyInfo.Key == ConsoleKey.O)
                            {
                                foreach (Dice dice in myDices)
                                {
                                    number = dice.RollHigh();
                                    Dice.diceStatistics.IncrenentTimesOfDrop(number);
                                    Console.Write(number + " ");
                                }
                            }
                            else
                            {
                                foreach (Dice dice in myDices)
                                {
                                    number = dice.NextRoll;
                                    Dice.diceStatistics.IncrenentTimesOfDrop(number);
                                    Console.Write(number + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "2": // Change dice's Max Value
                        for (int i = 0; i < 3; i++)
                        {
                            number = ReadFromConsole("Give a number greater or equal than 4");
                            if (number >= 4)
                            {
                                myDices[myDices.Count - 1].MaxValue = number;
                                Console.WriteLine("Dice max Value changed!");
                                break;
                            }
                            else
                                Console.WriteLine("wrong value, try again..");

                            if (i == 2)
                                Console.WriteLine("End of tries...");
                        }
                        break;
                    case "3": // Add new dice
                        myDices.Add(new Dice(ReadFromConsole("Give Max value for the new dice : ")));
                        break;
                    case "4":
                        Console.WriteLine(Dice.diceStatistics.ShowDiceStatistics());
                        break;
                    case "0": // Quits
                        return;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            } while (true) ;
        }

        private static int ReadFromConsole(string message)
        {
            Console.WriteLine(message);
            return Int32.Parse(Console.ReadLine());
        }

        private static void ClearConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
