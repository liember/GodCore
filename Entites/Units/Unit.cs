namespace Entities
{

    namespace Units
    {

        public abstract class Unit : Entity
        {
            public bool Live { get; set; }
            public short Age { get; set; }
            public int Strength { get; set; }
            public int Agility { get; set; }
            public int Intelligence { get; set; }

            public Unit()
            {
                Live = true;
                Age = 0;
                Strength = 10;
                Agility = 10;
                Intelligence = 10;
            }

            public virtual bool Move(int x, int y)
            {

                return true;
            }

            public virtual bool Die()
            {
                Live = false;
                Health = 0;
                return true;
            }

        }

    }
}