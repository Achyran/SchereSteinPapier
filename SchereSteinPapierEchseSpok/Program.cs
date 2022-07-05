using System;
using System.Collections.Generic;

namespace SchereSteinPapierEchseSpok
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            bool isRunning = true;
            Console.WriteLine("Comands:\n" +
                              "Set [name]       Sets the Name of the player\n" +
                              "Play [Creature]  Plays the Creature\n" +
                              "ECS              Closes The Game\n\n");
            Console.WriteLine("Playable Creatures:");
            foreach (KeyValuePair<string,Creature> c in game.creatures)
            {
                Console.WriteLine(c.Key);
            }
            while(isRunning)
            {
                string inputString = Console.ReadLine();

                string[] stringSplit = inputString.Split(" ");

                if(stringSplit.Length > 1)
                {
                    switch (stringSplit[0])
                    {
                        case "Set":
                            game.SetPlayerName(stringSplit[1]);
                            break;
                        case "Play":
                                game.Play(stringSplit[1]);
                            break;
                        case "ESC":
                            isRunning = false;
                            Console.WriteLine("Closing The Game");
                            break;

                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                

            }
            
        }
    }
}
