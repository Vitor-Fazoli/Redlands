using Redlands.Interfaces;

namespace Redlands.Entities
{
    public abstract class Character(string name, int lifeMax, IWeapon weapon, IProfession profession)
    {
        public string Name = name;
        public int Life { get; set; }
        public int LifeMax = lifeMax;
        public int xp;
        public int xpMax;
        public int level;
        private  int Virtue;
        private int Resilience;
        private int Agility;
        public IWeapon Weapon = weapon;
        public IProfession Profession = profession;
        public IArmor[] Armor = new IArmor[4];

        public void LevelUp()
        {
            if (xp >= xpMax)
            {
                level++;
                xp -= xpMax;
                xpMax *= 2;
            }
        }
        public void XpGain(int amount)
        {
            xp += amount;
            LevelUp();
        }

        public void ShowStatus()
        {

        }
    }
}