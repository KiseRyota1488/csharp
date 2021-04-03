using System;
using AllClasses;
using System.Collections.Generic;
using System.Threading;


namespace PlaceOfBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int roundCounter = 0;
            List<Team> alliance = new List<Team>() { new Team(), new Team(), new Team() };
            List<Team> orcs = new List<Team>() { new Team(), new Team(), new Team() };



            int teamLost;
            while (!IsGameOver(alliance, orcs, out teamLost))
            {
                OneMove(alliance, orcs, ref roundCounter);
                UpdateHeroStatus(alliance, orcs);
                RemoveDeadHeroes(alliance, orcs);
                //Thread.Sleep(2000);
            }

            if (IsGameOver(alliance, orcs, out teamLost))
            {
                if (teamLost == 1)
                {
                    ConsoleColor color = ConsoleColor.Green;
                    Console.ForegroundColor = color;
                    Console.WriteLine("Orcs won!");
                }
                if (teamLost == 2)
                {

                    ConsoleColor color = ConsoleColor.Cyan;
                    Console.ForegroundColor = color;
                    Console.WriteLine("Alliance won!");
                }
                if (teamLost == 0)
                    Console.WriteLine("Draw, although it's better to say that everyone died!");

            }


        }

        static void OneMove(List<Team> alliance, List<Team> orcs, ref int roundCounter)
        {
            Random rnd = new Random();
            int choiceAll = rnd.Next(alliance.Count), choiceOrc = rnd.Next(orcs.Count);

            if (roundCounter % 2 == 0)
            {
                if (HitEnemy(ChooseAttacker(alliance, choiceAll), ChooseEnemy(alliance[choiceAll], orcs)))
                {
                    Console.WriteLine($"\tAlliance made a move:\n{ChooseAttacker(alliance, choiceAll).Unit.GetType().Name}1{choiceAll + 1} attacked {ChooseEnemy(alliance[choiceAll], orcs).Unit.GetType().Name}2{orcs.IndexOf(ChooseEnemy(alliance[choiceAll], orcs)) + 1}");
                    Console.WriteLine($"{ChooseAttacker(alliance, choiceAll).Unit.GetType().Name}1{choiceAll + 1} HP:{ChooseAttacker(alliance, choiceAll).Unit.Hp}\t{ChooseEnemy(alliance[choiceAll], orcs).Unit.GetType().Name}2{orcs.IndexOf(ChooseEnemy(alliance[choiceAll], orcs)) + 1} HP:{ChooseEnemy(alliance[choiceAll], orcs).Unit.Hp}");
                }
                else
                    Console.WriteLine("1");
            }
            else
            {
                if (HitEnemy(ChooseAttacker(orcs, choiceOrc), ChooseEnemy(orcs[choiceOrc], alliance)))
                {
                    Console.WriteLine($"\tOrcs made a move:\n{ChooseAttacker(orcs, choiceOrc).Unit.GetType().Name}2{choiceOrc + 1} attacked {ChooseEnemy(orcs[choiceOrc], alliance).Unit.GetType().Name}1{alliance.IndexOf(ChooseEnemy(orcs[choiceOrc], alliance)) + 1}");
                    Console.WriteLine($"{ChooseAttacker(orcs, choiceOrc).Unit.GetType().Name}2{choiceOrc + 1} HP:{ChooseAttacker(orcs, choiceOrc).Unit.Hp}\t{ChooseEnemy(orcs[choiceOrc], alliance).Unit.GetType().Name}1{alliance.IndexOf(ChooseEnemy(orcs[choiceOrc], alliance)) + 1} HP:{ChooseEnemy(orcs[choiceOrc], alliance).Unit.Hp}");
                }
                else
                    Console.WriteLine("1");
            }

            roundCounter++;
        }

        static Team ChooseAttacker(List<Team> team, int choice)
        {
            if (team[choice].Unit.IsDead == false)
                return team[choice];
            if (team[0].Unit.IsDead == false)
                return team[0];
            else if (team[1].Unit.IsDead == false)
                return team[1];
            else if (team[2].Unit.IsDead == false)
                return team[2];

            return team[2];
        }
        static Team ChooseEnemy(Team alliance, List<Team> team)
        {
            int it = 0;
            foreach (var item in team)
            {
                if (item.Unit.GetType().Equals(alliance.Unit.GetType()) && item.Unit.IsDead == false)
                {
                    return item;
                }
                else if (it == 2 && item.Unit.IsDead == false)
                    return item;
                it++;
            }

            return new Team();
        }

        static void RemoveDeadHeroes(List<Team> alliance, List<Team> orcs)
        {
            for (int i = 0; i < alliance.Count; i++)
            {
                if (alliance[i].Unit.IsDead == true)
                    alliance.RemoveAt(i);
            }
            for (int i = 0; i < orcs.Count; i++)
            {
                if (orcs[i].Unit.IsDead == true)
                    orcs.RemoveAt(i);
            }
        }

        static bool HitEnemy(Team attacker, Team defender)
        {
            if (attacker.Unit.Hp != 0)
                defender.Unit.Hp -= attacker.Unit.Damage;
            else
                return false;

            return true;
        }

        static bool IsGameOver(List<Team> alliance, List<Team> orcs, out int a)
        {
            int cond = 0;
            foreach (var item in alliance)
            {
                if (item.Unit.IsDead == true)
                {
                    cond++;
                }
            }
            if (cond == 3)
            {
                a = 1;
                return true;
            }

            cond = 0;
            foreach (var item in orcs)
            {
                if (item.Unit.IsDead == true)
                {
                    cond++;
                }
            }
            if (cond == 3)
            {
                a = 2;
                return true;
            }

            a = 0;
            return false;
        }

        static void UpdateHeroStatus(List<Team> alliance, List<Team> orcs)
        {
            foreach (var item in alliance)
            {
                if (item.Unit.Hp == 0)
                    item.Unit.IsDead = true;
            }
            foreach (var item in orcs)
            {
                if (item.Unit.Hp == 0)
                    item.Unit.IsDead = true;
            }
        }
    }



}
