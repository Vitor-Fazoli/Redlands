using System.Text;

namespace Redlands.Abstract {
    public class Entity {
        public const int ATRTIBUTE_POINTS = 6;

        //Status
        public string name;
        public int life;
        public int lifeMax;
        public int defense;
        public int initiative;
        public int criticalDamage;
        public int criticalRate;
        public bool dead = false;
        public bool damageable = true;
        public bool isFriendly = false;

        // Atributos
        public int virtue;
        public int resilience;
        public int agility;

        //Ataques
        public int[][,] Attacks;
    
        public Entity(string name, int resilience, int virtue, int agility){
            if(resilience+virtue+agility > ATRTIBUTE_POINTS){
                throw new Exception("A quantidade maxima de atributos foi ultrapassada");
            }else{
                this.name = name;
                this.resilience = resilience;
                this.agility = agility;
                this.virtue = virtue;
            }
        }
        public void Hurt(int amount){
            if(life <= 0){
                life = 0;
                dead = true;
            }else{
                life -= amount - defense;
            }
        }
        protected void SetAgility(int agility){
            if(agility <= 6){
                this.agility = agility;
            }else{
                throw new Exception("Não pode alocar mais do que a quantidade maxima de pontos");
            }
        }
        protected void SetVirtue(int virtue){
            if(virtue <= 6){
                this.virtue = virtue;
            }else{
                throw new Exception("Não pode alocar mais do que a quantidade maxima de pontos");
            }
        }
        protected void SetResilience(int resilience){
            if(resilience <= 6){
                this.resilience = resilience;
            }else{
                throw new Exception("Não pode alocar mais do que a quantidade maxima de pontos");
            }
        }
        public void SetDefault(){
            lifeMax = 1 + (virtue * 2) + resilience;
            life = lifeMax;
            defense = resilience / 2;
            initiative = agility;
            criticalRate = 15 - virtue;
            criticalDamage = 1 + (agility / 3);
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{name}");
            sb.AppendLine($"Vida: {life}/{lifeMax}");
            sb.AppendLine($"Defesa: {defense}");
            sb.AppendLine($"Iniciativa: {initiative}");
            sb.AppendLine($"Taxa Crítica: {criticalRate}");
            sb.AppendLine($"Dano Crítico: {criticalDamage}");

            return sb.ToString();
        }
    }
}