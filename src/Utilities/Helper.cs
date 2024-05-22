using System;
using System.Threading;

namespace Redlands
{
    public static class Helper
    {
        // public static Task<object> SupaBaseInitialize()
        // {
        //     var url = Environment.GetEnvironmentVariable("url");
        //     var key = Environment.GetEnvironmentVariable("key");

        //     if (url is null || key is null)
        //     {
        //         Environment.SetEnvironmentVariable("url", "https://jyibpyexnjcwvdavoipt.supabase.co");
        //         Environment.SetEnvironmentVariable("key", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Imp5aWJweWV4bmpjd3ZkYXZvaXB0Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3MTQwODA3MTMsImV4cCI6MjAyOTY1NjcxM30.ktVOIjpJXs5ngyGpy5RtkPFmgDe6YLrVYaP-Nj2xnpk");
        //     }

        //     url = Environment.GetEnvironmentVariable("url");
        //     key = Environment.GetEnvironmentVariable("key");

        //     // var options = new Supabase.SupabaseOptions
        //     // {
        //     //     AutoConnectRealtime = true
        //     // };

        //     // var supabase = new Supabase.Client(url, key, options);
        //     // await supabase.InitializeAsync();

        //     //return supabase;
        // }

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