using Redlands.Common;

namespace Redlands
{
    public static class Helper
    {

        public static void InitialConfiguration()
        {
            //Console.Title = "Redlands";
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.Clear();

            Console.WriteLine(" _____       _ __              _     ");
            Console.WriteLine("| __  |___ _| |  |   ___ ___ _| |___ ");
            Console.WriteLine("|    -| -_| . |  |__| .'|   | . |_ -|");
            Console.WriteLine("|__|__|___|___|_____|__,|_|_|___|___|\n");
        }

        public static void WriteSleepyText(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                if(message[i] == '.'){
                    Console.WriteLine(".");
                }else{
                    Console.Write(message[i]);
                }
                Thread.Sleep(50);
            }
        }
        public static void WriteMenu(string Text,List<Option> options, Option selectedOption)
        {
            Console.Clear();
            Console.WriteLine(Text);
            foreach (Option option in options)
            {
                if (option == selectedOption)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine(option.Name);
            }
        }
    }
}