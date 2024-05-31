using System;
using System.Threading;

namespace Redlands
{
    public static class Helper
    {
        public static void RenderInitialScreen()
        {

            //await SupaBaseInitialize();



            // Console.Title = "Redlands";
            // Console.ForegroundColor = ConsoleColor.DarkRed;
            // Console.Clear();

            // Console.WriteLine(" _____       _ __              _     ");
            // Console.WriteLine("| __  |___ _| |  |   ___ ___ _| |___ ");
            // Console.WriteLine("|    -| -_| . |  |__| .'|   | . |_ -|");
            // Console.WriteLine("|__|__|___|___|_____|__,|_|_|___|___|\n");

            // Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteSleepyText(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == '.')
                {
                    Console.WriteLine(".");
                }
                else
                {
                    Console.Write(message[i]);
                }
                Thread.Sleep(50);
            }
        }
    }
}