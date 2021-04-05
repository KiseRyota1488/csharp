using System;
using AllClasses;
using System.Collections.Generic;

namespace PlaceOfBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\tPress Spacebar to start a battle | Esc to end end the battle!");
            int roundCounter = 0, whichTeamWon = 3;
            List<Unit> alliance = new List<Unit>();
            List<Unit> orcs = new List<Unit>();

            GenerateTeams(alliance, orcs);

            ConsoleKeyInfo pressedKey;

            pressedKey = Console.ReadKey();
            Console.Clear();



            while (pressedKey.Key != ConsoleKey.Escape && pressedKey.Key == ConsoleKey.Spacebar && !IsGameOver(alliance, orcs, out whichTeamWon))
            {
                Console.Clear();

                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Team Alliance:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\tTeam Ocrs:");
                Console.ResetColor();
                
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        Console.Write($"{alliance[i].GetType().Name} HP:{alliance[i].Hp} Damage:{alliance[i].Damage}\t\t");
                        
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                        Console.Write("\t\t\t\t");
                    }
                    try
                    {
                        Console.WriteLine($"{orcs[i].GetType().Name} HP:{orcs[i].Hp} Damage:{orcs[i].Damage}");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("\t\t\t");
                    }
                }
                    Console.WriteLine();
                
                OneMove(alliance, orcs, ref roundCounter);
                RemoveDeadHeroes(alliance, orcs);

                pressedKey = Console.ReadKey();
            }
                        
            switch (whichTeamWon)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\tAlliance won, gratz Warriors!!!");
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\tOrcs won, for Sauron!!!");
                    break;
                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tEveryone dead,i wonder who will take all the swords home..");
                    break;
                default:
                    break;
            }

            Console.ResetColor();
        }

        static void OneMove(List<Unit> alliance, List<Unit> orcs, ref int roundCounter)
        {
            Random rnd = new Random();
            int choice, enemyId, allianceId, orcsId;

            Unit enemy, warrior;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\t\tRound: {roundCounter+1}");
            Console.ResetColor();

            if (roundCounter % 2 == 0)
            {
                choice = rnd.Next(alliance.Count);
                enemy = ChooseEnemy(alliance[choice], orcs);
                warrior = alliance[choice];
                enemyId = orcs.IndexOf(enemy) + 1;
                allianceId = 1;
                orcsId = 2;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"\n\tAlliance");
            }
            else
            {
                choice = rnd.Next(orcs.Count);
                enemy = ChooseEnemy(orcs[choice], alliance);
                warrior = orcs[choice];
                enemyId = alliance.IndexOf(enemy) + 1;
                allianceId = 2;
                orcsId = 1;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n\tOrcs");
            }

            Console.Write($" made a move:\n{warrior.GetType().Name}{allianceId}{choice + 1} attacked {enemy.GetType().Name}{orcsId}{enemyId} ");
            if (HitAnEnemy(warrior, enemy))
                Console.WriteLine("successfully");
            else
                Console.WriteLine("not successful");
            Console.WriteLine($"{warrior.GetType().Name}{allianceId}{choice + 1} HP:{warrior.Hp}\t{enemy.GetType().Name}{orcsId}{enemyId} HP:{enemy.Hp}");

            Console.ResetColor();

            roundCounter++;
        }

        static bool HitAnEnemy(Unit warrior, Unit enemy)
        {
            Random rnd = new Random();
            int hitChance = rnd.Next(100);
            if (hitChance > enemy.EvadeChance)
            {
                enemy.Hp -= warrior.Damage;
                return true;
            }
            else
                return false;
        }

        static Unit ChooseEnemy(Unit alliance, List<Unit> team)
        {
            foreach (var item in team)
            {
                if (item.GetType().Equals(alliance.GetType()))
                {
                    return item;
                }
            }

            Random rnd = new Random();
            int choice = rnd.Next(team.Count);

            return team[choice];
        }

        static void RemoveDeadHeroes(List<Unit> alliance, List<Unit> orcs)
        {
            for (int i = 0; i < alliance.Count; i++)
            {
                if (alliance[i].IsDead == true)
                    alliance.RemoveAt(i);
            }
            for (int i = 0; i < orcs.Count; i++)
            {
                if (orcs[i].IsDead == true)
                    orcs.RemoveAt(i);
            }
        }

        static bool IsGameOver(List<Unit> alliance, List<Unit> orcs, out int a)
        {
            if (alliance.Count == 0)
            {
                a = 2;
                return true;
            }
            else if (orcs.Count == 0)
            {
                a = 1;
                return true;
            }
            else if (alliance.Count == 0 && orcs.Count == 0)
            {
                a = 3;
                return true;
            }
            a = 3;
            return false;
        }

        static void GenerateTeams(List<Unit> alliance, List<Unit> orcs)
        {
            Random rnd = new Random();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int choice = rnd.Next(3);
                    switch (choice)
                    {
                        case 0:
                            if (i == 0)
                                alliance.Add(new Swordman());
                            else
                                orcs.Add(new Swordman());
                            break;
                        case 1:
                            if (i == 0)
                                alliance.Add(new Archer());
                            else
                                orcs.Add(new Archer());
                            break;
                        case 2:
                            if (i == 0)
                                alliance.Add(new Mage());
                            else
                                orcs.Add(new Mage());
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
