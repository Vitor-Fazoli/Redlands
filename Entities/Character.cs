using Redlands.Interfaces;

namespace Redlands.Entities {
    public class Character(string name, int lifeMax, IWeapon weapon, IProfession profession)
    {
        public string Name = name;
        public int Life { get; set; }
        public int LifeMax = lifeMax;
        public IWeapon Weapon = weapon;
        public IProfession Profession = profession;
    }
}