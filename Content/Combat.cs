using Redlands.Abstract;

namespace Redlands.Entities
{
    public static class Combat
    {
        private static int Turn = 1;
        public static void OnCombatInit(Entity player, Entity enemy)
        {


            OnCombatProgress(player, enemy);
        }
        public static void OnCombatProgress(Entity player, Entity enemy)
        {
            while (player.life > 0 || enemy.life > 0)
            {
                bool isRoundPlayer;
                if (player.initiative > enemy.initiative && Turn == 1)
                {
                    isRoundPlayer = true;
                }
                else
                {
                    isRoundPlayer = false;
                }

                if (isRoundPlayer is true)
                {
                    isRoundPlayer = false;
                }
                else
                {
                    isRoundPlayer = true;
                }

                DrawTable(player, enemy, isRoundPlayer);
            }
        }
        public static void DrawTable(Entity player, Entity enemy, bool isPlayerRound)
        {
            if (Turn == 1)
            {
                Console.WriteLine("A batalha se inicia");
            }

            Console.WriteLine("Turno: " + Turn);
            Console.WriteLine($"+---+---+---+---+" + $" {enemy.name}                           ");
            Console.WriteLine($"|   | 1 | 2 | 3 |" + $" Vida: {enemy.life}/{enemy.lifeMax}     ");
            Console.WriteLine($"+---+---+---+---+" + $" Defesa: {enemy.defense}                ");
            Console.WriteLine($"| A | {enemy.table[0, 0]} | {enemy.table[1, 0]} | {enemy.table[2, 0]} |" + $" Iniciativa: {enemy.initiative}         ");
            Console.WriteLine($"|---+---+---+---+" + $" Taxa Crítica: {enemy.criticalRate}     ");
            Console.WriteLine($"| B | {enemy.table[0, 1]} | {enemy.table[1, 1]} | {enemy.table[2, 1]} |" + $" Dano Crítico: {enemy.criticalDamage}   ");
            Console.WriteLine($"|---+---+---+---+" + $"                                        ");
            Console.WriteLine($"| c | {enemy.table[0, 2]} | {enemy.table[1, 2]} | {enemy.table[2, 2]} |" + $"                                        ");
            Console.WriteLine($"+---+---+---+---+" + $"                                        ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"+---+---+---+---+" + $" {player.name}                           ");
            Console.WriteLine($"|   | 1 | 2 | 3 |" + $" Vida: {player.life}/{player.lifeMax}    ");
            Console.WriteLine($"+---+---+---+---+" + $" Defesa: {player.defense}                ");
            Console.WriteLine($"| A | {player.table[0, 0]} | {player.table[1, 0]} | {player.table[2, 0]} |" + $" Iniciativa: {player.initiative}         ");
            Console.WriteLine($"|---+---+---+---+" + $" Taxa Crítica: {player.criticalRate}     ");
            Console.WriteLine($"| B | {player.table[0, 1]} | {player.table[1, 1]} | {player.table[2, 1]} |" + $" Dano Crítico: {player.criticalDamage}   ");
            Console.WriteLine($"|---+---+---+---+" + $"                                         ");
            Console.WriteLine($"| c | {player.table[0, 2]} | {player.table[1, 2]} | {player.table[2, 2]} |" + $"                                         ");
            Console.WriteLine($"+---+---+---+---+" + $"                                         ");

            if (isPlayerRound)
            {
                Console.WriteLine("\n Coloque uma peça em campo");
                player.PlacePiece(Console.ReadLine());

                if (player.VerifyAttack())
                {
                    enemy.life -= 1;
                }

                Console.Clear();
                Turn++;
            }
            else
            {
                Console.WriteLine("Aguardando a jogada do inimigo");

                enemy.PlacePiece("A1");
                if (enemy.VerifyAttack())
                {
                    player.life -= 1;
                }

                Console.Clear();
                Turn++;
            }
        }
    }
}