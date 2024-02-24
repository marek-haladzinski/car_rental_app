using CarRentalConsoleApp.frontend;
using CarRentalConsoleApp.backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

class Program
{
    public static void Main()
    {

        Display.DisplayWelcome();

        while (true)
        {
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Display.DisplayK();
                    Display.DisplayS();
                    break;

                case "2":
                    Console.WriteLine("Test2");
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    break;
            }

            Display.DisplayWelcome();
        }  
    }
}
