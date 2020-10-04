namespace Entities
{
    public class UnitLevel
    {
        private int _current, _max, _points, _levelup;

        public int Current { get { return _current; } }
        public int Max { get { return _max; } }
        public int Points { get { return _points; } }
        public int LevelupPoints { get { return _levelup; } }

        public UnitLevel(int maxlevel, int leveluppoints)
        {
            _max = maxlevel;
            _levelup = leveluppoints;
        }

        public bool AddPoints(int points)
        {
            _points += points;
            int beforeNewLevel = _points - _levelup;
            if (beforeNewLevel >= 0)
            {
                _points = beforeNewLevel;
                return true;
            }
            return false;
        }
    }
}