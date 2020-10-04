using System;

namespace Entities
{
    public abstract class Unit
    {
        protected bool Live { get; set; }
        protected int Health { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }


        public virtual int GetHealth()
        {
            return Health;
        }
        public virtual bool Attack(Entity enemy)
        {
            if (Level > 0)
            {
                return enemy.GetDamage(Level);
            }
            return false;
        }
        public virtual bool GetDamage(int damage)
        {
            int ReceivedDamage = damage - Level;
            if (ReceivedDamage > 0)
            {
                Health -= ReceivedDamage;
                return true;
            }
            return false;
        }
        public virtual int Update()
        {
            if (Health < Level)
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