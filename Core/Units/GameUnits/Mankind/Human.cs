namespace Entities
{

    namespace Units
    {

        public abstract class Human : Unit
        {
            protected string God;
            protected int FaithLevel;

            public int Pray()
            {
                FaithLevel /= 2;
                return FaithLevel;
            }
            public Human(string faith)
            {
                God = faith;
                FaithLevel = 10;
                Live = true;
                Age = 0;
                Strength = 10;
                Agility = 10;
                Intelligence = 10;
            }
        }
    }
}