using System;
using AllClasses;
using System.Collections.Generic;


namespace PlaceOfBattle
{
    enum Classes
    {
        Swordman = 1,
        Archer,
        Mage
    }
    class Program
    {
        static void Main(string[] args)
        {
            int roundCounter = 0;
            List<Team> alliance = new List<Team>() { new Team(), new Team(), new Team() };
            List<Team> orcs = new List<Team>() { new Team(), new Team(), new Team() };

            
            OneRound(ref alliance, ref orcs, ref roundCounter);
        }
        static void OneRound(ref List<Team> alliance, ref List<Team> orcs,ref int roundCounter)
        {
            Random rnd = new Random();
            int choice = rnd.Next(3);

            if (roundCounter % 2 == 0)
            {
                ChooseEnemy(alliance[choice].Unit.GetType().Name, ref orcs).Unit.Hp -= alliance[choice].Unit.Damage;
                
            }



            roundCounter++;
        }

        static Team ChooseEnemy(string classType, ref List <Team> team)
        {
            int it = 0;
            foreach (var item in team)
            {
                if (item.Unit.GetType().Name == classType)
                {
                    return item;
                }
                else if(it == 2)
                    return item;
                it++;
            }

            return new Team();
        }
    }



}
