using System;
using System.Diagnostics;

namespace Hello_World
{
    class Program
    {
        static void Main()
        {
            EnterName();
        }

        static void EnterName()
        {
            Console.WriteLine("Please enter your name");

            try
            {
                string nameEntry = Console.ReadLine();
                if (nameEntry.Length > 0)
                {
                    Console.WriteLine(UserName(nameEntry));
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Please try again.");
                    Main();
                }
            }
            catch
            {
                Debug.WriteLine("Throw error here.");
            }
        }

        static string UserName (string name)
        {
            return $"Welcome {name}. Hello World";
        }
    }
}
