using System.Collections.Generic;


namespace Terrain
{

    public abstract class Tile
    {
        private bool Occupied;
        protected int MaxLocatedEntities = 10;
        protected List<Entities.Entity> LocatedEntities;
        protected int MaxEffect = 10;
        protected List<Entities.Entity> Effect;


        public virtual bool AddEntity(Entities.Entity e)
        {
            if (LocatedEntities.Count + 1 <= MaxLocatedEntities)
            {
                LocatedEntities.Add(e);
                return true;
            }
            return false;
        }
        public virtual int Update()
        {

            return 1;
        }
        public virtual bool IsOccupied()
        {
            return Occupied;
        }
    }

}