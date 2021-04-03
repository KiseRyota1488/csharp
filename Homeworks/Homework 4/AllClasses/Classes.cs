using System;
using System.Collections.Generic;

namespace AllClasses
{
    public abstract class Unit
    {
        int hp;
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                if ((hp = value) < 0)
                    hp = 0;
                else
                    hp = value;
            }
        }
        public int Damage { get; set; }
        public int EvadeChance { get; set; }
        public bool IsDead { get; set; } = false;

        public Unit()
        {
            
        }

    }

    public class Swordman : Unit
    {
        public Swordman()
        {
            Hp = 15;
            Damage = 5;
            EvadeChance = 30;
        }
    }
    public class Archer : Unit
    {
        public Archer()
        {
            Hp = 12;
            Damage = 4;
            EvadeChance = 60;
        }
    }
    class Mage : Unit
    {
        public Mage()
        {
            Hp = 8;
            Damage = 10;
            EvadeChance = 40;
        }
    }
    
    
    public class Team
    {
        public Unit Unit { get; set; }
        public Team()
        {
            Random rnd = new Random();
            int choice = rnd.Next(3);

            switch (choice)
            {
                case 0:
                    Unit = new Swordman();
                    break;
                case 1:
                    Unit = new Archer();
                    break;
                case 2:
                    Unit = new Mage();
                    break;
                default:
                    break;
            }
        }
    }

}
