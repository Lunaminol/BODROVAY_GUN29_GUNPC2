using GamePrototype.Utils;

namespace GamePrototype.Items.EquipItems
{
    public sealed class Bow : EquipItem
    {
        public Bow(uint damage, uint durability, string name) : base(durability, name) => Damage = damage;

        public uint Damage { get; }
        public override EquipSlot Slot => EquipSlot.Bow;
    }
}