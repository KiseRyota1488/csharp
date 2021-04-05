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
                if ((hp = value) <= 0)
                {
                    hp = 0;
                    IsDead = true;
                }
                else
                    hp = value;
            }
        }
        public int Damage { get; set; }
        public int EvadeChance { get; set; }
        public bool IsDead { get; set; }

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
    public class Mage : Unit
    {
        public Mage()
        {
            Hp = 8;
            Damage = 10;
            EvadeChance = 40;
        }
    }
}
