namespace Redlands.Entities
{
    public static class Combat//(Character hero, Character enemy)
    {
        //public bool isInCombat = true;

        public static void DrawTable(string position)
        {
            if (position.Length > 2 || position.Length < 2)
            {
                throw new Exception("Invalid position");
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
                        _ => throw new Exception("Invalid row"),
                    },
                    column switch
                    {
                        '1' => 0,
                        '2' => 1,
                        '3' => 2,
                        _ => throw new Exception("Invalid column"),
                    },
                ];

                string[,] table = new string[3, 3];
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
                            try
                            {

                                table[i, j] = " ";
                            }
                            catch (Exception)
                            {
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
            }
        }
    }
}