using System.Text;

namespace Redlands.Abstract
{
    public class Entity
    {
        public const int ATRTIBUTE_POINTS = 6;
        public const int SIZE = 3;

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
        public Profession profession;

        public string[,] table;

        //Ataques
        public List<string[,]> Attacks = [];

        public Entity(string name, int resilience, int virtue, int agility)
        {
            table = new string[,] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };

            Attacks.Add(new string[,] { { " ", "o", " " }, { " ", "o", " " }, { " ", "o", " " } });

            if (resilience + virtue + agility > ATRTIBUTE_POINTS)
            {
                throw new Exception("A quantidade maxima de atributos foi ultrapassada");
            }
            else
            {
                this.name = name;
                this.resilience = resilience;
                this.agility = agility;
                this.virtue = virtue;
            }
        }
        public void Hurt(int amount)
        {
            if (life <= 0)
            {
                life = 0;
                dead = true;
            }
            else
            {
                life -= amount - defense;
            }
        }
        protected void SetAgility(int agility)
        {
            if (agility <= 6)
            {
                this.agility = agility;
            }
            else
            {
                throw new Exception("Não pode alocar mais do que a quantidade maxima de pontos");
            }
        }
        protected void SetVirtue(int virtue)
        {
            if (virtue <= 6)
            {
                this.virtue = virtue;
            }
            else
            {
                throw new Exception("Não pode alocar mais do que a quantidade maxima de pontos");
            }
        }
        protected void SetResilience(int resilience)
        {
            if (resilience <= 6)
            {
                this.resilience = resilience;
            }
            else
            {
                throw new Exception("Não pode alocar mais do que a quantidade maxima de pontos");
            }
        }
        public void SetDefault()
        {
            lifeMax = 1 + (virtue * 2) + resilience;
            life = lifeMax;
            defense = resilience / 2;
            initiative = agility;
            criticalRate = 15 - virtue;
            criticalDamage = 1 + (agility / 3);
        }

        public string[,] PlacePiece(string position)
        {
            if (position.Length > 2 || position.Length < 2)
            {
                throw new Exception("Posição invalida, tente novamente.\n Escolha a posição da peça que deseja colocar (Ex: A1, B2, C3):");
            }
            else
            {
                char row = position[0];
                char column = position[1];

                int[] result =
                [
                    row switch
                    {
                        'A' => 0,
                        'B' => 1,
                        'C' => 2,
                        _ => throw new Exception("Linha escolhida invalida, tente novamente."),
                    },
                    column switch
                    {
                        '1' => 0,
                        '2' => 1,
                        '3' => 2,
                        _ => throw new Exception("Coluna escolhida invalida, tente novamente."),
                    },
                ];

                for (int i = 0; i < SIZE; i++)
                {
                    for (int j = 0; j < SIZE; j++)
                    {
                        if (i == result[1] && j == result[0])
                        {
                            table[i, j] = "o";
                        }
                        else
                        {
                            if (table[i, j] != "o")
                            {
                                table[i, j] = " ";
                            }
                        }
                    }
                }
                return table;
            }
        }
        public bool VerifyAttack()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (Attacks[0][i, j] == "o")
                    {
                        if (table[i, j] == Attacks[0][i, j])
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            ResetTable();
            return true;
        }

        protected void ResetTable()
        {
            table = new string[,] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
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