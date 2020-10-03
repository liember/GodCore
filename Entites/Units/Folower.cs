using System;

namespace Entities
{
    namespace Units
    {
        public class Folower : Unit
        {
            private string Faith { get; set; }
            private int FaithLevel { get; set; }

            public Folower(string f)
            {
                Faith = f;
                FaithLevel = 10;
            }

            public int Pray()
            {
                return FaithLevel;
            }

        }
    }
}