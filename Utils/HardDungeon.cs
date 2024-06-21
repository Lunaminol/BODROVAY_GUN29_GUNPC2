using GamePrototype.Dungeon;
using GamePrototype.Items.EconomicItems;
using GamePrototype.Units;

namespace GamePrototype.Utils
{
    public class HardDungeon : DungeonBuilder
    {
        public HardDungeon(HardUnit unitFactory) : base(unitFactory) { }
        public Unit CreatePlayer(string name)
        {
            return _unitFactory.CreatePlayer(name);
        }
        public override DungeonRoom BuildDungeon()
        {
            var enter = new DungeonRoom("Enter");
            var monsterRoom = new DungeonRoom("Monster", _unitFactory.CreateGoblinEnemy());
            var monsterRoomTwo = new DungeonRoom("Monster", _unitFactory.CreateGoblinEnemy());
            var emptyRoom = new DungeonRoom("Empty");
            var lootRoom = new DungeonRoom("Loot1", new Gold());
            var lootStoneRoom = new DungeonRoom("Loot1", new Grindstone("Stone"));
            var finalRoom = new DungeonRoom("Final", new Grindstone("Stone1"));

            enter.TrySetDirection(Direction.Forward, monsterRoom);
            enter.TrySetDirection(Direction.Left, emptyRoom);

            monsterRoom.TrySetDirection(Direction.Left, emptyRoom);
            monsterRoom.TrySetDirection(Direction.Right, lootStoneRoom);

            emptyRoom.TrySetDirection(Direction.Right, monsterRoomTwo);
            emptyRoom.TrySetDirection(Direction.Left, lootRoom);

            lootStoneRoom.TrySetDirection(Direction.Forward, monsterRoomTwo);
            lootRoom.TrySetDirection(Direction.Right, monsterRoomTwo);

            monsterRoomTwo.TrySetDirection(Direction.Left, lootRoom);
            monsterRoomTwo.TrySetDirection(Direction.Right, finalRoom);

            return enter;
        }
    }
}