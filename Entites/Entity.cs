using System;

namespace Entities
{
    public abstract class Entity
    {
        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public virtual int Update()
        {
            return Health;
        }
    }
}