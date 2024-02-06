using Redlands.Enums;

namespace Redlands.Interfaces
{
    public interface IWeapon
    {
        public WeaponID Type { get; }
        public string Name { get; }
        public int Damage { get; }
    }
}