namespace Redlands {
    public static class Helper
    {

        public static void InitialConfiguration(){
            Console.Title = "Redlands";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            Console.WriteLine(" _____       _ __              _     ");
            Console.WriteLine("| __  |___ _| |  |   ___ ___ _| |___ ");
            Console.WriteLine("|    -| -_| . |  |__| .'|   | . |_ -|");
            Console.WriteLine("|__|__|___|___|_____|__,|_|_|___|___|\n");
        }
        
        public static void WriteText(string message){
            for(int i = 0; i < message.Length; i++){
                Console.Write(message[i]);
                Thread.Sleep(50);
            }
        }
    }
}