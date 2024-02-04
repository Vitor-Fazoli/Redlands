using Redlands.Interfaces;

namespace Redlands.Entities
{
    public class Character(string name, int lifeMax, IWeapon weapon, IProfession profession)
    {
        public string Name = name;
        public int Life { get; set; }
        public int LifeMax = lifeMax;
        public int xp;
        public int xpMax;
        public int level;
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
            Console.WriteLine($"+------------------------------+");
            Console.WriteLine($"| Nome: {Name}                 |");
            Console.WriteLine($"| Vida: {Life}/{LifeMax}       |");
            Console.WriteLine($"| Nível: {level}               |");
            Console.WriteLine($"| XP: {xp}/{xpMax}             |");
            Console.WriteLine($"| Profissão: {Profession.Name} |");
            Console.WriteLine($"| Arma: {Weapon.Name}          |");
            Console.WriteLine($"| Defesa: {Armor.Sum(x => x.Defense)}|");
            Console.WriteLine($"+------------------------------+");
        }
    }
}