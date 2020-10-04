using System;

namespace Entities
{
    public abstract class Unit
    {
        protected int Age;
        protected int DieAge;
        protected UnitLevel Level;
        protected bool Live;
        protected int Health;
        protected int Strength;
        protected int Agility;
        protected int Intelligence;


        public virtual int GetHealth()
        {
            return Health;
        }
        public virtual bool Attack(Unit enemy)
        {
            if (Level.Current <= 0)
            {
                return enemy.GetDamage(Strength);
            }
            return false;
        }
        public virtual bool GetDamage(int damage)
        {
            int ReceivedDamage = damage - Level.Current * Agility;
            if (ReceivedDamage > 0)
            {
                Health -= ReceivedDamage;
                return true;
            }
            return false;
        }
        public virtual int Update()
        {
            if (Health < Level.Current)
            {
                Health++;
            }
            return Health;
        }
        public virtual bool Die()
        {
            Live = false;
            Health = 0;
            return true;
        }
    }
}