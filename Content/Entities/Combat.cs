using Redlands.Abstract;

namespace Redlands.Entities
{
    public static class Combat
    {
        private readonly static int Turn = 1;
        private readonly static string[,] table = new string[3, 3];
        public static void OnCombatProgress(Entity player, Entity enemy)
        {
            player.ToString();
            Console.WriteLine("Escolha a posição da peça que deseja colocar (Ex: A1, B2, C3):");
            try
            {
                DrawTable(Console.ReadLine(), table);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                DrawTable(Console.ReadLine(), table);
            }
        }

        public static string[,] DrawTable(string position, string[,] table)
        {
            Console.Clear();

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

                const int SIZE = 3;

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

                Console.WriteLine($"+---+---+---+---+");
                Console.WriteLine($"|   | 1 | 2 | 3 |");
                Console.WriteLine($"+---+---+---+---+");
                Console.WriteLine($"| A | {table[0, 0]} | {table[1, 0]} | {table[2, 0]} |");
                Console.WriteLine($"|---+---+---+---+");
                Console.WriteLine($"| B | {table[0, 1]} | {table[1, 1]} | {table[2, 1]} |");
                Console.WriteLine($"|---+---+---+---+");
                Console.WriteLine($"| c | {table[0, 2]} | {table[1, 2]} | {table[2, 2]} |");
                Console.WriteLine($"+---+---+---+---+");
                return table;
            }
        }
        public static void DoAction(string[,] Table, Character character)
        {

        }
    }
}