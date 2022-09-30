using System;
using System.Collections.Generic;

namespace passwordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Kérlek add meg, hogy milyen hosszú legyen a jelszó! ");
                Console.WriteLine($"Az ön jelszava: {PasswordGenerator(Int32.Parse(Console.ReadLine()))}");
                Console.ReadLine();

        }

        static string PasswordGenerator(int length)
        {
            if (length <= 1)
            {
                throw new Exception("Nem lehet kisebb vagy egyenlő mint 1");
            }

            string chars = "abcdefghijklmnopqrstuvwxyz1234567890!@#$%&";

            Random random = new Random();

            string password = String.Empty;
            for (int i = 0; i < length; i++)
            {
                if (random.Next(0, 2) == 0)
                    password += chars[random.Next(0, chars.Length)].ToString().ToUpper();
                else
                    password += chars[random.Next(0, chars.Length)];
            }
            return password;
        }
    }
}
