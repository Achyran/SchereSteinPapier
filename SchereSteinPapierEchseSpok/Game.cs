using System;
using System.Collections.Generic;
using System.Text;

namespace SchereSteinPapierEchseSpok
{
    class Game
    {
        public Dictionary<string,Creature> creatures { get; private set; }
        private Random rand;
        private string playerName;

        public Game()
        {

            playerName = "";
            creatures = new Dictionary<string, Creature>();

            rand = new Random();

            //To Improve: add Json Support for the creatures
            creatures.Add("Stein",new Creature("Stein",new string[] { "Papier", "Spock" },new string[] { "Schere", "Echse" }));
            creatures.Add("Schere",new Creature("Schere", new string[] { "Spock", "Stein" }, new string[] { "Papier", "Echse" }));
            creatures.Add("Papier",new Creature("Papier", new string[] { "Schere", "Echse" }, new string[] { "Stein", "Spock" }));
            creatures.Add("Echse",new Creature("Echse", new string[] { "Stein", "Schere" }, new string[] { "Spock", "Papier" }));
            creatures.Add("Spock",new Creature("Spock", new string[] { "Echse", "Papier" }, new string[] { "Schere", "Stein" }));
        }
        public void SetPlayerName(string pName)
        {
            playerName = pName;
            Console.WriteLine($"Name Set as {playerName}");
        }


        public void Play(string pPlayerInput)
        {
            
            if (playerName == "")
            {
                Console.WriteLine("Please Set a Player Name");
                return;
            }

            //bool test = creatures.ContainsKey(pPlayerInput);

            if (!creatures.ContainsKey(pPlayerInput))
            {
                Console.WriteLine($"{pPlayerInput} is not in the Game");
                return;
            }

            string cpuChoice = CpuChoice();




            Console.WriteLine($"{playerName} played:    {pPlayerInput}\nCPU played:    {cpuChoice}");

            if (creatures[pPlayerInput].strenghts.Contains(cpuChoice))
            {
                Console.WriteLine($"{playerName} Won");
            }
            else if (creatures[pPlayerInput].weaknesses.Contains(cpuChoice))
            {
                Console.WriteLine($"{playerName} Lost");
            }
            else if(pPlayerInput == cpuChoice)
            {
                Console.WriteLine("It's a draw");
            }
            else
            {
                Console.WriteLine($"Interaction between {pPlayerInput} and {cpuChoice} is missing");
            }
           
           
        }

        private string CpuChoice()
        {
            List<string> strings = new List<string>();
            foreach (KeyValuePair<string,Creature> c in creatures)
            {
                strings.Add(c.Key);
            }

            return strings[rand.Next(0, strings.Count)];
        }

        


    }
}
