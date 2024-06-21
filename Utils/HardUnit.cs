using GamePrototype.Items.EconomicItems;
using GamePrototype.Items.EquipItems;
using GamePrototype.Units;

namespace GamePrototype.Utils
{
    public class HardUnit : UnitFactoryDemo
    {
        public override Unit CreatePlayer(string name)
        {
            var player = new Player(name, 20, 20, 4);
            player.AddItemToInventory(new Weapon(5, 10, "Sword"));
            player.AddItemToInventory(new Armour(5, 10, "Armour"));
            player.AddItemToInventory(new HealthPotion("Potion"));
            return player;
        }

        public override Unit CreateGoblinEnemy() => new Goblin(GameConstants.Goblin, 20, 20, 7);

        public Unit CreateGoblinBoss() => new Goblin(GameConstants.Goblin, 30, 30, 8);
    }
}
