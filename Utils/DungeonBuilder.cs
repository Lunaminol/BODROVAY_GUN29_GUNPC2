using GamePrototype.Dungeon;
using GamePrototype.Items.EconomicItems;
using GamePrototype.Units;

namespace GamePrototype.Utils
{
    public abstract class DungeonBuilder
    {
        protected UnitFactoryDemo _unitFactory;
        public DungeonBuilder(UnitFactoryDemo unitFactory)
        {
            _unitFactory = unitFactory;
        }
        public Unit CreatePlayer(string name)
        {
            return _unitFactory.CreatePlayer(name);
        }
        public abstract DungeonRoom BuildDungeon();
    }
}

