using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redlands.Common
{
    public static class Auth
    {
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo key;

            // User Write the password
            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Enter)
                {
                    if (key.Key is ConsoleKey.Backspace)
                    {
                        password.Remove(password.Length);
                        ConsoleExtras.RemoveLastChar();
                    }
                    else
                    {
                        password += key.KeyChar;
                        Console.Write("*");
                    }
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return password;
        }

        public static bool PasswordIsValid(string password)
        {
            return password.Length >= 12;
        }
    }
}
