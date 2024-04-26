namespace Redlands.Common
{
    /// <summary>
    /// 
    /// </summary>
    public static class ConsoleExtras
    {
        /// <summary>
        /// 
        /// </summary>
        public static void RemoveLastChar()
        {
            int x = Console.GetCursorPosition().Left;
            int y = Console.GetCursorPosition().Top;

            if (x != 0)
            {
                Console.SetCursorPosition(x-1, y);
                Console.Write(" ");
                Console.SetCursorPosition(x - 1, y);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="question"> the question about </param>
        /// <param name="options"> n... questions can be chosen</param>
        /// <returns></returns>
        public static string CreateMenu(string question, params string[] options)
        {
            bool leave = false;
            int optionSelected = 0;
            int maxOptions = options.Length;

            while (!leave)
            {
                Console.Clear(); // Limpa a tela a cada iteração

                // Mostra o menu
                Console.WriteLine($"{question}");

                // Mostra a seleção atual
                for (int i = 0; i < maxOptions; i++)
                {
                    if (i == optionSelected)
                        Console.Write(" -> ");
                    else
                        Console.Write("    ");
                    Console.WriteLine($"{i + 1} - {options[i]}");
                }

                // Lê a tecla pressionada pelo usuário
                ConsoleKeyInfo tecla = Console.ReadKey(true);

                // Verifica a tecla pressionada
                switch (tecla.Key)
                {
                    case ConsoleKey.UpArrow:
                        optionSelected = Math.Max(0, optionSelected - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        optionSelected = Math.Min(maxOptions - 1, optionSelected + 1);
                        break;
                    case ConsoleKey.Enter:
                        if (optionSelected == 0)
                            leave = true; // Sai do loop e encerra o programa
                        else
                        {
                            Console.WriteLine($"Você escolheu a opção {optionSelected + 1}.");
                            return options[optionSelected];
                        }

                        Console.ReadKey();
                        break;
                }
            }

            return string.Empty;
        }
    }
}
